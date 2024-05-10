using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addAnnouncement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("558a477b-9b60-47ef-a6c6-fc6ca631e5f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("514f77e0-98b6-4806-b77e-cece2f402e81"));

            migrationBuilder.CreateTable(
                name: "Announcements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Organization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcements", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 78, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Announcements.Admin", null },
                    { 79, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Announcements.Read", null },
                    { 80, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Announcements.Write", null },
                    { 81, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Announcements.Create", null },
                    { 82, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Announcements.Update", null },
                    { 83, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Announcements.Delete", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("f492bf8c-0c6c-48f6-829e-5977550d72a9"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 144, 135, 60, 35, 35, 98, 127, 131, 119, 25, 87, 20, 180, 23, 95, 4, 97, 208, 58, 233, 38, 148, 112, 0, 247, 163, 33, 204, 236, 163, 114, 28, 39, 253, 48, 180, 63, 25, 126, 100, 190, 202, 254, 208, 50, 184, 239, 116, 255, 11, 170, 252, 179, 203, 250, 221, 75, 75, 118, 169, 222, 221, 9, 75 }, new byte[] { 199, 171, 136, 95, 1, 155, 244, 130, 230, 125, 100, 168, 169, 172, 67, 242, 17, 18, 95, 247, 107, 2, 181, 93, 0, 208, 251, 125, 6, 225, 64, 52, 241, 38, 182, 26, 204, 221, 60, 181, 149, 113, 168, 243, 240, 49, 130, 222, 59, 151, 106, 181, 246, 181, 73, 163, 139, 192, 191, 200, 78, 213, 194, 26, 202, 6, 12, 13, 185, 74, 9, 119, 158, 67, 186, 219, 201, 137, 119, 233, 78, 230, 245, 12, 177, 73, 144, 77, 20, 56, 92, 203, 182, 187, 230, 84, 198, 30, 180, 16, 161, 229, 185, 100, 165, 8, 74, 203, 115, 11, 91, 93, 249, 27, 174, 178, 33, 12, 188, 221, 167, 252, 169, 236, 176, 239, 94, 116 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("2e26b055-1fcf-49a1-bfd3-805816ee45e7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("f492bf8c-0c6c-48f6-829e-5977550d72a9") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Announcements");

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("2e26b055-1fcf-49a1-bfd3-805816ee45e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f492bf8c-0c6c-48f6-829e-5977550d72a9"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("514f77e0-98b6-4806-b77e-cece2f402e81"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 15, 130, 72, 32, 237, 53, 187, 133, 117, 65, 115, 182, 150, 70, 147, 143, 112, 139, 151, 173, 240, 19, 255, 242, 151, 50, 21, 144, 99, 196, 82, 179, 195, 78, 97, 145, 232, 27, 240, 36, 43, 122, 39, 184, 40, 89, 238, 147, 5, 142, 121, 138, 83, 220, 99, 33, 101, 39, 76, 242, 73, 124, 82, 120 }, new byte[] { 33, 218, 70, 146, 221, 237, 140, 158, 36, 208, 241, 166, 241, 109, 244, 244, 255, 208, 90, 133, 169, 25, 223, 23, 144, 218, 16, 51, 213, 142, 139, 58, 38, 234, 187, 155, 147, 106, 159, 196, 59, 11, 184, 93, 21, 217, 245, 86, 204, 137, 35, 45, 94, 33, 12, 184, 46, 129, 224, 148, 34, 216, 10, 254, 118, 77, 209, 41, 234, 151, 104, 13, 230, 179, 0, 171, 168, 86, 254, 208, 219, 61, 99, 82, 168, 124, 0, 244, 88, 91, 228, 235, 241, 171, 222, 67, 243, 17, 96, 139, 214, 197, 85, 135, 91, 118, 236, 158, 195, 43, 126, 86, 242, 67, 244, 238, 189, 32, 113, 70, 148, 254, 106, 149, 142, 13, 6, 180 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("558a477b-9b60-47ef-a6c6-fc6ca631e5f9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("514f77e0-98b6-4806-b77e-cece2f402e81") });
        }
    }
}
