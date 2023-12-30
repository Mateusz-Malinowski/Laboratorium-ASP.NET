using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "40358116-35e4-41f0-9e78-e31cf01c3f8e", "76ac3c01-4d87-4e27-90bd-95121a486672" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "54f2034f-b5e7-4550-9232-5797c26f640d", "8fedb26e-1551-41f7-8750-780f01bbf43e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40358116-35e4-41f0-9e78-e31cf01c3f8e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54f2034f-b5e7-4550-9232-5797c26f640d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76ac3c01-4d87-4e27-90bd-95121a486672");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8fedb26e-1551-41f7-8750-780f01bbf43e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "33232789-99ff-42a1-af61-df1f8474c253", "33232789-99ff-42a1-af61-df1f8474c253", "user", "USER" },
                    { "e6d0b075-7659-4da7-b123-a173198f044e", "e6d0b075-7659-4da7-b123-a173198f044e", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3e04dccf-fc6a-4ce8-9a3d-64bc8c56b514", 0, "8eccb950-0312-4cd4-94b6-9e33add24b18", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU>PL", "ADAM", "AQAAAAEAACcQAAAAEOoPZH2jfUL5hYKYT9wU/igDNHs3qy5gAyxR60zXyeGbrNZ9LBZhUyItsKW+9WGspQ==", null, false, "0895e504-b39e-4171-8ce8-54b9f28566fd", false, "adam" },
                    { "615ef445-80f5-4919-af5c-494977779681", 0, "ce663a27-797a-4c38-88d1-450c36e2e638", "marcin@wsei.edu.pl", true, false, null, "MARCIN@WSEI.EDU>PL", "MARCIN", "AQAAAAEAACcQAAAAEKFMa1id0C3pwOQhvLNPgr+LS4hCkmUTWQNuC8b7rVUCBAUd+SC4QHb1XpuppgXquw==", null, false, "89f2c75e-f94b-4cf8-8b4e-ddbce849153c", false, "marcin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "e6d0b075-7659-4da7-b123-a173198f044e", "3e04dccf-fc6a-4ce8-9a3d-64bc8c56b514" },
                    { "33232789-99ff-42a1-af61-df1f8474c253", "615ef445-80f5-4919-af5c-494977779681" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e6d0b075-7659-4da7-b123-a173198f044e", "3e04dccf-fc6a-4ce8-9a3d-64bc8c56b514" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "33232789-99ff-42a1-af61-df1f8474c253", "615ef445-80f5-4919-af5c-494977779681" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33232789-99ff-42a1-af61-df1f8474c253");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6d0b075-7659-4da7-b123-a173198f044e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e04dccf-fc6a-4ce8-9a3d-64bc8c56b514");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "615ef445-80f5-4919-af5c-494977779681");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "40358116-35e4-41f0-9e78-e31cf01c3f8e", "40358116-35e4-41f0-9e78-e31cf01c3f8e", "admin", "ADMIN" },
                    { "54f2034f-b5e7-4550-9232-5797c26f640d", "54f2034f-b5e7-4550-9232-5797c26f640d", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "76ac3c01-4d87-4e27-90bd-95121a486672", 0, "55135d5b-4ed4-4531-85bd-4c4aef009875", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU>PL", null, "AQAAAAEAACcQAAAAECKqgeDZRlcA4C+H8bf4mySadG6XjiezGP6ZR6yRV0tUfLo+KhUJebWWYb9qPLgf7A==", null, false, "91076cd8-925a-44a0-80ac-5674daad1431", false, "adam" },
                    { "8fedb26e-1551-41f7-8750-780f01bbf43e", 0, "fe412491-51f4-49b1-8beb-ca136ee35b1c", "marcin@wsei.edu.pl", true, false, null, "MARCIN@WSEI.EDU>PL", null, "AQAAAAEAACcQAAAAECGQRmzzvBBGr+qe0LhPpjTeltfGPL2DKRspVCy5WaGN8fbuAS6nIR1MLrns3h/4hw==", null, false, "df2e0f64-2b65-4b9c-ad22-f247139d89d3", false, "marcin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "40358116-35e4-41f0-9e78-e31cf01c3f8e", "76ac3c01-4d87-4e27-90bd-95121a486672" },
                    { "54f2034f-b5e7-4550-9232-5797c26f640d", "8fedb26e-1551-41f7-8750-780f01bbf43e" }
                });
        }
    }
}
