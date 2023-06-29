using Microsoft.EntityFrameworkCore.Migrations;

namespace project_final.Migrations
{
    public partial class add_quantity_column_to_bill_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "quantity",
                table: "Bill",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "quantity",
                table: "Bill");
        }
    }
}
