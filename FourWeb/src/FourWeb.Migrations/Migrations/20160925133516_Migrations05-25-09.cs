using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FourWeb.Migrations.Migrations
{
    public partial class Migrations052509 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubCategories_Category_SubCategoriesIdId",
                table: "SubCategories");

            migrationBuilder.DropIndex(
                name: "IX_SubCategories_SubCategoriesIdId",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "SubCategoriesIdId",
                table: "SubCategories");

            migrationBuilder.AddColumn<int>(
                name: "ParentCategoriesIdId",
                table: "SubCategories",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_ParentCategoriesIdId",
                table: "SubCategories",
                column: "ParentCategoriesIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategories_Category_ParentCategoriesIdId",
                table: "SubCategories",
                column: "ParentCategoriesIdId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubCategories_Category_ParentCategoriesIdId",
                table: "SubCategories");

            migrationBuilder.DropIndex(
                name: "IX_SubCategories_ParentCategoriesIdId",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "ParentCategoriesIdId",
                table: "SubCategories");

            migrationBuilder.AddColumn<int>(
                name: "SubCategoriesIdId",
                table: "SubCategories",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_SubCategoriesIdId",
                table: "SubCategories",
                column: "SubCategoriesIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategories_Category_SubCategoriesIdId",
                table: "SubCategories",
                column: "SubCategoriesIdId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
