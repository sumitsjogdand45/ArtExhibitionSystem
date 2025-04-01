using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArtExhibitionSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class config : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteArtWork_Artworks_ArtworksArtworkId",
                table: "FavoriteArtWork");

            migrationBuilder.DropForeignKey(
                name: "FK_Galleries_Artists_ArtistsArtistID",
                table: "Galleries");

            migrationBuilder.AlterColumn<int>(
                name: "ArtistsArtistID",
                table: "Galleries",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ArtworksArtworkId",
                table: "FavoriteArtWork",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistID",
                keyValue: 1,
                columns: new[] { "ArtistBirthdate", "ArtistPhone" },
                values: new object[] { new DateTime(2000, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "100" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistID",
                keyValue: 2,
                columns: new[] { "ArtistBirthdate", "ArtistPhone" },
                values: new object[] { new DateTime(2001, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "95456188188" });

            migrationBuilder.UpdateData(
                table: "Artworks",
                keyColumn: "ArtworkId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2025, 3, 30, 21, 49, 48, 346, DateTimeKind.Local).AddTicks(716));

            migrationBuilder.InsertData(
                table: "Galleries",
                columns: new[] { "GalleryId", "ArtistId", "ArtistsArtistID", "Description", "Location", "Name" },
                values: new object[] { 1, 1, null, "A collection of modern artworks", "New York", "Modern Art Gallery" });

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteArtWork_Artworks_ArtworksArtworkId",
                table: "FavoriteArtWork",
                column: "ArtworksArtworkId",
                principalTable: "Artworks",
                principalColumn: "ArtworkId");

            migrationBuilder.AddForeignKey(
                name: "FK_Galleries_Artists_ArtistsArtistID",
                table: "Galleries",
                column: "ArtistsArtistID",
                principalTable: "Artists",
                principalColumn: "ArtistID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteArtWork_Artworks_ArtworksArtworkId",
                table: "FavoriteArtWork");

            migrationBuilder.DropForeignKey(
                name: "FK_Galleries_Artists_ArtistsArtistID",
                table: "Galleries");

            migrationBuilder.DeleteData(
                table: "Galleries",
                keyColumn: "GalleryId",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "ArtistsArtistID",
                table: "Galleries",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ArtworksArtworkId",
                table: "FavoriteArtWork",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistID",
                keyValue: 1,
                columns: new[] { "ArtistBirthdate", "ArtistPhone" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistID",
                keyValue: 2,
                columns: new[] { "ArtistBirthdate", "ArtistPhone" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "" });

            migrationBuilder.UpdateData(
                table: "Artworks",
                keyColumn: "ArtworkId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2025, 3, 28, 15, 22, 36, 903, DateTimeKind.Local).AddTicks(5757));

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteArtWork_Artworks_ArtworksArtworkId",
                table: "FavoriteArtWork",
                column: "ArtworksArtworkId",
                principalTable: "Artworks",
                principalColumn: "ArtworkId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Galleries_Artists_ArtistsArtistID",
                table: "Galleries",
                column: "ArtistsArtistID",
                principalTable: "Artists",
                principalColumn: "ArtistID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
