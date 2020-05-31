using Microsoft.EntityFrameworkCore.Migrations;

namespace KLADobj.WebService.Migrations
{
    public partial class Intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KLADobjs",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    ChillType = table.Column<string>(nullable: true),
                    Free = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KLADobjs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 1L, "Московская область, г. Домодедово, вблизи д. Истомиха, территория Домодедовское кладбище", "урной в землю, гробом в землю", "закрытое", "Домодедовское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 2L, "деревня Жохово", "гробом в землю", "закрытое", "Жохово кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 3L, "улица Николая Сироткина", "урной в землю,гробом в землю", "открытое", "Захарьинское кладбище" });

            migrationBuilder.InsertData(
                table: "KLADobjs",
                columns: new[] { "Id", "Address", "ChillType", "Free", "Name" },
                values: new object[] { 4L, "Зеленоград, Проезд N 710, дом 19 стр. 1, 3, 4", "урной в открытый колумбарий, урной в землю, гробом в землю", "закрытое", "Зеленоградское (Северное) кладбище" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KLADobjs");
        }
    }
}
