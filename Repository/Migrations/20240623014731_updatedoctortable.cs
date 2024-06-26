using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class updatedoctortable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "Identity",
                table: "SensorData",
                newName: "id");

            migrationBuilder.AlterColumn<int>(
                name: "OxygenRate",
                schema: "Identity",
                table: "SensorData",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<int>(
                name: "HeartRate",
                schema: "Identity",
                table: "SensorData",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                schema: "Identity",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FName",
                schema: "Identity",
                table: "Doctors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LName",
                schema: "Identity",
                table: "Doctors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                schema: "Identity",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                schema: "Identity",
                table: "Doctors",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "ffc120b3-d9d2-481a-b401-db336a1db789");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                schema: "Identity",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "FName",
                schema: "Identity",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "LName",
                schema: "Identity",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "Password",
                schema: "Identity",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                schema: "Identity",
                table: "Doctors");

            migrationBuilder.RenameColumn(
                name: "id",
                schema: "Identity",
                table: "SensorData",
                newName: "Id");

            migrationBuilder.AlterColumn<float>(
                name: "OxygenRate",
                schema: "Identity",
                table: "SensorData",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "HeartRate",
                schema: "Identity",
                table: "SensorData",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "4d4e8904-74ff-4054-a04e-4524535a9812");
        }
    }
}
