using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("3dd100c5-37b5-458e-b49b-996059e59c05"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 44, 103, 156, 95, 79, 248, 9, 132, 124, 195, 205, 189, 95, 87, 73, 217, 8, 179, 254, 30, 255, 189, 114, 189, 191, 80, 84, 234, 59, 44, 236, 119, 188, 226, 202, 193, 206, 25, 145, 181, 5, 34, 157, 78, 231, 129, 229, 243, 29, 249, 138, 92, 30, 94, 166, 220, 136, 245, 188, 191, 196, 216, 1, 214 }, new byte[] { 32, 38, 33, 167, 224, 49, 58, 42, 154, 137, 129, 197, 55, 6, 36, 213, 217, 2, 255, 252, 107, 16, 224, 23, 207, 248, 85, 121, 73, 79, 222, 31, 210, 63, 102, 26, 121, 227, 170, 105, 244, 238, 39, 163, 82, 91, 4, 13, 141, 253, 164, 48, 147, 219, 179, 171, 154, 129, 101, 206, 45, 18, 238, 204, 138, 59, 81, 160, 155, 80, 47, 187, 17, 236, 177, 108, 220, 52, 185, 112, 128, 142, 27, 40, 114, 10, 95, 217, 180, 118, 36, 68, 79, 218, 16, 182, 171, 79, 24, 22, 226, 120, 247, 42, 215, 143, 194, 73, 241, 155, 6, 125, 112, 75, 95, 149, 178, 59, 51, 106, 14, 51, 144, 179, 48, 145, 186, 232 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("afec0140-dfbc-4259-99a3-a1f1554e118e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("3dd100c5-37b5-458e-b49b-996059e59c05") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("afec0140-dfbc-4259-99a3-a1f1554e118e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3dd100c5-37b5-458e-b49b-996059e59c05"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("87f0867e-6cee-47e1-a3bb-588fcbdd731c"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 174, 166, 128, 217, 126, 215, 54, 198, 25, 33, 110, 251, 225, 108, 182, 73, 237, 158, 101, 116, 60, 221, 213, 29, 151, 203, 166, 57, 47, 129, 211, 191, 146, 170, 147, 83, 246, 43, 64, 176, 220, 215, 36, 168, 48, 160, 179, 76, 5, 83, 29, 59, 182, 214, 152, 80, 181, 148, 62, 68, 92, 214, 12, 115 }, new byte[] { 102, 78, 43, 152, 24, 149, 181, 197, 203, 247, 29, 19, 225, 152, 19, 114, 147, 171, 171, 73, 83, 249, 206, 92, 180, 18, 121, 197, 25, 69, 125, 102, 221, 87, 235, 45, 197, 155, 28, 213, 40, 33, 7, 74, 235, 240, 193, 207, 72, 79, 203, 193, 10, 18, 13, 209, 167, 72, 200, 230, 26, 222, 190, 213, 94, 113, 111, 204, 52, 118, 20, 203, 240, 246, 176, 192, 173, 55, 49, 22, 172, 223, 237, 182, 82, 115, 100, 154, 106, 111, 233, 128, 12, 175, 167, 115, 204, 64, 213, 69, 88, 132, 38, 246, 90, 114, 65, 216, 162, 245, 96, 172, 131, 76, 39, 17, 205, 145, 18, 223, 191, 98, 156, 144, 155, 154, 140, 25 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("394f9923-814a-426e-977f-c8082b6c4451"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("87f0867e-6cee-47e1-a3bb-588fcbdd731c") });
        }
    }
}
