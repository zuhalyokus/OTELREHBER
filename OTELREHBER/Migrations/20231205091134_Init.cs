using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OTELREHBER.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Otels",
                columns: table => new
                {
                    UUID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YetkiliAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YekiliSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirmaUnvan = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Otels", x => x.UUID);
                });

            migrationBuilder.CreateTable(
                name: "Oteliletisims",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Telefon_Numarası = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtelID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oteliletisims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Oteliletisims_Otels_OtelID",
                        column: x => x.OtelID,
                        principalTable: "Otels",
                        principalColumn: "UUID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Oteliletisims_OtelID",
                table: "Oteliletisims",
                column: "OtelID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Oteliletisims");

            migrationBuilder.DropTable(
                name: "Otels");
        }
    }
}
