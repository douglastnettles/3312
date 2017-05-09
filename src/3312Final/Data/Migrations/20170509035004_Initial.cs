using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _3312Final.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FinalApproachSpeed",
                table: "Airplane",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FlapInitRetractSpeed",
                table: "Airplane",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FlapRetractSpeed",
                table: "Airplane",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GoAroundSpeed",
                table: "Airplane",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaintainSpeed",
                table: "Airplane",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MinTakeoffSpeed",
                table: "Airplane",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RotationSpeed",
                table: "Airplane",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SafeSpeed",
                table: "Airplane",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinalApproachSpeed",
                table: "Airplane");

            migrationBuilder.DropColumn(
                name: "FlapInitRetractSpeed",
                table: "Airplane");

            migrationBuilder.DropColumn(
                name: "FlapRetractSpeed",
                table: "Airplane");

            migrationBuilder.DropColumn(
                name: "GoAroundSpeed",
                table: "Airplane");

            migrationBuilder.DropColumn(
                name: "MaintainSpeed",
                table: "Airplane");

            migrationBuilder.DropColumn(
                name: "MinTakeoffSpeed",
                table: "Airplane");

            migrationBuilder.DropColumn(
                name: "RotationSpeed",
                table: "Airplane");

            migrationBuilder.DropColumn(
                name: "SafeSpeed",
                table: "Airplane");
        }
    }
}
