using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace DB
{
	public class DatabaseContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.EnableSensitiveDataLogging();
			optionsBuilder.UseLazyLoadingProxies().UseSqlServer(
				@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MusicWorkoutsAndOthersDb;MultipleActiveResultSets=True");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			TablesConfiguration(modelBuilder);

			PropertiesConfiguration(modelBuilder);

			RelationshipsConfiguration(modelBuilder);

			SeedData(modelBuilder);

			ConvertersConfiguration(modelBuilder);
		}

		private static void PropertiesConfiguration(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Song>().ToTable("Song");
			modelBuilder.Entity<Album>().ToTable("Album");
			modelBuilder.Entity<Genre>().ToTable("Genre");
			modelBuilder.Entity<Workout>().ToTable("Workout");
			modelBuilder.Entity<Directories>().ToTable("Directories");
			modelBuilder.Entity<UniFileFormat>().ToTable("UniFileFormat");
			modelBuilder.Entity<UrlReplacement>().ToTable("UrlReplacement");
			modelBuilder.Entity<YearLyricsChangeDetailsException>().ToTable("YearLyricsChangeDetailsException");
			modelBuilder.Entity<GrimeArtist>().ToTable("GrimeArtist");
		}

		private static void TablesConfiguration(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<GrimeArtist>().Property(e => e.Id).ValueGeneratedOnAdd();
			modelBuilder.Entity<GrimeArtist>().Property(e => e.ArtistName).IsRequired();
			modelBuilder.Entity<Song>().Property(e => e.Id).ValueGeneratedOnAdd();
			modelBuilder.Entity<Song>().Property(e => e.Filename).IsRequired();
			modelBuilder.Entity<Song>().Property(e => e.Title).IsRequired();
			modelBuilder.Entity<Song>().Property(e => e.Year).IsRequired();
			modelBuilder.Entity<Song>().Property(e => e.TrackNumber).IsRequired();
			modelBuilder.Entity<Song>().Property(e => e.DiscNumber).IsRequired();
			modelBuilder.Entity<Song>().Property(e => e.PlayCount).IsRequired();
			modelBuilder.Entity<Song>().Property(e => e.Duration).IsRequired();
			modelBuilder.Entity<Song>().Property(e => e.LastModified).IsRequired();
			modelBuilder.Entity<Album>().Property(e => e.Id).ValueGeneratedOnAdd();
			modelBuilder.Entity<Album>().Property(e => e.Year).IsRequired();
			modelBuilder.Entity<Album>().Property(e => e.Title).IsRequired();
			modelBuilder.Entity<Album>().Property(e => e.TotalTrackCount).IsRequired();
			modelBuilder.Entity<Album>().Property(e => e.TotalDiscCount).IsRequired();
			modelBuilder.Entity<Genre>().Property(e => e.Id).ValueGeneratedOnAdd();
			modelBuilder.Entity<Genre>().Property(e => e.Name).IsRequired();
			modelBuilder.Entity<Genre>().Ignore(e => e.Color);
			modelBuilder.Entity<Workout>().Property(e => e.Id).ValueGeneratedOnAdd();
			modelBuilder.Entity<Workout>().Property(e => e.Name).IsRequired();
			modelBuilder.Entity<Workout>().Property(e => e.WorkoutDateTimes).IsRequired();
			modelBuilder.Entity<UniFileFormat>().Property(e => e.Id).ValueGeneratedOnAdd();
			modelBuilder.Entity<UniFileFormat>().Property(e => e.Extension).IsRequired();
			modelBuilder.Entity<UniFileFormat>().Property(e => e.Description).IsRequired();
			modelBuilder.Entity<Directories>().Property(e => e.Id).ValueGeneratedOnAdd();
			modelBuilder.Entity<UrlReplacement>().Property(e => e.Id).ValueGeneratedOnAdd();
			modelBuilder.Entity<UrlReplacement>().Property(e => e.StringReplacement).IsRequired();
			modelBuilder.Entity<UrlReplacement>().Property(e => e.StringToReplace).IsRequired();
			modelBuilder.Entity<YearLyricsChangeDetailsException>().Property(e => e.Id).ValueGeneratedOnAdd();
			modelBuilder.Entity<YearLyricsChangeDetailsException>().Property(e => e.OriginalArtist).IsRequired();
			modelBuilder.Entity<YearLyricsChangeDetailsException>().Property(e => e.Type).IsRequired();
		}

		private static void RelationshipsConfiguration(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Album>().HasOne(e => e.Genre).WithMany().OnDelete(DeleteBehavior.Cascade);
			modelBuilder.Entity<Album>().HasMany(e => e.Songs).WithOne(e => e.Album).OnDelete(DeleteBehavior.NoAction);
			modelBuilder.Entity<Song>().HasOne(e => e.Genre).WithMany()
				.OnDelete(DeleteBehavior.Cascade);
		}

		private static void SeedData(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Workout>().HasData(new Workout
				{
					Id = 1, Name = "The Complete Crush",
					WorkoutDateTimes = new HashSet<DateTime>()
					{
						new(2020, 4, 23, 1, 04, 24), new(2020, 7, 1, 0, 59, 21),
						new(2020, 9, 12, 0, 54, 22),
						new(2020, 9, 29, 0, 54, 29),
						new(2020, 11, 13, 0, 52, 9),
						new(2020, 12, 20, 0, 49, 51),
						new(2021, 6, 10, 0, 46, 24), new(2021, 6, 24, 0, 47, 12)
					}
				},
				new Workout
				{
					Id = 2, Name = "Pace Breaker",
					WorkoutDateTimes = new HashSet<DateTime>()
					{
						new(2020, 3, 26, 0, 42, 29), new(2020, 7, 28, 0, 54, 37),
						new(2020, 8, 28, 0, 48, 59),
						new(2020, 10, 19, 0, 48, 34), new(2020, 12, 17, 0, 44, 41),
						new(2021, 1, 20, 0, 42, 19),
						new(2021, 2, 4, 0, 42, 35), new(2021, 3, 20, 0, 40, 4),
						new(2021, 6, 26, 0, 43, 16),
						new(2021, 7, 11, 0, 38, 4)
					}
				},
				new Workout
				{
					Id = 3, Name = "Lunge Capacity",
					WorkoutDateTimes = new HashSet<DateTime>()
					{
						new(2020, 4, 9, 0, 53, 03), new(2020, 7, 8, 0, 47, 52),
						new(2020, 7, 26, 0, 52, 10),
						new(2020, 8, 19, 0, 47, 41), new(2020, 11, 22, 0, 42, 20),
						new(2020, 12, 10, 0, 46, 01),
						new(2020, 12, 19, 0, 43, 38), new(2021, 2, 6, 0, 44, 38),
						new(2021, 3, 21, 0, 42, 9),
						new(2021, 5, 8, 0, 44, 45), new(2021, 5, 25, 0, 43, 7)
					}
				},
				new Workout
				{
					Id = 4, Name = "The Power Start",
					WorkoutDateTimes = new HashSet<DateTime>()
					{
						new(2020, 3, 31, 0, 46, 17), new(2020, 6, 17, 0, 51, 58),
						new(2020, 6, 28, 0, 52, 05),
						new(2020, 8, 5, 0, 48, 16), new(2021, 5, 21, 0, 44, 51)
					}
				},
				new Workout
				{
					Id = 5, Name = "The Descent",
					WorkoutDateTimes = new HashSet<DateTime>()
					{
						new(2020, 8, 14, 0, 50, 30), new(2020, 6, 21, 0, 47, 52),
						new(2020, 9, 17, 0, 45, 29),
						new(2020, 11, 30, 0, 43, 25), new(2021, 2, 28, 0, 43, 21),
						new(2021, 4, 11, 0, 43, 0)
					}
				},
				new Workout
				{
					Id = 6, Name = "Burpee Beach",
					WorkoutDateTimes = new HashSet<DateTime>()
					{
						new(2020, 3, 26, 0, 42, 29), new(2020, 6, 21, 0, 47, 52),
						new(2020, 11, 18, 0, 33, 41),
						new(2021, 2, 24, 0, 36, 11), new(2021, 4, 6, 0, 36, 56),
						new(2021, 5, 16, 0, 42, 31)
					}
				});
			modelBuilder.Entity<UniFileFormat>().HasData(
				new UniFileFormat {Id = 1, Extension = ".pdf", Description = "PDF Files"},
				new UniFileFormat {Id = 2, Extension = ".doc", Description = "Word Files"},
				new UniFileFormat {Id = 3, Extension = ".docx", Description = "Word Files"},
				new UniFileFormat {Id = 4, Extension = ".zip", Description = "Compressed Files"},
				new UniFileFormat {Id = 5, Extension = ".rar", Description = "Compressed Files"});
			modelBuilder.Entity<Directories>().HasData(new Directories
			{
				Id = 1,
				MusicFrom = Path.Combine("C:", "Users", "ruben", "Desktop"),
				MusicTo = Path.Combine("C:", "Users", "ruben", "Desktop", "Test"),
				UniFrom = Path.Combine("C:", "Users", "ruben", "Downloads"),
				UniToBaseDirectory = Path.Combine("C:", "Users", "ruben", "OneDrive - Universidade da Madeira", "Ano_3",
					"Semestre_2")
			});
			var id = 1;
			modelBuilder.Entity<UrlReplacement>().HasData(
				new UrlReplacement {Id = id++, StringToReplace = "pt.", StringReplacement = "pt "},
				new UrlReplacement {Id = id++, StringToReplace = "part.", StringReplacement = "part "},
				new UrlReplacement {Id = id++, StringToReplace = "pts.", StringReplacement = "pts "},
				new UrlReplacement {Id = id++, StringToReplace = "mr.", StringReplacement = "mr "},
				new UrlReplacement {Id = id++, StringToReplace = "vol.", StringReplacement = "vol "},
				new UrlReplacement {Id = id++, StringToReplace = "ꞌ.", StringReplacement = " "},
				new UrlReplacement {Id = id++, StringToReplace = "/", StringReplacement = " "},
				new UrlReplacement {Id = id++, StringToReplace = ">", StringReplacement = " "},
				new UrlReplacement {Id = id++, StringToReplace = "<", StringReplacement = " "},
				new UrlReplacement {Id = id++, StringToReplace = "'", StringReplacement = ""},
				new UrlReplacement {Id = id++, StringToReplace = "*", StringReplacement = " "},
				new UrlReplacement {Id = id++, StringToReplace = "“", StringReplacement = " "},
				new UrlReplacement {Id = id++, StringToReplace = "”", StringReplacement = " "},
				new UrlReplacement {Id = id++, StringToReplace = "’", StringReplacement = ""},
				new UrlReplacement {Id = id++, StringToReplace = "\"", StringReplacement = " "},
				new UrlReplacement {Id = id++, StringToReplace = "…", StringReplacement = " "},
				new UrlReplacement {Id = id++, StringToReplace = "&", StringReplacement = "And"},
				new UrlReplacement {Id = id++, StringToReplace = ",", StringReplacement = " "},
				new UrlReplacement {Id = id++, StringToReplace = "|", StringReplacement = " "},
				new UrlReplacement {Id = id++, StringToReplace = "_", StringReplacement = " "},
				new UrlReplacement {Id = id++, StringToReplace = "(", StringReplacement = " "},
				new UrlReplacement {Id = id++, StringToReplace = ")", StringReplacement = " "},
				new UrlReplacement {Id = id++, StringToReplace = "+", StringReplacement = ""},
				new UrlReplacement {Id = id++, StringToReplace = "=", StringReplacement = " "},
				new UrlReplacement {Id = id++, StringToReplace = "é", StringReplacement = "e"},
				new UrlReplacement {Id = id++, StringToReplace = "à", StringReplacement = "a"},
				new UrlReplacement {Id = id++, StringToReplace = "â", StringReplacement = "a"},
				new UrlReplacement {Id = id++, StringToReplace = "ñ", StringReplacement = "n"},
				new UrlReplacement {Id = id++, StringToReplace = "@", StringReplacement = "at"},
				new UrlReplacement {Id = id++, StringToReplace = "...", StringReplacement = " "},
				new UrlReplacement {Id = id++, StringToReplace = "!", StringReplacement = " "},
				new UrlReplacement {Id = id++, StringToReplace = "?", StringReplacement = " "},
				new UrlReplacement {Id = id++, StringToReplace = "#", StringReplacement = " "},
				new UrlReplacement {Id = id++, StringToReplace = "$", StringReplacement = " "},
				new UrlReplacement {Id = id++, StringToReplace = "–", StringReplacement = " "},
				new UrlReplacement {Id = id++, StringToReplace = ":", StringReplacement = " "},
				new UrlReplacement {Id = id++, StringToReplace = "ꞌ", StringReplacement = " "},
				new UrlReplacement {Id = id++, StringToReplace = ".", StringReplacement = ""},
				new UrlReplacement {Id = id++, StringToReplace = "%", StringReplacement = " "},
				new UrlReplacement {Id = id++, StringToReplace = "-", StringReplacement = " "},
				new UrlReplacement {Id = id++, StringToReplace = "ō", StringReplacement = "o"},
				new UrlReplacement {Id = id++, StringToReplace = "‘", StringReplacement = " "});
			id = 1;
			modelBuilder.Entity<GrimeArtist>().HasData(new GrimeArtist {Id = id++, ArtistName = "Frisco"},
				new GrimeArtist {Id = id++, ArtistName = "JME"},
				new GrimeArtist {Id = id++, ArtistName = "Skepta"},
				new GrimeArtist {Id = id++, ArtistName = "Wiley"},
				new GrimeArtist {Id = id++, ArtistName = "Dave"},
				new GrimeArtist {Id = id++, ArtistName = "Dizzee Rascal"},
				new GrimeArtist {Id = id++, ArtistName = "Chip"},
				new GrimeArtist {Id = id++, ArtistName = "Stormzy"},
				new GrimeArtist {Id = id++, ArtistName = "Kano"},
				new GrimeArtist {Id = id++, ArtistName = "AJ Tracey"},
				new GrimeArtist {Id = id++, ArtistName = "Giggs"},
				new GrimeArtist {Id = id++, ArtistName = "P Money"},
				new GrimeArtist {Id = id++, ArtistName = "Yizzy"});
		}

		private static void ConvertersConfiguration(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Song>()
				.Property(e => e.ContributingArtists)
				.HasConversion(
					v => string.Join(';', v),
					v => v.Split(';', StringSplitOptions.RemoveEmptyEntries));
			modelBuilder
				.Entity<Workout>()
				.Property(e => e.WorkoutDateTimes)
				.HasConversion(v => string.Join(';', v.Select(e => e.ToString()).ToHashSet()),
					v => v.Split(new[] {';'})
						.Select(DateTime.Parse)
						.ToHashSet());
		}

		public DbSet<Album> Albums { get; set; }
		public DbSet<Song> Songs { get; set; }
		public DbSet<Genre> Genres { get; set; }
		public DbSet<Workout> Workouts { get; set; }
		public DbSet<UniFileFormat> UniFileFormats { get; set; }
		public DbSet<Directories> Directories { get; set; }
		public DbSet<UrlReplacement> UrlReplacements { get; set; }
		public DbSet<YearLyricsChangeDetailsException> YearLyricsChangeDetailsExceptions { get; set; }
		public DbSet<GrimeArtist> GrimeArtists { get; set; }
	}
}