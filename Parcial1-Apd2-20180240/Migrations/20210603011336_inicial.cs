﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Parcial1_Apd2_20180240.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripsion = table.Column<string>(type: "TEXT", nullable: false),
                    Existencia = table.Column<float>(type: "REAL", nullable: false),
                    Costo = table.Column<float>(type: "REAL", nullable: false),
                    Inventario = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.ProductoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Producto");
        }
    }
}
