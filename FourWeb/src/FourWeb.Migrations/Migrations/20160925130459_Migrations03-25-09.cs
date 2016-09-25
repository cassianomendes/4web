using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FourWeb.Migrations.Migrations
{
    public partial class Migrations032509 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Category_CategoryId",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_CategoryId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Category");

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                });

            migrationBuilder.AddColumn<int>(
                name: "SubCategoriesId",
                table: "Category",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Category_SubCategoriesId",
                table: "Category",
                column: "SubCategoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_SubCategories_SubCategoriesId",
                table: "Category",
                column: "SubCategoriesId",
                principalTable: "SubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_SubCategories_SubCategoriesId",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_SubCategoriesId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "SubCategoriesId",
                table: "Category");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Category",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Category_CategoryId",
                table: "Category",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Category_CategoryId",
                table: "Category",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
