using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_DartGame_Blank.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Playerss",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerMail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PlayerPassword = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PlayerGame1 = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    PlayerGame2 = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    PlayerGame3 = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    PlayerGame4 = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    PlayerGame5 = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playerss", x => x.PlayerId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Playerss");
        }
    }
}
