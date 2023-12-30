using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDepartmentsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Department",
                table: "employees",
                newName: "DepartmentId");

            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Address_City = table.Column<string>(type: "TEXT", nullable: false),
                    Address_Street = table.Column<string>(type: "TEXT", nullable: false),
                    Address_PostalCode = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5c954f63-f266-4e5c-a80e-52e9508b8aae", "5c954f63-f266-4e5c-a80e-52e9508b8aae", "user", "USER" },
                    { "f70c9bc6-b96f-47ef-8eb3-c5dfcda82e56", "f70c9bc6-b96f-47ef-8eb3-c5dfcda82e56", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "397d59d6-3cdc-49af-97a0-399ae3ad27f2", 0, "f4b96a7c-ad8c-4dcf-b173-2cf78dbe671a", "marcin@wsei.edu.pl", true, false, null, "MARCIN@WSEI.EDU>PL", "MARCIN", "AQAAAAEAACcQAAAAEGzvkGOdP9Sb08qw8HLnSNuTsPRaKWQFQ3t1hw0Rh5rhvH9ooJvq40SpqL8KFh/PBw==", null, false, "01e47174-8799-442f-9c45-68c9b75514f0", false, "marcin" },
                    { "d820b101-63f3-420b-a800-1dae29d73335", 0, "8faecabb-d28e-4b32-8bf0-238b740db317", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU>PL", "ADAM", "AQAAAAEAACcQAAAAEP16HvE5P0K6h7mFfXorl8SYyPDU2FoQ8tf05Rzrfd7sMrZiq0T51AETxniF3lUiuQ==", null, false, "b1ad1765-69d3-415d-8f43-06ea331cc2eb", false, "adam" }
                });

            migrationBuilder.InsertData(
                table: "departments",
                columns: new[] { "Id", "Description", "Name", "Address_City", "Address_PostalCode", "Address_Street" },
                values: new object[,]
                {
                    { 1, "Pierwszy oddział", "Kraków Łagiewniki", "Kraków", "31-150", "Wesoła 90A" },
                    { 2, "Największy oddział", "Warszawa Ursynów", "Warszawa", "31-699", "Słoneczna 84B" }
                });

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "id",
                keyValue: 1,
                column: "DepartmentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "id",
                keyValue: 2,
                column: "DepartmentId",
                value: 2);

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5c954f63-f266-4e5c-a80e-52e9508b8aae", "397d59d6-3cdc-49af-97a0-399ae3ad27f2" },
                    { "f70c9bc6-b96f-47ef-8eb3-c5dfcda82e56", "d820b101-63f3-420b-a800-1dae29d73335" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_employees_DepartmentId",
                table: "employees",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_departments_DepartmentId",
                table: "employees",
                column: "DepartmentId",
                principalTable: "departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_departments_DepartmentId",
                table: "employees");

            migrationBuilder.DropTable(
                name: "departments");

            migrationBuilder.DropIndex(
                name: "IX_employees_DepartmentId",
                table: "employees");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5c954f63-f266-4e5c-a80e-52e9508b8aae", "397d59d6-3cdc-49af-97a0-399ae3ad27f2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f70c9bc6-b96f-47ef-8eb3-c5dfcda82e56", "d820b101-63f3-420b-a800-1dae29d73335" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c954f63-f266-4e5c-a80e-52e9508b8aae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f70c9bc6-b96f-47ef-8eb3-c5dfcda82e56");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "397d59d6-3cdc-49af-97a0-399ae3ad27f2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d820b101-63f3-420b-a800-1dae29d73335");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "employees",
                newName: "Department");

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

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "id",
                keyValue: 1,
                column: "Department",
                value: 0);

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "id",
                keyValue: 2,
                column: "Department",
                value: 1);

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "e6d0b075-7659-4da7-b123-a173198f044e", "3e04dccf-fc6a-4ce8-9a3d-64bc8c56b514" },
                    { "33232789-99ff-42a1-af61-df1f8474c253", "615ef445-80f5-4919-af5c-494977779681" }
                });
        }
    }
}
