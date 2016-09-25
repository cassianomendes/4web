using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FourWeb.Migrations.Migrations
{
    public partial class Migrations042509 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_SubCategories_SubCategoriesId",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_SubCategoriesId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "SubCategoriesId",
                table: "Category");

            migrationBuilder.AddColumn<int>(
                name: "ChildCategoryIdId",
                table: "SubCategories",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubCategoriesIdId",
                table: "SubCategories",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_ChildCategoryIdId",
                table: "SubCategories",
                column: "ChildCategoryIdId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_SubCategoriesIdId",
                table: "SubCategories",
                column: "SubCategoriesIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategories_Category_ChildCategoryIdId",
                table: "SubCategories",
                column: "ChildCategoryIdId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategories_Category_SubCategoriesIdId",
                table: "SubCategories",
                column: "SubCategoriesIdId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubCategories_Category_ChildCategoryIdId",
                table: "SubCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategories_Category_SubCategoriesIdId",
                table: "SubCategories");

            migrationBuilder.DropIndex(
                name: "IX_SubCategories_ChildCategoryIdId",
                table: "SubCategories");

            migrationBuilder.DropIndex(
                name: "IX_SubCategories_SubCategoriesIdId",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "ChildCategoryIdId",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "SubCategoriesIdId",
                table: "SubCategories");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "SubCategories",
                nullable: false,
                defaultValue: 0);

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
    }
}
