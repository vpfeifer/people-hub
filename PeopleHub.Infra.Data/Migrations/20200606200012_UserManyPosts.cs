﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PeopleHub.Infra.Data.Migrations
{
    public partial class UserManyPosts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "posts",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_posts_UserId",
                table: "posts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_posts_users_UserId",
                table: "posts",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_posts_users_UserId",
                table: "posts");

            migrationBuilder.DropIndex(
                name: "IX_posts_UserId",
                table: "posts");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "posts");
        }
    }
}
