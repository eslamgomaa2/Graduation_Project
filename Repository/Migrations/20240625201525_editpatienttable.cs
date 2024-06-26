using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class editpatienttable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "Identity",
                table: "Patients",
                newName: "UserName");

            migrationBuilder.AddColumn<string>(
                name: "FName",
                schema: "Identity",
                table: "Patients",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LName",
                schema: "Identity",
                table: "Patients",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "UserName" },
                values: new object[] { "57334b88-5d4a-4377-9254-8ea31fc37643", "Admin@gmail.com", "AQAAAAIAAYagAAAAEHnzD5kAG/A1vp/wzZx/Fw4HN58rTxZ61xmcHHW/12YZhVbVWBWkuUxwFRaUKgt8Cg==", "Admin@example.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FName",
                schema: "Identity",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "LName",
                schema: "Identity",
                table: "Patients");

            migrationBuilder.RenameColumn(
                name: "UserName",
                schema: "Identity",
                table: "Patients",
                newName: "Name");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "UserName" },
                values: new object[] { "51c1949c-9fad-4596-84af-5874a48cbba9", "admin@example.com", "AQAAAAIAAYagAAAAENWS/Dh/j5sU+S2NyQH1G1AYMWHxMLcIThfk8zCto6Az2AGl+HenRGX2LQSrVWT8eA==", "admin@example.com" });
        }
    }
}
