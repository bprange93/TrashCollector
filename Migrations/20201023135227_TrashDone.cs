using Microsoft.EntityFrameworkCore.Migrations;

namespace Identity_Practice.Migrations
{
    public partial class TrashDone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05a776c2-1b84-4e42-9ed8-d469b1756958");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f297b72-950d-4c6b-9897-3a82d6c58eb5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f14e8315-fc87-41b1-91fe-a3fac9e0e392");

            migrationBuilder.AddColumn<bool>(
                name: "PickUpComplete",
                table: "Employees",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f14e8315-fc87-41b1-91fe-a3fac9e0e392", "1e2a5444-cb5d-41b2-b491-73802912bcfe", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0f297b72-950d-4c6b-9897-3a82d6c58eb5", "5e5923c5-9595-4cf1-9bbb-f593eaaae1ff", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "05a776c2-1b84-4e42-9ed8-d469b1756958", "1ea441d6-1b2f-410d-a500-16d6a3e6ab6d", "Employee", "EMPLOYEE" });
        }
    }
}
