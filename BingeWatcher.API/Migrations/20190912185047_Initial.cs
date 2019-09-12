using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BingeWatcher.API.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Title = table.Column<string>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Writer = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Genre = table.Column<int>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    Provider = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Source = table.Column<string>(nullable: true),
                    PosterSource = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "AddedDate", "Director", "Genre", "IsActive", "PosterSource", "Provider", "ReleaseDate", "Source", "Title", "Writer" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 9, 12, 20, 50, 47, 273, DateTimeKind.Local), "Reżyser kina akcji", 0, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film akcji nr 1", null },
                    { 27, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina politycznego", 8, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film polityczny nr 3", null },
                    { 28, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina romantycznego", 9, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film romantyczny nr 1", null },
                    { 29, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina romantycznego", 9, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film romantyczny nr 2", null },
                    { 30, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina romantycznego", 9, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film romantyczny nr 3", null },
                    { 31, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina science fiction", 10, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film science fiction nr 1", null },
                    { 32, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina science fiction", 10, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film science fiction nr 2", null },
                    { 33, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina science fiction", 10, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film science fiction nr 3", null },
                    { 34, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina dreszczowców", 11, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film dreszczowiec nr 1", null },
                    { 35, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina dreszczowców", 11, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film dreszczowiec nr 2", null },
                    { 36, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina dreszczowców", 11, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film dreszczowiec nr 3", null },
                    { 37, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina western", 12, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film western nr 1", null },
                    { 38, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina western", 12, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film western nr 2", null },
                    { 39, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina western", 12, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film western nr 3", null },
                    { 40, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina musical", 13, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film musical nr 1", null },
                    { 41, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina musical", 13, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film musical nr 2", null },
                    { 42, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina musical", 13, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film musical nr 3", null },
                    { 43, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina anime", 14, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film anime nr 1", null },
                    { 44, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina anime", 14, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film anime nr 2", null },
                    { 45, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina anime", 14, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film anime nr 3", null },
                    { 26, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina politycznego", 8, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film polityczny nr 2", null },
                    { 25, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina politycznego", 8, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film polityczny nr 1", null },
                    { 24, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina horror", 7, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film horror nr 3", null },
                    { 12, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina kryminalnego", 3, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film kryminalny nr 3", null },
                    { 4, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina przygodowego", 1, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film przygodowy nr 1", null },
                    { 5, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina przygodowego", 1, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film przygodowy nr 2", null },
                    { 6, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina przygodowego", 1, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film przygodowy nr 3", null },
                    { 7, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina komediowego", 2, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film komediowy nr 1", null },
                    { 8, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina komediowego", 2, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film komediowy nr 2", null },
                    { 9, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina komediowego", 2, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film komediowy nr 3", null },
                    { 10, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina kryminalnego", 3, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film kryminalny nr 1", null },
                    { 11, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina kryminalnego", 3, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film kryminalny nr 2", null },
                    { 23, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina horror", 7, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film horror nr 2", null },
                    { 13, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina dramatycznego", 4, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film dramatyczny nr 1", null },
                    { 14, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina dramatycznego", 4, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film dramatyczny nr 2", null },
                    { 15, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina dramatycznego", 4, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film dramatyczny nr 3", null },
                    { 16, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina fantasy", 5, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film fantasy nr 1", null },
                    { 17, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina fantasy", 5, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film fantasy nr 2", null },
                    { 18, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina fantasy", 5, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film fantasy nr 3", null },
                    { 19, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina historycznego", 6, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film historyczny nr 1", null },
                    { 20, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina historycznego", 6, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film historyczny nr 2", null },
                    { 21, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina historycznego", 6, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film historyczny nr 3", null },
                    { 22, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina horror", 7, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film horror nr 1", null },
                    { 3, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina akcji", 0, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film akcji nr 3", null },
                    { 2, new DateTime(2019, 9, 12, 20, 50, 47, 280, DateTimeKind.Local), "Reżyser kina akcji", 0, true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film akcji nr 2", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[,]
                {
                    { 1, "Jan", "Kowalski", null, null, "jkowalski" },
                    { 2, "Janina", "Kowalska", null, null, "jkowalska" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
