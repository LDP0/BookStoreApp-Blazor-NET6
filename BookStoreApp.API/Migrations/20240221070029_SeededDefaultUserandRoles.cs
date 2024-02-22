using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp.API.Migrations
{
    public partial class SeededDefaultUserandRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "09e265a9-7145-4002-b552-1564544b74bd", "25f7e14f-9ea2-43f8-ace0-ee661f525023", "User", "USER" },
                    { "348817e7-fb96-418b-a140-b7cfa9a1b493", "f355a1ee-2eb3-48b5-abde-f9e34624b9f6", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0b1867e0-69ac-4184-8271-6238f45d0447", 0, "60a6fedb-f220-4817-a9d8-c77d65ee9a81", "user@bookstore.com", false, "System", "User", false, null, "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "AQAAAAEAACcQAAAAEE4gjj75xtMIE7KuJ0CIVTzrra34GE9a/U2dlyY0TMSFHLY2kEvaigUpOWfTK2KBwQ==", null, false, "22f01ba0-d87c-481c-844a-423a66a94d1f", false, "user@bookstore.com" },
                    { "3a380ccb-50f7-42fc-82b2-85b36a9ca73d", 0, "1caa049e-3f61-4c15-a487-db55b1862de4", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "AQAAAAEAACcQAAAAEBQWrTGJejgFwWaCHYsUAShzJPQiEK3/cOUoXDxe43ZPS0DauJ1RxiAd7ytl3kBaxw==", null, false, "27c73ec6-ac1c-42e1-b8b2-1757572b230b", false, "admin@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "09e265a9-7145-4002-b552-1564544b74bd", "0b1867e0-69ac-4184-8271-6238f45d0447" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "348817e7-fb96-418b-a140-b7cfa9a1b493", "3a380ccb-50f7-42fc-82b2-85b36a9ca73d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "09e265a9-7145-4002-b552-1564544b74bd", "0b1867e0-69ac-4184-8271-6238f45d0447" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "348817e7-fb96-418b-a140-b7cfa9a1b493", "3a380ccb-50f7-42fc-82b2-85b36a9ca73d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09e265a9-7145-4002-b552-1564544b74bd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "348817e7-fb96-418b-a140-b7cfa9a1b493");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b1867e0-69ac-4184-8271-6238f45d0447");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a380ccb-50f7-42fc-82b2-85b36a9ca73d");
        }
    }
}
