using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_NET_CORE_ONE_TO_MANY_CRUD.Migrations
{
    public partial class DatabaseAddDepchairman : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DepChairman",
                table: "tbl_Department",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepChairman",
                table: "tbl_Department");
        }
    }
}
