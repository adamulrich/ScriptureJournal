using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScriptureJournal.Migrations
{
    public partial class Book : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Book",
                table: "JournalEntry");

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "JournalEntry",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_JournalEntry_BookId",
                table: "JournalEntry",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_JournalEntry_Book_BookId",
                table: "JournalEntry",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JournalEntry_Book_BookId",
                table: "JournalEntry");

            migrationBuilder.DropIndex(
                name: "IX_JournalEntry_BookId",
                table: "JournalEntry");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "JournalEntry");

            migrationBuilder.AddColumn<string>(
                name: "Book",
                table: "JournalEntry",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
