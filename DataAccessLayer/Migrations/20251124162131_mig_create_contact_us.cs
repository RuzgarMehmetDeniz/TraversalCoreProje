using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig_create_contact_us : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Tarih kolonu silme kodunu kaldırdık
            // migrationBuilder.DropColumn(
            //     name: "Tarih",
            //     table: "Destinations");

            // Eğer Destinations tablosunda Tarih kolonu yoksa hata vermemesi için SQL ile kontrol ekleyebilirsin:
            migrationBuilder.Sql(@"
                IF NOT EXISTS (
                    SELECT * 
                    FROM sys.columns 
                    WHERE object_id = OBJECT_ID(N'[Destinations]') AND name = N'Tarih'
                )
                BEGIN
                    ALTER TABLE [Destinations]
                    ADD [Tarih] datetime2 NOT NULL DEFAULT GETUTCDATE();
                END
            ");

            migrationBuilder.CreateTable(
                name: "ContactUses",
                columns: table => new
                {
                    ContactUsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageBody = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUses", x => x.ContactUsID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactUses");

            // Down metodunda, eklediğimiz Tarih kolonunu sil
            migrationBuilder.DropColumn(
                name: "Tarih",
                table: "Destinations");
        }
    }
}
