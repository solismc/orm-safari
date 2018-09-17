using Microsoft.EntityFrameworkCore.Migrations;

namespace orm_safari.Migrations
{
    public partial class ChangedSpecieType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Species",
                table: "SeenAnimalsTable",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Species",
                table: "SeenAnimalsTable",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
