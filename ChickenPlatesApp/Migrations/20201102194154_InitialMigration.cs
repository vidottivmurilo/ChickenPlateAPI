using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChickenPlatesApp.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChickenParts",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PartName = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChickenParts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SideDishes",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DishName = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SideDishes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ChickenPlates",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    Sauce = table.Column<string>(maxLength: 250, nullable: false),
                    ChickenAmount = table.Column<decimal>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    PartId = table.Column<long>(nullable: false),
                    DishId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChickenPlates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChickenPlates_SideDishes_DishId",
                        column: x => x.DishId,
                        principalTable: "SideDishes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChickenPlates_ChickenParts_PartId",
                        column: x => x.PartId,
                        principalTable: "ChickenParts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DrinkName = table.Column<string>(maxLength: 250, nullable: false),
                    ChickenPlateId = table.Column<long>(nullable: true),
                    ChikenPlateId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.id);
                    table.ForeignKey(
                        name: "FK_Drinks_ChickenPlates_ChickenPlateId",
                        column: x => x.ChickenPlateId,
                        principalTable: "ChickenPlates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChickenPlates_DishId",
                table: "ChickenPlates",
                column: "DishId");

            migrationBuilder.CreateIndex(
                name: "IX_ChickenPlates_PartId",
                table: "ChickenPlates",
                column: "PartId");

            migrationBuilder.CreateIndex(
                name: "IX_Drinks_ChickenPlateId",
                table: "Drinks",
                column: "ChickenPlateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drinks");

            migrationBuilder.DropTable(
                name: "ChickenPlates");

            migrationBuilder.DropTable(
                name: "SideDishes");

            migrationBuilder.DropTable(
                name: "ChickenParts");
        }
    }
}
