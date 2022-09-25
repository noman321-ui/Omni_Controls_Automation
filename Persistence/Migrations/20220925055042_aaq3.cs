using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class aaq3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyAdmin_Users_UserId",
                table: "CompanyAdmin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyAdmin",
                table: "CompanyAdmin");

            migrationBuilder.RenameTable(
                name: "CompanyAdmin",
                newName: "CompanyAdmins");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyAdmin_UserId",
                table: "CompanyAdmins",
                newName: "IX_CompanyAdmins_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyAdmins",
                table: "CompanyAdmins",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyAdmins_Users_UserId",
                table: "CompanyAdmins",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyAdmins_Users_UserId",
                table: "CompanyAdmins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyAdmins",
                table: "CompanyAdmins");

            migrationBuilder.RenameTable(
                name: "CompanyAdmins",
                newName: "CompanyAdmin");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyAdmins_UserId",
                table: "CompanyAdmin",
                newName: "IX_CompanyAdmin_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyAdmin",
                table: "CompanyAdmin",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyAdmin_Users_UserId",
                table: "CompanyAdmin",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
