using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kutuphane.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categoryModels",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoryModels", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "printeryModels",
                columns: table => new
                {
                    PrinteryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrinteryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrinteryAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrinteryDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrinteryPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrinteryMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrinteryIBAN = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_printeryModels", x => x.PrinteryId);
                });

            migrationBuilder.CreateTable(
                name: "writerModels",
                columns: table => new
                {
                    WriterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WriterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WriterSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WriterPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WriterAbout = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WriterAdress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_writerModels", x => x.WriterId);
                });

            migrationBuilder.CreateTable(
                name: "booksModels",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookPage = table.Column<int>(type: "int", nullable: false),
                    WriterId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    PrinteryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_booksModels", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_booksModels_categoryModels_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categoryModels",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_booksModels_printeryModels_PrinteryId",
                        column: x => x.PrinteryId,
                        principalTable: "printeryModels",
                        principalColumn: "PrinteryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_booksModels_writerModels_WriterId",
                        column: x => x.WriterId,
                        principalTable: "writerModels",
                        principalColumn: "WriterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "processModels",
                columns: table => new
                {
                    ProcessId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Books = table.Column<int>(type: "int", nullable: false),
                    Writer = table.Column<int>(type: "int", nullable: false),
                    Printery = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_processModels", x => x.ProcessId);
                    table.ForeignKey(
                        name: "FK_processModels_booksModels_BookId",
                        column: x => x.BookId,
                        principalTable: "booksModels",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_booksModels_CategoryId",
                table: "booksModels",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_booksModels_PrinteryId",
                table: "booksModels",
                column: "PrinteryId");

            migrationBuilder.CreateIndex(
                name: "IX_booksModels_WriterId",
                table: "booksModels",
                column: "WriterId");

            migrationBuilder.CreateIndex(
                name: "IX_processModels_BookId",
                table: "processModels",
                column: "BookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "processModels");

            migrationBuilder.DropTable(
                name: "booksModels");

            migrationBuilder.DropTable(
                name: "categoryModels");

            migrationBuilder.DropTable(
                name: "printeryModels");

            migrationBuilder.DropTable(
                name: "writerModels");
        }
    }
}
