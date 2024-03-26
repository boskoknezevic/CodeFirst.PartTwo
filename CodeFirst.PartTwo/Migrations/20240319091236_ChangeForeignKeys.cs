using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirst.PartTwo.Migrations
{
    /// <inheritdoc />
    public partial class ChangeForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Engines_Cars_CarId",
                table: "Engines");

            migrationBuilder.DropForeignKey(
                name: "FK_Engines_EngineTypes_EngineTypeId",
                table: "Engines");

            migrationBuilder.DropIndex(
                name: "IX_Engines_CarId",
                table: "Engines");

            migrationBuilder.AlterColumn<int>(
                name: "EngineTypeId",
                table: "Engines",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CarId",
                table: "Engines",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Engines_CarId",
                table: "Engines",
                column: "CarId",
                unique: true,
                filter: "[CarId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Engines_Cars_CarId",
                table: "Engines",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Engines_EngineTypes_EngineTypeId",
                table: "Engines",
                column: "EngineTypeId",
                principalTable: "EngineTypes",
                principalColumn: "EngineTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Engines_Cars_CarId",
                table: "Engines");

            migrationBuilder.DropForeignKey(
                name: "FK_Engines_EngineTypes_EngineTypeId",
                table: "Engines");

            migrationBuilder.DropIndex(
                name: "IX_Engines_CarId",
                table: "Engines");

            migrationBuilder.AlterColumn<int>(
                name: "EngineTypeId",
                table: "Engines",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CarId",
                table: "Engines",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Engines_CarId",
                table: "Engines",
                column: "CarId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Engines_Cars_CarId",
                table: "Engines",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Engines_EngineTypes_EngineTypeId",
                table: "Engines",
                column: "EngineTypeId",
                principalTable: "EngineTypes",
                principalColumn: "EngineTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
