﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Industry4_0.Data.Migrations
{
    public partial class AddMigrationMigration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AgreeAvail",
                table: "CompaniesFeedback",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DisagreeAvail",
                table: "CompaniesFeedback",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgreeAvail",
                table: "CompaniesFeedback");

            migrationBuilder.DropColumn(
                name: "DisagreeAvail",
                table: "CompaniesFeedback");
        }
    }
}
