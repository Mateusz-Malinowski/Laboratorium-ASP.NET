using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPositionsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Position",
                table: "employees",
                newName: "PositionId");

            migrationBuilder.CreateTable(
                name: "positions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Salary = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_positions", x => x.Id);
                });

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
                column: "Name",
                value: "Wrocław Strachowice");

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Warszawa Powiśle");

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "id",
                keyValue: 1,
                column: "PositionId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "id",
                keyValue: 2,
                column: "PositionId",
                value: 2);

            migrationBuilder.InsertData(
                table: "positions",
                columns: new[] { "Id", "Name", "Salary" },
                values: new object[,]
                {
                    { 1, "Manager", 150 },
                    { 2, "Full-Stack Developer", 120 },
                    { 3, "Front-End Developer", 100 },
                    { 4, "Back-End Developer", 100 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5376a31f-639c-4108-81e2-acf7f258b132", "2b867e59-368a-4d34-8c2c-4c22d2916871" },
                    { "f6c2eb7c-8986-4236-b5fb-c2cc777aea9b", "e7cd5d52-edb2-428b-aab9-91c41a0b43ea" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_employees_PositionId",
                table: "employees",
                column: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_positions_PositionId",
                table: "employees",
                column: "PositionId",
                principalTable: "positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_positions_PositionId",
                table: "employees");

            migrationBuilder.DropTable(
                name: "positions");

            migrationBuilder.DropIndex(
                name: "IX_employees_PositionId",
                table: "employees");

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

            migrationBuilder.RenameColumn(
                name: "PositionId",
                table: "employees",
                newName: "Position");

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

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Kraków Łagiewniki");

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Warszawa Ursynów");

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "id",
                keyValue: 1,
                column: "Position",
                value: 0);

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "id",
                keyValue: 2,
                column: "Position",
                value: 1);

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5c954f63-f266-4e5c-a80e-52e9508b8aae", "397d59d6-3cdc-49af-97a0-399ae3ad27f2" },
                    { "f70c9bc6-b96f-47ef-8eb3-c5dfcda82e56", "d820b101-63f3-420b-a800-1dae29d73335" }
                });
        }
    }
}
