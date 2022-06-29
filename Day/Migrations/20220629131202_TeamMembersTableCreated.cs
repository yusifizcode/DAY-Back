using Microsoft.EntityFrameworkCore.Migrations;

namespace Day.Migrations
{
    public partial class TeamMembersTableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TeamMembers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(maxLength: 50, nullable: false),
                    Profession = table.Column<string>(maxLength: 50, nullable: false),
                    Desc = table.Column<string>(maxLength: 250, nullable: false),
                    TwitterUrl = table.Column<string>(maxLength: 150, nullable: false),
                    FacebookUrl = table.Column<string>(maxLength: 150, nullable: false),
                    InstagramUrl = table.Column<string>(maxLength: 150, nullable: false),
                    LinkedinUrl = table.Column<string>(maxLength: 150, nullable: false),
                    Image = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMembers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeamMembers");
        }
    }
}
