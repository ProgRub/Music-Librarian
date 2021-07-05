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

		private void PropertiesConfiguration(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Song>().ToTable("Song");
			modelBuilder.Entity<Album>().ToTable("Album");
			modelBuilder.Entity<Genre>().ToTable("Genre");
			modelBuilder.Entity<Workout>().ToTable("Workout");
			modelBuilder.Entity<WorkoutTime>().ToTable("WorkoutTime");
			modelBuilder.Entity<WorkoutHasTimes>().ToTable("WorkoutHasTimes");
			modelBuilder.Entity<Directories>().ToTable("Directories");
			modelBuilder.Entity<UniFileFormat>().ToTable("UniFileFormat");
			modelBuilder.Entity<UrlReplacement>().ToTable("UrlReplacement");
			modelBuilder.Entity<YearLyricsChangeDetailsException>().ToTable("YearLyricsChangeDetailsException");
			modelBuilder.Entity<GrimeArtist>().ToTable("GrimeArtist");
		}

		private void TablesConfiguration(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<GrimeArtist>().Property(e => e.Id).ValueGeneratedOnAdd();
			modelBuilder.Entity<GrimeArtist>().Property(e => e.ArtistName).IsRequired();
			modelBuilder.Entity<Song>().Property(e => e.Id).ValueGeneratedOnAdd();
			modelBuilder.Entity<Song>().Property(e => e.Filename).IsRequired();
			modelBuilder.Entity<Song>().Property(e => e.Title).IsRequired();
			modelBuilder.Entity<Song>().Property(e => e.Year).IsRequired();
			modelBuilder.Entity<Song>().Property(e => e.TrackNumber).IsRequired();
			modelBuilder.Entity<Song>().Property(e => e.DiscNumber).IsRequired();
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
			modelBuilder.Entity<UniFileFormat>().Property(e => e.Id).ValueGeneratedOnAdd();
			modelBuilder.Entity<UniFileFormat>().Property(e => e.Extension).IsRequired();
			modelBuilder.Entity<UniFileFormat>().Property(e => e.Description).IsRequired();
			modelBuilder.Entity<Directories>().Property(e => e.Id).ValueGeneratedOnAdd();
			modelBuilder.Entity<WorkoutHasTimes>().HasKey(e => new {e.WorkoutTimeId, e.WorkoutId});
			modelBuilder.Entity<UrlReplacement>().Property(e => e.Id).ValueGeneratedOnAdd();
			modelBuilder.Entity<UrlReplacement>().Property(e => e.StringReplacement).IsRequired();
			modelBuilder.Entity<UrlReplacement>().Property(e => e.StringToReplace).IsRequired();
			modelBuilder.Entity<YearLyricsChangeDetailsException>().Property(e => e.Id).ValueGeneratedOnAdd();
			modelBuilder.Entity<YearLyricsChangeDetailsException>().Property(e => e.OriginalArtist).IsRequired();
			modelBuilder.Entity<YearLyricsChangeDetailsException>().Property(e => e.Type).IsRequired();
		}

		private void RelationshipsConfiguration(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Album>().HasOne(e => e.Genre).WithMany().OnDelete(DeleteBehavior.Cascade);
			modelBuilder.Entity<Album>().HasMany(e => e.Songs).WithOne(e => e.Album).OnDelete(DeleteBehavior.NoAction);
			modelBuilder.Entity<Song>().HasOne(e => e.Genre).WithMany()
				.OnDelete(DeleteBehavior.Cascade);
			modelBuilder.Entity<WorkoutHasTimes>().HasOne(e => e.Workout)
				.WithMany(e => e.WorkoutHasTimesCollection).HasForeignKey(e => e.WorkoutId)
				.OnDelete(DeleteBehavior.NoAction);
			modelBuilder.Entity<WorkoutHasTimes>().HasOne(e => e.WorkoutTime)
				.WithMany(e => e.WorkoutHasTimesCollection).HasForeignKey(e => e.WorkoutTimeId)
				.OnDelete(DeleteBehavior.NoAction);
		}

		private void SeedData(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Workout>().HasData(new Workout
					{Id = 1, Name = "The Complete Crush"},
				new Workout {Id = 2, Name = "Pace Breaker"},
				new Workout {Id = 3, Name = "Lunge Capacity"},
				new Workout {Id = 4, Name = "The Power Start"},
				new Workout {Id = 6, Name = "Burpee Beach"});
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
				new UrlReplacement {Id = id++, StringToReplace = ".", StringReplacement = " "},
				new UrlReplacement {Id = id++, StringToReplace = "%", StringReplacement = " "},
				new UrlReplacement {Id = id++, StringToReplace = "-", StringReplacement = " "});
			id = 1;
			modelBuilder.Entity<GrimeArtist>().HasData(new GrimeArtist {Id = id++, ArtistName = "Frisco"},
				new GrimeArtist {Id = id++, ArtistName = "JME"},
				new GrimeArtist {Id = id++, ArtistName = "Skepta"},
				new GrimeArtist {Id = id++, ArtistName = "Wiley"},
				new GrimeArtist {Id = id++, ArtistName = "Dave"},
				new GrimeArtist {Id = id++, ArtistName = "slowthai"},
				new GrimeArtist {Id = id++, ArtistName = "Dizzee Rascal"},
				new GrimeArtist {Id = id++, ArtistName = "Chip"},
				new GrimeArtist {Id = id++, ArtistName = "Stormzy"},
				new GrimeArtist {Id = id++, ArtistName = "Kano"},
				new GrimeArtist {Id = id++, ArtistName = "AJ Tracey"},
				new GrimeArtist {Id = id++, ArtistName = "Giggs"},
				new GrimeArtist {Id = id++, ArtistName = "P Money"},
				new GrimeArtist {Id = id++, ArtistName = "Yizzy"});
		}

		private void ConvertersConfiguration(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Song>()
				.Property(e => e.ContributingArtists)
				.HasConversion(
					v => string.Join(';', v),
					v => v.Split(';', StringSplitOptions.RemoveEmptyEntries));
		}

		public DbSet<Album> Albums { get; set; }
		public DbSet<Song> Songs { get; set; }
		public DbSet<Genre> Genres { get; set; }
		public DbSet<Workout> Workouts { get; set; }
		public DbSet<WorkoutHasTimes> WorkoutHasTimesEnumerable { get; set; }
		public DbSet<WorkoutTime> WorkoutTimes { get; set; }
		public DbSet<UniFileFormat> UniFileFormats { get; set; }
		public DbSet<Directories> Directories { get; set; }
		public DbSet<UrlReplacement> UrlReplacements { get; set; }
		public DbSet<YearLyricsChangeDetailsException> YearLyricsChangeDetailsExceptions { get; set; }
		public DbSet<GrimeArtist> GrimeArtists { get; set; }
	}
}