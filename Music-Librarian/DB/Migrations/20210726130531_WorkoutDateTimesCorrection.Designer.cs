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
    [Migration("20210726130531_WorkoutDateTimesCorrection")]
    partial class WorkoutDateTimesCorrection
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

                    b.Property<string>("Artist")
                        .HasColumnType("nvarchar(max)");

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

                    b.HasIndex("GenreId");

                    b.ToTable("Album");
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

            modelBuilder.Entity("DB.Entities.GrimeArtist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArtistName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GrimeArtist");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArtistName = "Frisco"
                        },
                        new
                        {
                            Id = 2,
                            ArtistName = "JME"
                        },
                        new
                        {
                            Id = 3,
                            ArtistName = "Skepta"
                        },
                        new
                        {
                            Id = 4,
                            ArtistName = "Wiley"
                        },
                        new
                        {
                            Id = 5,
                            ArtistName = "Dave"
                        },
                        new
                        {
                            Id = 6,
                            ArtistName = "Dizzee Rascal"
                        },
                        new
                        {
                            Id = 7,
                            ArtistName = "Chip"
                        },
                        new
                        {
                            Id = 8,
                            ArtistName = "Stormzy"
                        },
                        new
                        {
                            Id = 9,
                            ArtistName = "Kano"
                        },
                        new
                        {
                            Id = 10,
                            ArtistName = "AJ Tracey"
                        },
                        new
                        {
                            Id = 11,
                            ArtistName = "Giggs"
                        },
                        new
                        {
                            Id = 12,
                            ArtistName = "P Money"
                        },
                        new
                        {
                            Id = 13,
                            ArtistName = "Yizzy"
                        });
                });

            modelBuilder.Entity("DB.Entities.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlbumArtist")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<string>("ContributingArtists")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DiscNumber")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<string>("Filename")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Lyrics")
                        .HasColumnType("nvarchar(max)");

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

                    b.HasIndex("AlbumId");

                    b.HasIndex("GenreId");

                    b.ToTable("Song");
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
                            StringReplacement = "",
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
                        },
                        new
                        {
                            Id = 41,
                            StringReplacement = "o",
                            StringToReplace = "ō"
                        },
                        new
                        {
                            Id = 42,
                            StringReplacement = " ",
                            StringToReplace = "‘"
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

                    b.Property<string>("WorkoutDateTimes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Workout");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "The Complete Crush",
                            WorkoutDateTimes = "23/04/2020 01:04:24;01/07/2020 00:59:21;12/09/2020 00:54:22;29/09/2020 00:54:29;13/11/2020 00:52:09;20/12/2020 00:49:51;10/06/2021 00:46:24;24/06/2021 00:47:12"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Pace Breaker",
                            WorkoutDateTimes = "26/03/2020 00:42:29;28/07/2020 00:54:37;28/08/2020 00:48:59;19/10/2020 00:48:34;17/12/2020 00:44:41;20/01/2021 00:42:19;04/02/2021 00:42:35;20/03/2021 00:40:04;26/06/2021 00:43:16;11/07/2021 00:38:04"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Lunge Capacity",
                            WorkoutDateTimes = "09/04/2020 00:53:03;08/07/2020 00:47:52;26/07/2020 00:52:10;19/08/2020 00:47:41;22/11/2020 00:42:20;10/12/2020 00:46:01;19/12/2020 00:43:38;06/02/2021 00:44:38;21/03/2021 00:42:09;08/05/2021 00:44:45;25/05/2021 00:43:07"
                        },
                        new
                        {
                            Id = 4,
                            Name = "The Power Start",
                            WorkoutDateTimes = "31/03/2020 00:46:17;17/06/2020 00:51:58;28/06/2020 00:52:05;05/08/2020 00:48:16;21/05/2021 00:44:51"
                        },
                        new
                        {
                            Id = 5,
                            Name = "The Descent",
                            WorkoutDateTimes = "14/08/2020 00:50:30;21/06/2020 00:47:52;17/09/2020 00:45:29;30/11/2020 00:43:25;28/02/2021 00:43:21;11/04/2021 00:43:00"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Burpee Beach",
                            WorkoutDateTimes = "26/03/2020 00:42:29;21/06/2020 00:47:52;18/11/2020 00:33:41;24/02/2021 00:36:11;06/04/2021 00:36:56;16/05/2021 00:42:31"
                        });
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OriginalArtist")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OriginalTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("YearLyricsChangeDetailsException");
                });

            modelBuilder.Entity("DB.Entities.Album", b =>
                {
                    b.HasOne("DB.Entities.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("DB.Entities.Song", b =>
                {
                    b.HasOne("DB.Entities.Album", "Album")
                        .WithMany("Songs")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DB.Entities.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("DB.Entities.Album", b =>
                {
                    b.Navigation("Songs");
                });
#pragma warning restore 612, 618
        }
    }
}
