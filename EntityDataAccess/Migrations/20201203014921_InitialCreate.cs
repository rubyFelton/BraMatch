using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityDataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BraSizes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Region = table.Column<string>(nullable: true),
                    MesureSystem = table.Column<string>(nullable: true),
                    CupSize = table.Column<string>(nullable: true),
                    BandSize = table.Column<string>(nullable: true),
                    OtherSize = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BraSizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BraTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cup = table.Column<string>(nullable: true),
                    Strap = table.Column<string>(nullable: true),
                    Convertable = table.Column<bool>(nullable: false),
                    Wire = table.Column<bool>(nullable: false),
                    Style = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BraTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DisplayName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    MeasureSystem = table.Column<string>(nullable: true),
                    BandMeasure = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    WidestMeasure = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    PointMeasure = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Implants = table.Column<bool>(nullable: false),
                    Reduction = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bras",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SizeId = table.Column<int>(nullable: true),
                    TypeId = table.Column<int>(nullable: true),
                    Maker = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bras_BraSizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "BraSizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bras_BraTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "BraTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bras_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bras_SizeId",
                table: "Bras",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Bras_TypeId",
                table: "Bras",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Bras_UserId",
                table: "Bras",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bras");

            migrationBuilder.DropTable(
                name: "BraSizes");

            migrationBuilder.DropTable(
                name: "BraTypes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
