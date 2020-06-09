using Microsoft.EntityFrameworkCore.Migrations;

namespace PeopleHub.Infra.Data.Migrations
{
    public partial class SeedRelationshipStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "relationship_status",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.InsertData(
                table: "relationship_status",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Unknown" },
                    { 2, "Single" },
                    { 3, "Casual" },
                    { 4, "Crush" },
                    { 5, "Dating" },
                    { 6, "Engaged" },
                    { 7, "Married" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "relationship_status",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "relationship_status",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "relationship_status",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "relationship_status",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "relationship_status",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "relationship_status",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "relationship_status",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "relationship_status",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);
        }
    }
}
