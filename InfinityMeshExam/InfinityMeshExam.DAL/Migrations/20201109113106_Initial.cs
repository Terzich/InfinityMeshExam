using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InfinityMeshExam.DAL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Age = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    NumberOfBlogs = table.Column<int>(nullable: false),
                    ViewProfile = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "blogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 64, nullable: false),
                    Summary = table.Column<string>(maxLength: 350, nullable: false),
                    Content = table.Column<string>(maxLength: 3500, nullable: false),
                    Published = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_blogs_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Age", "Email", "Name", "NumberOfBlogs", "ViewProfile" },
                values: new object[] { 1, new DateTime(1999, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "ahmedterzic@infinity.com", "Ahmed Terzic", 0, "www.infinitymesh.com/profile/ahmedterzic" });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Age", "Email", "Name", "NumberOfBlogs", "ViewProfile" },
                values: new object[] { 2, new DateTime(1998, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "ajdintabak@infinity.com", "Ajding Tabak", 0, "www.infinitymesh.com/profile/ajdintabak" });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Age", "Email", "Name", "NumberOfBlogs", "ViewProfile" },
                values: new object[] { 3, new DateTime(1999, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "huseinmuftic@infinity.com", "Husein Muftic", 0, "www.infinitymesh.com/profile/huseinmuftic" });

            migrationBuilder.InsertData(
                table: "blogs",
                columns: new[] { "Id", "Content", "Published", "Summary", "Title", "UserId" },
                values: new object[] { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTime(2020, 11, 9, 11, 31, 6, 102, DateTimeKind.Utc).AddTicks(912), "Lorem ipsum dolor sit amet", "Univerzalni tekst kojeg svi programeri koriste", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_blogs_UserId",
                table: "blogs",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "blogs");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
