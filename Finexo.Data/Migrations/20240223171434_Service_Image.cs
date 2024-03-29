﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Finexo.Data.Migrations
{
    public partial class Service_Image : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Services",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Services");
        }
    }
}
