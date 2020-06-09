using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PeopleHub.Infra.Data.Migrations
{
    public partial class AddCommentEducationProfessionalExpRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "documents");

            migrationBuilder.AddColumn<int>(
                name: "RelationshipStatusId",
                table: "users",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CommentText = table.Column<string>(type: "longtext", nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_comments_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "educational_background",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    InstitutionName = table.Column<string>(nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false),
                    YearOfCompletion = table.Column<int>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_educational_background", x => x.Id);
                    table.ForeignKey(
                        name: "FK_educational_background_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "professional_experience",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    InstitutionName = table.Column<string>(nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    IsCurrentJob = table.Column<bool>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_professional_experience", x => x.Id);
                    table.ForeignKey(
                        name: "FK_professional_experience_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "relationship_status",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_relationship_status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "user_friends",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    FriendId = table.Column<Guid>(nullable: false),
                    UserFriendId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_friends", x => new { x.UserId, x.FriendId });
                    table.ForeignKey(
                        name: "FK_user_friends_users_UserFriendId",
                        column: x => x.UserFriendId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_user_friends_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_users_RelationshipStatusId",
                table: "users",
                column: "RelationshipStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_comments_UserId",
                table: "comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_educational_background_UserId",
                table: "educational_background",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_professional_experience_UserId",
                table: "professional_experience",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_user_friends_UserFriendId",
                table: "user_friends",
                column: "UserFriendId");

            migrationBuilder.AddForeignKey(
                name: "FK_users_relationship_status_RelationshipStatusId",
                table: "users",
                column: "RelationshipStatusId",
                principalTable: "relationship_status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_relationship_status_RelationshipStatusId",
                table: "users");

            migrationBuilder.DropTable(
                name: "comments");

            migrationBuilder.DropTable(
                name: "educational_background");

            migrationBuilder.DropTable(
                name: "professional_experience");

            migrationBuilder.DropTable(
                name: "relationship_status");

            migrationBuilder.DropTable(
                name: "user_friends");

            migrationBuilder.DropIndex(
                name: "IX_users_RelationshipStatusId",
                table: "users");

            migrationBuilder.DropColumn(
                name: "RelationshipStatusId",
                table: "users");

            migrationBuilder.CreateTable(
                name: "documents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Number = table.Column<string>(type: "varchar(40) CHARACTER SET utf8mb4", maxLength: 40, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_documents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_documents_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_documents_UserId",
                table: "documents",
                column: "UserId",
                unique: true);
        }
    }
}
