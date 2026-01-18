using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InventoryDatabaseCore.Migrations
{
    /// <inheritdoc />
    public partial class Activity0902_Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryColor_Categories_Id",
                table: "CategoryColor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryColor",
                table: "CategoryColor");

            migrationBuilder.RenameTable(
                name: "CategoryColor",
                newName: "CategoryColors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryColors",
                table: "CategoryColors",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreatedByUserId", "CreatedDate", "IsActive", "IsDeleted", "LastModifiedDate", "LastModifiedUserId", "Name" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, null, null, "Fantasy" },
                    { 2, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, null, null, "Sci/Fi" },
                    { 3, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, null, null, "Horror" },
                    { 4, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, null, null, "Comedy" },
                    { 5, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, null, null, "Drama" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryColors_Categories_Id",
                table: "CategoryColors",
                column: "Id",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryColors_Categories_Id",
                table: "CategoryColors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryColors",
                table: "CategoryColors");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.RenameTable(
                name: "CategoryColors",
                newName: "CategoryColor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryColor",
                table: "CategoryColor",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryColor_Categories_Id",
                table: "CategoryColor",
                column: "Id",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
