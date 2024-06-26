using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class editadmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "eef8bffe-efc4-4c41-b8df-7d05d28d8e6b", "Admin@example.com", "Admin", "Admin", "AQAAAAIAAYagAAAAEA4OeAkk9QgGuoEGBgbtvDkGNsn8DFXkVbYiVhb4zVs5SjQD+wZGlzyH/tVseWpmfg==", "012152001", true, "8e9d114e-0645-472d-9843-57eea135dab8" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "57334b88-5d4a-4377-9254-8ea31fc37643", "Admin@gmail.com", null, null, "AQAAAAIAAYagAAAAEHnzD5kAG/A1vp/wzZx/Fw4HN58rTxZ61xmcHHW/12YZhVbVWBWkuUxwFRaUKgt8Cg==", null, false, "" });
        }
    }
}
