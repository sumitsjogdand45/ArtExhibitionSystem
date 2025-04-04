using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArtExhibitionSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class removedmultipleforeignkeyref : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArtworkGallery_Artworks_ArtworksArtworkId",
                table: "ArtworkGallery");

            migrationBuilder.DropForeignKey(
                name: "FK_ArtworkGallery_Galleries_GalleriesGalleryId",
                table: "ArtworkGallery");

            migrationBuilder.DropForeignKey(
                name: "FK_Artworks_Artists_ArtistsArtistID",
                table: "Artworks");

            migrationBuilder.DropIndex(
                name: "IX_Artworks_ArtistsArtistID",
                table: "Artworks");

            migrationBuilder.DropColumn(
                name: "ArtistsArtistID",
                table: "Artworks");

            migrationBuilder.AlterColumn<int>(
                name: "GalleriesGalleryId",
                table: "ArtworkGallery",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ArtworksArtworkId",
                table: "ArtworkGallery",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "ArtworkGallery",
                columns: new[] { "ArtworkId", "ArtworksArtworkId", "GalleriesGalleryId", "GalleryId" },
                values: new object[] { 1, null, null, 1 });

            migrationBuilder.UpdateData(
                table: "Artworks",
                keyColumn: "ArtworkId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2025, 4, 4, 14, 16, 5, 881, DateTimeKind.Local).AddTicks(8499));

            migrationBuilder.CreateIndex(
                name: "IX_Artworks_ArtistId",
                table: "Artworks",
                column: "ArtistId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArtworkGallery_Artworks_ArtworksArtworkId",
                table: "ArtworkGallery",
                column: "ArtworksArtworkId",
                principalTable: "Artworks",
                principalColumn: "ArtworkId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArtworkGallery_Galleries_GalleriesGalleryId",
                table: "ArtworkGallery",
                column: "GalleriesGalleryId",
                principalTable: "Galleries",
                principalColumn: "GalleryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Artworks_Artists_ArtistId",
                table: "Artworks",
                column: "ArtistId",
                principalTable: "Artists",
                principalColumn: "ArtistID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArtworkGallery_Artworks_ArtworksArtworkId",
                table: "ArtworkGallery");

            migrationBuilder.DropForeignKey(
                name: "FK_ArtworkGallery_Galleries_GalleriesGalleryId",
                table: "ArtworkGallery");

            migrationBuilder.DropForeignKey(
                name: "FK_Artworks_Artists_ArtistId",
                table: "Artworks");

            migrationBuilder.DropIndex(
                name: "IX_Artworks_ArtistId",
                table: "Artworks");

            migrationBuilder.DeleteData(
                table: "ArtworkGallery",
                keyColumn: "ArtworkId",
                keyValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "ArtistsArtistID",
                table: "Artworks",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GalleriesGalleryId",
                table: "ArtworkGallery",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ArtworksArtworkId",
                table: "ArtworkGallery",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Artworks",
                keyColumn: "ArtworkId",
                keyValue: 1,
                columns: new[] { "ArtistsArtistID", "CreationDate" },
                values: new object[] { null, new DateTime(2025, 4, 1, 12, 57, 6, 782, DateTimeKind.Local).AddTicks(6464) });

            migrationBuilder.CreateIndex(
                name: "IX_Artworks_ArtistsArtistID",
                table: "Artworks",
                column: "ArtistsArtistID");

            migrationBuilder.AddForeignKey(
                name: "FK_ArtworkGallery_Artworks_ArtworksArtworkId",
                table: "ArtworkGallery",
                column: "ArtworksArtworkId",
                principalTable: "Artworks",
                principalColumn: "ArtworkId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArtworkGallery_Galleries_GalleriesGalleryId",
                table: "ArtworkGallery",
                column: "GalleriesGalleryId",
                principalTable: "Galleries",
                principalColumn: "GalleryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Artworks_Artists_ArtistsArtistID",
                table: "Artworks",
                column: "ArtistsArtistID",
                principalTable: "Artists",
                principalColumn: "ArtistID");
        }
    }
}
