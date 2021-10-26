using Microsoft.EntityFrameworkCore.Migrations;

namespace vega.Migrations
{
    public partial class Features : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_makes_MakeId",
                table: "Models");

            migrationBuilder.DropPrimaryKey(
                name: "PK_makes",
                table: "makes");

            migrationBuilder.RenameTable(
                name: "makes",
                newName: "Makes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Makes",
                table: "Makes",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Makes_MakeId",
                table: "Models",
                column: "MakeId",
                principalTable: "Makes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Makes_MakeId",
                table: "Models");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Makes",
                table: "Makes");

            migrationBuilder.RenameTable(
                name: "Makes",
                newName: "makes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_makes",
                table: "makes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Models_makes_MakeId",
                table: "Models",
                column: "MakeId",
                principalTable: "makes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
