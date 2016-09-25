using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FourWeb.Migrations.Migrations
{
    public partial class Migrations062509 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubCategories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ChildCategoryIdId = table.Column<int>(nullable: true),
                    ParentCategoriesIdId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_Category_ChildCategoryIdId",
                        column: x => x.ChildCategoryIdId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SubCategories_Category_ParentCategoriesIdId",
                        column: x => x.ParentCategoriesIdId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_ChildCategoryIdId",
                table: "SubCategories",
                column: "ChildCategoryIdId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_ParentCategoriesIdId",
                table: "SubCategories",
                column: "ParentCategoriesIdId");
        }
    }
}
