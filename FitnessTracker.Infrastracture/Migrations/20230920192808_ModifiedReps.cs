using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessTracker.Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedReps : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Reps",
                table: "FitnessTrackers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Reps",
                table: "FitnessTrackers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
