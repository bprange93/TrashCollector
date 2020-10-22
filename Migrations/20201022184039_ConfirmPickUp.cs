using Microsoft.EntityFrameworkCore.Migrations;

namespace Identity_Practice.Migrations
{
    public partial class ConfirmPickUp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b64a998-0d3f-4961-b79b-b4976e2dddaa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a8feeb3-6787-4e6f-b305-2fa142a2086a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2883c4aa-bb62-40f8-9f0f-c0418bc87f7f");

            migrationBuilder.DropColumn(
                name: "ConfirmPickUp",
                table: "Employees");

            migrationBuilder.AddColumn<bool>(
                name: "ConfirmPickUp",
                table: "Customers",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ConfirmPickUp",
                table: "Customers");

            migrationBuilder.AddColumn<bool>(
                name: "ConfirmPickUp",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0b64a998-0d3f-4961-b79b-b4976e2dddaa", "0d655889-ff40-41c3-9022-50472a658bfc", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2883c4aa-bb62-40f8-9f0f-c0418bc87f7f", "635c76d8-7233-4324-825e-fae0a6890193", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1a8feeb3-6787-4e6f-b305-2fa142a2086a", "d71cae78-6548-487f-abb3-b0607ec58a58", "Employee", "EMPLOYEE" });
        }
    }
}
