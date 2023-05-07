using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelTripProje.Migrations
{
    public partial class yenisutun : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_yorumlars_Blogs_BlogID",
                table: "yorumlars");

            migrationBuilder.RenameColumn(
                name: "BlogID",
                table: "yorumlars",
                newName: "Blogid");

            migrationBuilder.RenameIndex(
                name: "IX_yorumlars_BlogID",
                table: "yorumlars",
                newName: "IX_yorumlars_Blogid");

            migrationBuilder.AlterColumn<int>(
                name: "Blogid",
                table: "yorumlars",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_yorumlars_Blogs_Blogid",
                table: "yorumlars",
                column: "Blogid",
                principalTable: "Blogs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_yorumlars_Blogs_Blogid",
                table: "yorumlars");

            migrationBuilder.RenameColumn(
                name: "Blogid",
                table: "yorumlars",
                newName: "BlogID");

            migrationBuilder.RenameIndex(
                name: "IX_yorumlars_Blogid",
                table: "yorumlars",
                newName: "IX_yorumlars_BlogID");

            migrationBuilder.AlterColumn<int>(
                name: "BlogID",
                table: "yorumlars",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_yorumlars_Blogs_BlogID",
                table: "yorumlars",
                column: "BlogID",
                principalTable: "Blogs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
