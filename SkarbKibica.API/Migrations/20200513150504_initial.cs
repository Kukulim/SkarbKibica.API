using Microsoft.EntityFrameworkCore.Migrations;

namespace SkarbKibica.API.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Created = table.Column<int>(nullable: false),
                    ClubColors = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stadiums",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Adress = table.Column<string>(maxLength: 100, nullable: false),
                    Seats = table.Column<int>(maxLength: 100, nullable: false),
                    TeamId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stadiums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stadiums_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "ClubColors", "Created", "Name" },
                values: new object[] { 1, "Czerwono-niebieskie", 1921, "Raków Częstochowa" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "ClubColors", "Created", "Name" },
                values: new object[] { 2, "Biało-bordowe", 1934, "Klub Sportowy Częstochowa" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "ClubColors", "Created", "Name" },
                values: new object[] { 3, "Czerwono-biało-niebieskie", 1995, "TS Podbeskidzie Spółka Akcyjna" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "Id", "Adress", "Name", "Seats", "TeamId" },
                values: new object[] { 1, "Czerwono-niebieskie", "Miejski Stadion Piłkarski", 4200, 1 });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "Id", "Adress", "Name", "Seats", "TeamId" },
                values: new object[] { 2, "Sabinowska 11/23", "Stadion Piłkarski", 960, 2 });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "Id", "Adress", "Name", "Seats", "TeamId" },
                values: new object[] { 3, "Rychlińskiego 21", "Stadion Miejski", 15316, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Stadiums_TeamId",
                table: "Stadiums",
                column: "TeamId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stadiums");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
