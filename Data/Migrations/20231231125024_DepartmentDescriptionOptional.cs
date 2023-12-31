using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class DepartmentDescriptionOptional : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8e277801-3990-4be3-9202-e22ca709f3d9", "2bbf684b-1a8b-47ab-b774-851724c302ad" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f682b6ca-22e7-4a37-a3ca-30f091419c75", "d5bd65f9-0b0e-4c5c-a552-8e1d91ee45c4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e277801-3990-4be3-9202-e22ca709f3d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f682b6ca-22e7-4a37-a3ca-30f091419c75");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2bbf684b-1a8b-47ab-b774-851724c302ad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5bd65f9-0b0e-4c5c-a552-8e1d91ee45c4");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "departments",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "departments",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8e277801-3990-4be3-9202-e22ca709f3d9", "8e277801-3990-4be3-9202-e22ca709f3d9", "admin", "ADMIN" },
                    { "f682b6ca-22e7-4a37-a3ca-30f091419c75", "f682b6ca-22e7-4a37-a3ca-30f091419c75", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2bbf684b-1a8b-47ab-b774-851724c302ad", 0, "ebeb39cd-36b6-44f2-bce8-1424d6ddbd35", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU>PL", "ADAM", "AQAAAAEAACcQAAAAEPR2Zi1mkMKsL1eot7rjI7kLeivD+5eQNJMEgBgy4pNc4rJpZkzN57NC92I2OKI+bA==", null, false, "e215f094-7f54-4362-a8b7-35a0d7510db2", false, "adam" },
                    { "d5bd65f9-0b0e-4c5c-a552-8e1d91ee45c4", 0, "0f21c5e3-f015-4365-a0d2-8dc4b0fbed2c", "marcin@wsei.edu.pl", true, false, null, "MARCIN@WSEI.EDU>PL", "MARCIN", "AQAAAAEAACcQAAAAEBpKhnIfw2sbM2rg6af/ZAe75ZltwxBGi7zmSHCwlYpQTeB9a8206xxWj8vnDe/KMQ==", null, false, "d29e4fd1-2a05-46d2-a936-4c35280e582a", false, "marcin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8e277801-3990-4be3-9202-e22ca709f3d9", "2bbf684b-1a8b-47ab-b774-851724c302ad" },
                    { "f682b6ca-22e7-4a37-a3ca-30f091419c75", "d5bd65f9-0b0e-4c5c-a552-8e1d91ee45c4" }
                });
        }
    }
}
