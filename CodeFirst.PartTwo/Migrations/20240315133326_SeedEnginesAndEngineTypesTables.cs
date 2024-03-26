using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeFirst.PartTwo.Migrations
{
    /// <inheritdoc />
    public partial class SeedEnginesAndEngineTypesTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EngineTypes",
                columns: new[] { "EngineTypeId", "Model", "Name" },
                values: new object[,]
                {
                    { 1, "Model1", "Name1" },
                    { 2, "Model2", "Name2" }
                });

            migrationBuilder.InsertData(
                table: "Engines",
                columns: new[] { "EngineId", "Brand", "CarId", "EngineTypeId", "SerialNumber", "Type", "Year" },
                values: new object[,]
                {
                    { 1, "Fiat", 1, 1, "000000", "type1", 2001 },
                    { 2, "Volkswagen", 2, 1, "000001", "type2", 2005 },
                    { 3, "Renault", 3, 2, "000002", "type3", 2012 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Engines",
                keyColumn: "EngineId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Engines",
                keyColumn: "EngineId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Engines",
                keyColumn: "EngineId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EngineTypes",
                keyColumn: "EngineTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EngineTypes",
                keyColumn: "EngineTypeId",
                keyValue: 2);
        }
    }
}
