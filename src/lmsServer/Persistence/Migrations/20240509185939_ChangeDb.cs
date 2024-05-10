using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("89b88958-848b-45a1-86b0-0f8aa3c6ff1f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("833904c8-dd27-4a1d-ba46-94e9044f5b96"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("87f0867e-6cee-47e1-a3bb-588fcbdd731c"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 174, 166, 128, 217, 126, 215, 54, 198, 25, 33, 110, 251, 225, 108, 182, 73, 237, 158, 101, 116, 60, 221, 213, 29, 151, 203, 166, 57, 47, 129, 211, 191, 146, 170, 147, 83, 246, 43, 64, 176, 220, 215, 36, 168, 48, 160, 179, 76, 5, 83, 29, 59, 182, 214, 152, 80, 181, 148, 62, 68, 92, 214, 12, 115 }, new byte[] { 102, 78, 43, 152, 24, 149, 181, 197, 203, 247, 29, 19, 225, 152, 19, 114, 147, 171, 171, 73, 83, 249, 206, 92, 180, 18, 121, 197, 25, 69, 125, 102, 221, 87, 235, 45, 197, 155, 28, 213, 40, 33, 7, 74, 235, 240, 193, 207, 72, 79, 203, 193, 10, 18, 13, 209, 167, 72, 200, 230, 26, 222, 190, 213, 94, 113, 111, 204, 52, 118, 20, 203, 240, 246, 176, 192, 173, 55, 49, 22, 172, 223, 237, 182, 82, 115, 100, 154, 106, 111, 233, 128, 12, 175, 167, 115, 204, 64, 213, 69, 88, 132, 38, 246, 90, 114, 65, 216, 162, 245, 96, 172, 131, 76, 39, 17, 205, 145, 18, 223, 191, 98, 156, 144, 155, 154, 140, 25 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("394f9923-814a-426e-977f-c8082b6c4451"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("87f0867e-6cee-47e1-a3bb-588fcbdd731c") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("394f9923-814a-426e-977f-c8082b6c4451"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("87f0867e-6cee-47e1-a3bb-588fcbdd731c"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("833904c8-dd27-4a1d-ba46-94e9044f5b96"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 70, 169, 234, 69, 174, 45, 174, 199, 136, 153, 36, 146, 246, 166, 240, 116, 227, 135, 187, 28, 245, 246, 131, 138, 208, 76, 0, 85, 171, 249, 50, 140, 7, 70, 151, 111, 31, 0, 225, 113, 91, 11, 26, 231, 82, 96, 88, 204, 103, 98, 82, 107, 221, 208, 60, 132, 15, 49, 87, 17, 240, 40, 122, 174 }, new byte[] { 94, 225, 38, 217, 82, 73, 166, 128, 118, 41, 53, 2, 188, 56, 66, 60, 192, 151, 57, 157, 72, 79, 220, 154, 222, 154, 31, 95, 130, 27, 183, 200, 61, 59, 40, 14, 101, 88, 113, 217, 56, 18, 23, 35, 185, 192, 64, 221, 193, 87, 127, 190, 161, 178, 48, 76, 210, 197, 114, 14, 116, 210, 190, 63, 193, 49, 109, 150, 38, 175, 71, 252, 71, 113, 199, 220, 137, 239, 156, 52, 119, 98, 240, 124, 46, 79, 38, 35, 85, 65, 246, 27, 131, 205, 17, 55, 163, 95, 150, 174, 123, 169, 210, 195, 231, 231, 117, 214, 151, 204, 45, 210, 242, 27, 248, 47, 251, 233, 62, 214, 228, 70, 103, 37, 170, 84, 212, 202 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("89b88958-848b-45a1-86b0-0f8aa3c6ff1f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("833904c8-dd27-4a1d-ba46-94e9044f5b96") });
        }
    }
}
