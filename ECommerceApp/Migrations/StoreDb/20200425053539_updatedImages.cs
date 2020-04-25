﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceApp.Migrations.StoreDb
{
    public partial class updatedImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ID",
                keyValue: 1,
                column: "Image",
                value: "/Assets/InitialEvaluation.jpg");

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ID",
                keyValue: 2,
                column: "Image",
                value: "/Assets/FollowUpConsultation.jpg");

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ID",
                keyValue: 3,
                column: "Image",
                value: "/Assets/LowBack1.jpg");

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ID",
                keyValue: 4,
                column: "Image",
                value: "/Assets/NeckAdjustment1.jpg");

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ID",
                keyValue: 5,
                column: "Image",
                value: "/Assets/UpperBack1.jpg");

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ID",
                keyValue: 6,
                column: "Image",
                value: "/Assets/LowBack2.jpg");

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ID",
                keyValue: 7,
                column: "Image",
                value: "/Assets/NeckAdjustment2.jpg");

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ID",
                keyValue: 8,
                column: "Image",
                value: "/Assets/UpperBack2.jpg");

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ID",
                keyValue: 9,
                column: "Image",
                value: "/Assets/Massage1.jpg");

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ID",
                keyValue: 10,
                column: "Image",
                value: "/Assets/Massage2.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ID",
                keyValue: 1,
                column: "Image",
                value: "~/Assets/InitialEvaluation.jpg");

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ID",
                keyValue: 2,
                column: "Image",
                value: "~/Assets/FollowUpConsultation.jpg");

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ID",
                keyValue: 3,
                column: "Image",
                value: "~/Assets/LowBack1.jpg");

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ID",
                keyValue: 4,
                column: "Image",
                value: "~/Assets/NeckAdjustment1.jpg");

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ID",
                keyValue: 5,
                column: "Image",
                value: "~/Assets/UpperBack1.jpg");

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ID",
                keyValue: 6,
                column: "Image",
                value: "~/Assets/LowBack2.jpg");

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ID",
                keyValue: 7,
                column: "Image",
                value: "~/Assets/NeckAdjustment2.jpg");

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ID",
                keyValue: 8,
                column: "Image",
                value: "~/Assets/UpperBack2.jpg");

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ID",
                keyValue: 9,
                column: "Image",
                value: "~/Assets/Massage1.jpg");

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ID",
                keyValue: 10,
                column: "Image",
                value: "~/Assets/Massage2.jpg");
        }
    }
}
