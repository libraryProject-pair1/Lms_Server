using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedInfoForRegisterLoginMember : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("2e26b055-1fcf-49a1-bfd3-805816ee45e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f492bf8c-0c6c-48f6-829e-5977550d72a9"));

            migrationBuilder.AlterColumn<int>(
                name: "ReturnStatus",
                table: "LoanTransactions",
                type: "int",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("833904c8-dd27-4a1d-ba46-94e9044f5b96"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 70, 169, 234, 69, 174, 45, 174, 199, 136, 153, 36, 146, 246, 166, 240, 116, 227, 135, 187, 28, 245, 246, 131, 138, 208, 76, 0, 85, 171, 249, 50, 140, 7, 70, 151, 111, 31, 0, 225, 113, 91, 11, 26, 231, 82, 96, 88, 204, 103, 98, 82, 107, 221, 208, 60, 132, 15, 49, 87, 17, 240, 40, 122, 174 }, new byte[] { 94, 225, 38, 217, 82, 73, 166, 128, 118, 41, 53, 2, 188, 56, 66, 60, 192, 151, 57, 157, 72, 79, 220, 154, 222, 154, 31, 95, 130, 27, 183, 200, 61, 59, 40, 14, 101, 88, 113, 217, 56, 18, 23, 35, 185, 192, 64, 221, 193, 87, 127, 190, 161, 178, 48, 76, 210, 197, 114, 14, 116, 210, 190, 63, 193, 49, 109, 150, 38, 175, 71, 252, 71, 113, 199, 220, 137, 239, 156, 52, 119, 98, 240, 124, 46, 79, 38, 35, 85, 65, 246, 27, 131, 205, 17, 55, 163, 95, 150, 174, 123, 169, 210, 195, 231, 231, 117, 214, 151, 204, 45, 210, 242, 27, 248, 47, 251, 233, 62, 214, 228, 70, 103, 37, 170, 84, 212, 202 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("89b88958-848b-45a1-86b0-0f8aa3c6ff1f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("833904c8-dd27-4a1d-ba46-94e9044f5b96") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("89b88958-848b-45a1-86b0-0f8aa3c6ff1f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("833904c8-dd27-4a1d-ba46-94e9044f5b96"));

            migrationBuilder.AlterColumn<bool>(
                name: "ReturnStatus",
                table: "LoanTransactions",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("f492bf8c-0c6c-48f6-829e-5977550d72a9"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 144, 135, 60, 35, 35, 98, 127, 131, 119, 25, 87, 20, 180, 23, 95, 4, 97, 208, 58, 233, 38, 148, 112, 0, 247, 163, 33, 204, 236, 163, 114, 28, 39, 253, 48, 180, 63, 25, 126, 100, 190, 202, 254, 208, 50, 184, 239, 116, 255, 11, 170, 252, 179, 203, 250, 221, 75, 75, 118, 169, 222, 221, 9, 75 }, new byte[] { 199, 171, 136, 95, 1, 155, 244, 130, 230, 125, 100, 168, 169, 172, 67, 242, 17, 18, 95, 247, 107, 2, 181, 93, 0, 208, 251, 125, 6, 225, 64, 52, 241, 38, 182, 26, 204, 221, 60, 181, 149, 113, 168, 243, 240, 49, 130, 222, 59, 151, 106, 181, 246, 181, 73, 163, 139, 192, 191, 200, 78, 213, 194, 26, 202, 6, 12, 13, 185, 74, 9, 119, 158, 67, 186, 219, 201, 137, 119, 233, 78, 230, 245, 12, 177, 73, 144, 77, 20, 56, 92, 203, 182, 187, 230, 84, 198, 30, 180, 16, 161, 229, 185, 100, 165, 8, 74, 203, 115, 11, 91, 93, 249, 27, 174, 178, 33, 12, 188, 221, 167, 252, 169, 236, 176, 239, 94, 116 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("2e26b055-1fcf-49a1-bfd3-805816ee45e7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("f492bf8c-0c6c-48f6-829e-5977550d72a9") });
        }
    }
}
