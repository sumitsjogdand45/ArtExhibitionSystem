using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArtExhibitionSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class intial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artworks",
                keyColumn: "ArtworkId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2025, 4, 1, 12, 57, 6, 782, DateTimeKind.Local).AddTicks(6464));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artworks",
                keyColumn: "ArtworkId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2025, 3, 30, 21, 49, 48, 346, DateTimeKind.Local).AddTicks(716));
        }
    }
}
