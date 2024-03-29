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
    [Migration("20210712101112_Initial")]
    partial class Initial
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
