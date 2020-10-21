using Microsoft.EntityFrameworkCore.Migrations;

namespace Identity_Practice.Migrations
{
    public partial class Confirmtrashpickup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b289c19-0f60-4681-bf87-e3b77838acfd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2e9ea8-ec01-4990-8b90-19e8ad38640e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d142fcae-41c9-4488-b49d-2e9939e53e41");

            migrationBuilder.AddColumn<bool>(
                name: "ConfirmPickUp",
                table: "Employees",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8b289c19-0f60-4681-bf87-e3b77838acfd", "70a66653-2b76-466e-9405-8b79aa4e8aef", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ad2e9ea8-ec01-4990-8b90-19e8ad38640e", "5fad50c3-96cf-41c7-a842-0e7e7009c35b", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d142fcae-41c9-4488-b49d-2e9939e53e41", "622863b5-9533-4799-bd32-3501735c3192", "Employee", "EMPLOYEE" });
        }
    }
}
