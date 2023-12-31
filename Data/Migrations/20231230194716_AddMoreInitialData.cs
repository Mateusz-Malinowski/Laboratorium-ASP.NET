using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5376a31f-639c-4108-81e2-acf7f258b132", "2b867e59-368a-4d34-8c2c-4c22d2916871" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f6c2eb7c-8986-4236-b5fb-c2cc777aea9b", "e7cd5d52-edb2-428b-aab9-91c41a0b43ea" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5376a31f-639c-4108-81e2-acf7f258b132");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6c2eb7c-8986-4236-b5fb-c2cc777aea9b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b867e59-368a-4d34-8c2c-4c22d2916871");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7cd5d52-edb2-428b-aab9-91c41a0b43ea");

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

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Address_City",
                value: "Wrocław");

            migrationBuilder.InsertData(
                table: "departments",
                columns: new[] { "Id", "Description", "Name", "Address_City", "Address_PostalCode", "Address_Street" },
                values: new object[,]
                {
                    { 3, "Jedyny w Małopolsce", "Kraków Podgórze", "Kraków", "32-680", "Deszczowa 21" },
                    { 4, "Nadmorski oddział", "Gdańsk Oliwa", "Gdańsk", "80-245", "Słowackiego 12" },
                    { 5, "Wielkopolski oddział", "Poznań Jeżyce", "Poznań", "61-538", "Dąbrowskiego 33" },
                    { 6, "Centralny oddział", "Łódź Bałuty", "Łódź", "90-402", "Piotrkowska 65" },
                    { 7, "Pomorski oddział", "Szczecin Pogodno", "Szczecin", "70-385", "Mickiewicza 7" },
                    { 8, "Śląski oddział", "Katowice Ligota", "Katowice", "40-101", "Chorzowska 55" }
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 8);

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5376a31f-639c-4108-81e2-acf7f258b132", "5376a31f-639c-4108-81e2-acf7f258b132", "admin", "ADMIN" },
                    { "f6c2eb7c-8986-4236-b5fb-c2cc777aea9b", "f6c2eb7c-8986-4236-b5fb-c2cc777aea9b", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2b867e59-368a-4d34-8c2c-4c22d2916871", 0, "108ebebb-3718-47b0-835e-151ebccad292", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU>PL", "ADAM", "AQAAAAEAACcQAAAAEK3OexQ2Nddz68q+99Xw0x6Sg1fCNJE+FpMzKxqIDEV9yN3IxLrU7zm4J3bB21RtPg==", null, false, "5b92f376-5d16-415d-93d7-62ca06138529", false, "adam" },
                    { "e7cd5d52-edb2-428b-aab9-91c41a0b43ea", 0, "a50f03f0-e80c-426c-b991-2ac2e55125e2", "marcin@wsei.edu.pl", true, false, null, "MARCIN@WSEI.EDU>PL", "MARCIN", "AQAAAAEAACcQAAAAEDr3w3rtqsZBASXibswX/ysC8s6pSWI3tbyq9tsth/GbsBpr4dz19rRPs7fvv02vPA==", null, false, "8b920610-6fea-4c27-89b7-be1bada3a984", false, "marcin" }
                });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Address_City",
                value: "Kraków");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5376a31f-639c-4108-81e2-acf7f258b132", "2b867e59-368a-4d34-8c2c-4c22d2916871" },
                    { "f6c2eb7c-8986-4236-b5fb-c2cc777aea9b", "e7cd5d52-edb2-428b-aab9-91c41a0b43ea" }
                });
        }
    }
}
