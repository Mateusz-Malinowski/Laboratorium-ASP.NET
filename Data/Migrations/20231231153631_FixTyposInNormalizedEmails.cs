using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class FixTyposInNormalizedEmails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "076a0c52-6d47-45d3-b8cc-0ed682ccceba", "1dcc9ee1-63af-4373-9f2c-d2601f0ce8b8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ff3f44e5-b89a-4270-a2c4-e73f3cbf9d2f", "f14ea41c-84e6-4ac0-ac8d-7f8a4a7777f8" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "076a0c52-6d47-45d3-b8cc-0ed682ccceba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff3f44e5-b89a-4270-a2c4-e73f3cbf9d2f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1dcc9ee1-63af-4373-9f2c-d2601f0ce8b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f14ea41c-84e6-4ac0-ac8d-7f8a4a7777f8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8011361e-d4a3-4337-9eb8-7d5049ef02f5", "8011361e-d4a3-4337-9eb8-7d5049ef02f5", "admin", "ADMIN" },
                    { "84bbe3d0-c4b9-43f7-8f0f-22b9a1fa85cb", "84bbe3d0-c4b9-43f7-8f0f-22b9a1fa85cb", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "16969cfe-6df9-4909-bce0-6dbbddc44736", 0, "6fa15173-dd96-402b-b5b7-f0089a1fadc7", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADAM", "AQAAAAEAACcQAAAAEFXh3L7fWXXuENWOVplCw0Aa74kv7gOaZaDD4mRkEAYWLHhogy7DDvgW8nJlZCBeYw==", null, false, "bae22b93-07c6-441e-9367-14201f55682e", false, "adam" },
                    { "479ba97b-0e16-4a39-8490-7c25e527ec97", 0, "c7d3756a-be66-41f4-8d00-4ce4422d8211", "marcin@wsei.edu.pl", true, false, null, "MARCIN@WSEI.EDU.PL", "MARCIN", "AQAAAAEAACcQAAAAEEqhZtr35mlhWIoKG46r9ZLX7BgkcfMglACls5HVk6reGt9oKah8esqwImqhmykN/A==", null, false, "6df4eb27-065c-4c3a-87d5-ec75f49eafc3", false, "marcin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8011361e-d4a3-4337-9eb8-7d5049ef02f5", "16969cfe-6df9-4909-bce0-6dbbddc44736" },
                    { "84bbe3d0-c4b9-43f7-8f0f-22b9a1fa85cb", "479ba97b-0e16-4a39-8490-7c25e527ec97" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8011361e-d4a3-4337-9eb8-7d5049ef02f5", "16969cfe-6df9-4909-bce0-6dbbddc44736" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "84bbe3d0-c4b9-43f7-8f0f-22b9a1fa85cb", "479ba97b-0e16-4a39-8490-7c25e527ec97" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8011361e-d4a3-4337-9eb8-7d5049ef02f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84bbe3d0-c4b9-43f7-8f0f-22b9a1fa85cb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16969cfe-6df9-4909-bce0-6dbbddc44736");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "479ba97b-0e16-4a39-8490-7c25e527ec97");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "076a0c52-6d47-45d3-b8cc-0ed682ccceba", "076a0c52-6d47-45d3-b8cc-0ed682ccceba", "admin", "ADMIN" },
                    { "ff3f44e5-b89a-4270-a2c4-e73f3cbf9d2f", "ff3f44e5-b89a-4270-a2c4-e73f3cbf9d2f", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1dcc9ee1-63af-4373-9f2c-d2601f0ce8b8", 0, "0c940117-9643-4334-9b7d-100ccbd2e74c", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU>PL", "ADAM", "AQAAAAEAACcQAAAAEN1bj+WRuB1QcfLLo6WE+kJbgQL++BNjLy1F8PwW9a9LvdmgL7jhrRU/DmtWxutj4Q==", null, false, "760c2b6b-3629-417c-823f-1a4a95d04ad1", false, "adam" },
                    { "f14ea41c-84e6-4ac0-ac8d-7f8a4a7777f8", 0, "4b682669-0b6b-4ce5-bac6-f93344e8e303", "marcin@wsei.edu.pl", true, false, null, "MARCIN@WSEI.EDU>PL", "MARCIN", "AQAAAAEAACcQAAAAEDY4Flb+xiNaB3j/PfkM5QZsU5SUpOoQOKID6nGS9PfBS1/d+Jhk5e7aXTA2Dt5MfQ==", null, false, "d29c5d0d-3766-49ef-831e-88215a24d086", false, "marcin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "076a0c52-6d47-45d3-b8cc-0ed682ccceba", "1dcc9ee1-63af-4373-9f2c-d2601f0ce8b8" },
                    { "ff3f44e5-b89a-4270-a2c4-e73f3cbf9d2f", "f14ea41c-84e6-4ac0-ac8d-7f8a4a7777f8" }
                });
        }
    }
}
