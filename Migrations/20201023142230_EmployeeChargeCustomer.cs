using Microsoft.EntityFrameworkCore.Migrations;

namespace Identity_Practice.Migrations
{
    public partial class EmployeeChargeCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "273abcc7-c188-4537-8167-4e0ff45679ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59b3cdb0-62d5-40b2-8858-b7ebb95e798d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eedb14d3-2ff0-4e62-b40d-b6aceb70faf8");

            migrationBuilder.DropColumn(
                name: "PickUpComplete",
                table: "Employees");

            migrationBuilder.AddColumn<bool>(
                name: "ConfirmPickUp",
                table: "Employees",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a5146040-fb88-48dd-9fa4-62ef0f6a6dae", "7dcd5575-1c29-40be-88d7-eda2fe0f530b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cbe6b0db-04b6-4cce-8398-afc2eb5a4d2f", "21524677-80e9-4f17-8930-4267db34a7a4", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0af37e61-5945-4e9b-9c1f-d80511ddfdfc", "0b5aeaec-f0c7-463d-bef0-025f909eda11", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0af37e61-5945-4e9b-9c1f-d80511ddfdfc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5146040-fb88-48dd-9fa4-62ef0f6a6dae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbe6b0db-04b6-4cce-8398-afc2eb5a4d2f");

            migrationBuilder.DropColumn(
                name: "ConfirmPickUp",
                table: "Employees");

            migrationBuilder.AddColumn<bool>(
                name: "PickUpComplete",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eedb14d3-2ff0-4e62-b40d-b6aceb70faf8", "69874f07-c7b7-4e5e-ae97-def3c4bdf4ff", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "273abcc7-c188-4537-8167-4e0ff45679ba", "6d66aac9-00a7-4f6d-bd42-f9b0e025626a", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "59b3cdb0-62d5-40b2-8858-b7ebb95e798d", "5e73a0a2-8ff6-4095-93b6-466007985e75", "Employee", "EMPLOYEE" });
        }
    }
}
