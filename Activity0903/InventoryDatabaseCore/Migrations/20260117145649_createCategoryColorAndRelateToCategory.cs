using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryDatabaseCore.Migrations
{
    /// <inheritdoc />
    public partial class createCategoryColorAndRelateToCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryColorId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CategoryColor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    ColorValue = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryColor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryColor_Categories_Id",
                        column: x => x.Id,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryColor");

            migrationBuilder.DropColumn(
                name: "CategoryColorId",
                table: "Categories");
        }
    }
}
