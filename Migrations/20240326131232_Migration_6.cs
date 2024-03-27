using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Migrations
{
    /// <inheritdoc />
    public partial class Migration_6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryUsers",
                table: "CategoryUsers");

            migrationBuilder.DropIndex(
                name: "IX_CategoryUsers_UserId",
                table: "CategoryUsers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CategoryUsers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryUsers",
                table: "CategoryUsers",
                columns: new[] { "UserId", "CategoryId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryUsers",
                table: "CategoryUsers");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CategoryUsers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryUsers",
                table: "CategoryUsers",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryUsers_UserId",
                table: "CategoryUsers",
                column: "UserId");
        }
    }
}
