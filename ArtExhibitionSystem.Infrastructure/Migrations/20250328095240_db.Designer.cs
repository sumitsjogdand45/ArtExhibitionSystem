﻿// <auto-generated />
using System;
using ArtExhibitionSystem.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ArtExhibitionSystem.Infrastructure.Migrations
{
    [DbContext(typeof(ArtDBContext))]
    [Migration("20250328095240_db")]
    partial class db
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ArtExhibitionSystem.Domain.Artists", b =>
                {
                    b.Property<int>("ArtistID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArtistID"));

                    b.Property<DateTime>("ArtistBirthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ArtistName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArtistPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArtistID");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            ArtistID = 1,
                            ArtistBirthdate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ArtistName = "Sumit",
                            ArtistPhone = ""
                        },
                        new
                        {
                            ArtistID = 2,
                            ArtistBirthdate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ArtistName = "Kapil",
                            ArtistPhone = ""
                        });
                });

            modelBuilder.Entity("ArtExhibitionSystem.Domain.ArtworkGallery", b =>
                {
                    b.Property<int>("ArtworkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArtworkId"));

                    b.Property<int>("ArtworksArtworkId")
                        .HasColumnType("int");

                    b.Property<int>("GalleriesGalleryId")
                        .HasColumnType("int");

                    b.Property<int>("GalleryId")
                        .HasColumnType("int");

                    b.HasKey("ArtworkId");

                    b.HasIndex("ArtworksArtworkId");

                    b.HasIndex("GalleriesGalleryId");

                    b.ToTable("ArtworkGallery");
                });

            modelBuilder.Entity("ArtExhibitionSystem.Domain.FavoriteArtWork", b =>
                {
                    b.Property<int>("FavouriteArtWorkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FavouriteArtWorkId"));

                    b.Property<int>("ArtworkId")
                        .HasColumnType("int");

                    b.Property<int>("ArtworksArtworkId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("FavouriteArtWorkId");

                    b.HasIndex("ArtworksArtworkId");

                    b.ToTable("FavoriteArtWork");
                });

            modelBuilder.Entity("ArtExhibitionSystem.domain.Artworks", b =>
                {
                    b.Property<int>("ArtworkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArtworkId"));

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int?>("ArtistsArtistID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArtworkId");

                    b.HasIndex("ArtistsArtistID");

                    b.ToTable("Artworks");

                    b.HasData(
                        new
                        {
                            ArtworkId = 1,
                            ArtistId = 1,
                            CreationDate = new DateTime(2025, 3, 28, 15, 22, 36, 903, DateTimeKind.Local).AddTicks(5757),
                            Description = "horse Painting",
                            ImageURL = "sdfqr",
                            Title = "Painting"
                        });
                });

            modelBuilder.Entity("ArtExhibitionSystem.domain.Galleries", b =>
                {
                    b.Property<int>("GalleryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GalleryId"));

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int>("ArtistsArtistID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GalleryId");

                    b.HasIndex("ArtistsArtistID");

                    b.ToTable("Galleries");
                });

            modelBuilder.Entity("ArtExhibitionSystem.Domain.ArtworkGallery", b =>
                {
                    b.HasOne("ArtExhibitionSystem.domain.Artworks", "Artworks")
                        .WithMany("ArtworkGallery")
                        .HasForeignKey("ArtworksArtworkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArtExhibitionSystem.domain.Galleries", "Galleries")
                        .WithMany("ArtworkGalleries")
                        .HasForeignKey("GalleriesGalleryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artworks");

                    b.Navigation("Galleries");
                });

            modelBuilder.Entity("ArtExhibitionSystem.Domain.FavoriteArtWork", b =>
                {
                    b.HasOne("ArtExhibitionSystem.domain.Artworks", "Artworks")
                        .WithMany("FavoriteArtWork")
                        .HasForeignKey("ArtworksArtworkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artworks");
                });

            modelBuilder.Entity("ArtExhibitionSystem.domain.Artworks", b =>
                {
                    b.HasOne("ArtExhibitionSystem.Domain.Artists", "Artists")
                        .WithMany("Artworks")
                        .HasForeignKey("ArtistsArtistID");

                    b.Navigation("Artists");
                });

            modelBuilder.Entity("ArtExhibitionSystem.domain.Galleries", b =>
                {
                    b.HasOne("ArtExhibitionSystem.Domain.Artists", "Artists")
                        .WithMany("Galleries")
                        .HasForeignKey("ArtistsArtistID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artists");
                });

            modelBuilder.Entity("ArtExhibitionSystem.Domain.Artists", b =>
                {
                    b.Navigation("Artworks");

                    b.Navigation("Galleries");
                });

            modelBuilder.Entity("ArtExhibitionSystem.domain.Artworks", b =>
                {
                    b.Navigation("ArtworkGallery");

                    b.Navigation("FavoriteArtWork");
                });

            modelBuilder.Entity("ArtExhibitionSystem.domain.Galleries", b =>
                {
                    b.Navigation("ArtworkGalleries");
                });
#pragma warning restore 612, 618
        }
    }
}
