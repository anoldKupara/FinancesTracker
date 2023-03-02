using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinancesTracker.Migrations
{
    /// <inheritdoc />
    public partial class initailMigration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_Balances_BalanceId",
                table: "Expenses");

            migrationBuilder.DropForeignKey(
                name: "FK_Incomes_Balances_BalanceId",
                table: "Incomes");

            migrationBuilder.AlterColumn<int>(
                name: "BalanceId",
                table: "Incomes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BalanceId",
                table: "Expenses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_Balances_BalanceId",
                table: "Expenses",
                column: "BalanceId",
                principalTable: "Balances",
                principalColumn: "BalanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Incomes_Balances_BalanceId",
                table: "Incomes",
                column: "BalanceId",
                principalTable: "Balances",
                principalColumn: "BalanceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_Balances_BalanceId",
                table: "Expenses");

            migrationBuilder.DropForeignKey(
                name: "FK_Incomes_Balances_BalanceId",
                table: "Incomes");

            migrationBuilder.AlterColumn<int>(
                name: "BalanceId",
                table: "Incomes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BalanceId",
                table: "Expenses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_Balances_BalanceId",
                table: "Expenses",
                column: "BalanceId",
                principalTable: "Balances",
                principalColumn: "BalanceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Incomes_Balances_BalanceId",
                table: "Incomes",
                column: "BalanceId",
                principalTable: "Balances",
                principalColumn: "BalanceId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
