﻿// <auto-generated />
using System;
using DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DB.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210701112738_YearLyricsChangeDetailsException")]
    partial class YearLyricsChangeDetailsException
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DB.Entities.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalDiscCount")
                        .HasColumnType("int");

                    b.Property<int>("TotalTrackCount")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId")
                        .IsUnique();

                    b.HasIndex("GenreId")
                        .IsUnique();

                    b.ToTable("Album");
                });

            modelBuilder.Entity("DB.Entities.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Artist");
                });

            modelBuilder.Entity("DB.Entities.Directories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MusicFrom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MusicTo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UniFrom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UniToBaseDirectory")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Directories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MusicFrom = "C:\\Users\\ruben\\Desktop",
                            MusicTo = "C:\\Users\\ruben\\Desktop\\Test",
                            UniFrom = "C:\\Users\\ruben\\Downloads",
                            UniToBaseDirectory = "C:\\Users\\ruben\\OneDrive - Universidade da Madeira\\Ano_3\\Semestre_2"
                        });
                });

            modelBuilder.Entity("DB.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Argb")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("DB.Entities.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumArtistId")
                        .HasColumnType("int");

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<int>("DiscNumber")
                        .HasColumnType("int");

                    b.Property<string>("Filename")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<int>("PlayCount")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrackNumber")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AlbumArtistId")
                        .IsUnique();

                    b.HasIndex("AlbumId");

                    b.HasIndex("GenreId")
                        .IsUnique();

                    b.ToTable("Song");
                });

            modelBuilder.Entity("DB.Entities.SongHasContributingArtists", b =>
                {
                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int>("SongId")
                        .HasColumnType("int");

                    b.HasKey("ArtistId", "SongId");

                    b.HasIndex("SongId");

                    b.ToTable("SongHasContributingArtists");
                });

            modelBuilder.Entity("DB.Entities.UniFileFormat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Extension")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UniFileFormat");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "PDF Files",
                            Extension = ".pdf"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Word Files",
                            Extension = ".doc"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Word Files",
                            Extension = ".docx"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Compressed Files",
                            Extension = ".zip"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Compressed Files",
                            Extension = ".rar"
                        });
                });

            modelBuilder.Entity("DB.Entities.UrlReplacement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StringReplacement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StringToReplace")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UrlReplacement");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            StringReplacement = "pt ",
                            StringToReplace = "pt."
                        },
                        new
                        {
                            Id = 2,
                            StringReplacement = "part ",
                            StringToReplace = "part."
                        },
                        new
                        {
                            Id = 3,
                            StringReplacement = "pts ",
                            StringToReplace = "pts."
                        },
                        new
                        {
                            Id = 4,
                            StringReplacement = "mr ",
                            StringToReplace = "mr."
                        },
                        new
                        {
                            Id = 5,
                            StringReplacement = "vol ",
                            StringToReplace = "vol."
                        },
                        new
                        {
                            Id = 6,
                            StringReplacement = " ",
                            StringToReplace = "ꞌ."
                        },
                        new
                        {
                            Id = 7,
                            StringReplacement = " ",
                            StringToReplace = "/"
                        },
                        new
                        {
                            Id = 8,
                            StringReplacement = " ",
                            StringToReplace = ">"
                        },
                        new
                        {
                            Id = 9,
                            StringReplacement = " ",
                            StringToReplace = "<"
                        },
                        new
                        {
                            Id = 10,
                            StringReplacement = "",
                            StringToReplace = "'"
                        },
                        new
                        {
                            Id = 11,
                            StringReplacement = " ",
                            StringToReplace = "*"
                        },
                        new
                        {
                            Id = 12,
                            StringReplacement = " ",
                            StringToReplace = "“"
                        },
                        new
                        {
                            Id = 13,
                            StringReplacement = " ",
                            StringToReplace = "”"
                        },
                        new
                        {
                            Id = 14,
                            StringReplacement = "",
                            StringToReplace = "’"
                        },
                        new
                        {
                            Id = 15,
                            StringReplacement = " ",
                            StringToReplace = "\""
                        },
                        new
                        {
                            Id = 16,
                            StringReplacement = " ",
                            StringToReplace = "…"
                        },
                        new
                        {
                            Id = 17,
                            StringReplacement = "And",
                            StringToReplace = "&"
                        },
                        new
                        {
                            Id = 18,
                            StringReplacement = " ",
                            StringToReplace = ","
                        },
                        new
                        {
                            Id = 19,
                            StringReplacement = " ",
                            StringToReplace = "|"
                        },
                        new
                        {
                            Id = 20,
                            StringReplacement = " ",
                            StringToReplace = "_"
                        },
                        new
                        {
                            Id = 21,
                            StringReplacement = " ",
                            StringToReplace = "("
                        },
                        new
                        {
                            Id = 22,
                            StringReplacement = " ",
                            StringToReplace = ")"
                        },
                        new
                        {
                            Id = 23,
                            StringReplacement = "",
                            StringToReplace = "+"
                        },
                        new
                        {
                            Id = 24,
                            StringReplacement = " ",
                            StringToReplace = "="
                        },
                        new
                        {
                            Id = 25,
                            StringReplacement = "e",
                            StringToReplace = "é"
                        },
                        new
                        {
                            Id = 26,
                            StringReplacement = "a",
                            StringToReplace = "à"
                        },
                        new
                        {
                            Id = 27,
                            StringReplacement = "a",
                            StringToReplace = "â"
                        },
                        new
                        {
                            Id = 28,
                            StringReplacement = "n",
                            StringToReplace = "ñ"
                        },
                        new
                        {
                            Id = 29,
                            StringReplacement = "at",
                            StringToReplace = "@"
                        },
                        new
                        {
                            Id = 30,
                            StringReplacement = " ",
                            StringToReplace = "..."
                        },
                        new
                        {
                            Id = 31,
                            StringReplacement = " ",
                            StringToReplace = "!"
                        },
                        new
                        {
                            Id = 32,
                            StringReplacement = " ",
                            StringToReplace = "?"
                        },
                        new
                        {
                            Id = 33,
                            StringReplacement = " ",
                            StringToReplace = "#"
                        },
                        new
                        {
                            Id = 34,
                            StringReplacement = " ",
                            StringToReplace = "$"
                        },
                        new
                        {
                            Id = 35,
                            StringReplacement = " ",
                            StringToReplace = "–"
                        },
                        new
                        {
                            Id = 36,
                            StringReplacement = " ",
                            StringToReplace = ":"
                        },
                        new
                        {
                            Id = 37,
                            StringReplacement = " ",
                            StringToReplace = "ꞌ"
                        },
                        new
                        {
                            Id = 38,
                            StringReplacement = " ",
                            StringToReplace = "."
                        },
                        new
                        {
                            Id = 39,
                            StringReplacement = " ",
                            StringToReplace = "%"
                        },
                        new
                        {
                            Id = 40,
                            StringReplacement = " ",
                            StringToReplace = "-"
                        });
                });

            modelBuilder.Entity("DB.Entities.Workout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Workout");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "The Complete Crush"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Pace Breaker"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Lunge Capacity"
                        },
                        new
                        {
                            Id = 4,
                            Name = "The Power Start"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Burpee Beach"
                        });
                });

            modelBuilder.Entity("DB.Entities.WorkoutHasTimes", b =>
                {
                    b.Property<int>("WorkoutTimeId")
                        .HasColumnType("int");

                    b.Property<int>("WorkoutId")
                        .HasColumnType("int");

                    b.HasKey("WorkoutTimeId", "WorkoutId");

                    b.HasIndex("WorkoutId");

                    b.ToTable("WorkoutHasTimes");
                });

            modelBuilder.Entity("DB.Entities.WorkoutTime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateAndDuration")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("WorkoutTimes");
                });

            modelBuilder.Entity("DB.Entities.YearLyricsChangeDetailsException", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NewAlbum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewArtist")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OriginalAlbum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OriginalArtist")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OriginalTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("YearLyricsChangeDetailsException");
                });

            modelBuilder.Entity("DB.Entities.Album", b =>
                {
                    b.HasOne("DB.Entities.Artist", "Artist")
                        .WithOne()
                        .HasForeignKey("DB.Entities.Album", "ArtistId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DB.Entities.Genre", "Genre")
                        .WithOne()
                        .HasForeignKey("DB.Entities.Album", "GenreId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("DB.Entities.Song", b =>
                {
                    b.HasOne("DB.Entities.Artist", "AlbumArtist")
                        .WithOne()
                        .HasForeignKey("DB.Entities.Song", "AlbumArtistId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DB.Entities.Album", "Album")
                        .WithMany("Songs")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DB.Entities.Genre", "Genre")
                        .WithOne()
                        .HasForeignKey("DB.Entities.Song", "GenreId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Album");

                    b.Navigation("AlbumArtist");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("DB.Entities.SongHasContributingArtists", b =>
                {
                    b.HasOne("DB.Entities.Artist", "Artist")
                        .WithMany("SongHasContributingArtistsCollection")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DB.Entities.Song", "Song")
                        .WithMany("SongHasContributingArtistsCollection")
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Song");
                });

            modelBuilder.Entity("DB.Entities.WorkoutHasTimes", b =>
                {
                    b.HasOne("DB.Entities.Workout", "Workout")
                        .WithMany("WorkoutHasTimesCollection")
                        .HasForeignKey("WorkoutId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DB.Entities.WorkoutTime", "WorkoutTime")
                        .WithMany("WorkoutHasTimesCollection")
                        .HasForeignKey("WorkoutTimeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Workout");

                    b.Navigation("WorkoutTime");
                });

            modelBuilder.Entity("DB.Entities.Album", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("DB.Entities.Artist", b =>
                {
                    b.Navigation("SongHasContributingArtistsCollection");
                });

            modelBuilder.Entity("DB.Entities.Song", b =>
                {
                    b.Navigation("SongHasContributingArtistsCollection");
                });

            modelBuilder.Entity("DB.Entities.Workout", b =>
                {
                    b.Navigation("WorkoutHasTimesCollection");
                });

            modelBuilder.Entity("DB.Entities.WorkoutTime", b =>
                {
                    b.Navigation("WorkoutHasTimesCollection");
                });
#pragma warning restore 612, 618
        }
    }
}
