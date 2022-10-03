using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessEf.Migrations
{
    public partial class InsertedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d9dca321-f39c-4d8b-bd39-2108409993fb", "3a2e9942-8c4e-4c08-ad20-7c0a631ed60a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0ef5cd45-c900-4157-bd21-437ac4b66bac", "2f23430b-fb60-44ac-8852-5212d1bd3016", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ef5cd45-c900-4157-bd21-437ac4b66bac");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9dca321-f39c-4d8b-bd39-2108409993fb");
        }
    }
}
