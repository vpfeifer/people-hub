﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PeopleHub.Infra.Data;

namespace PeopleHub.Infra.Data.Migrations
{
    [DbContext(typeof(PeopleHubContext))]
    partial class PeopleHubContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PeopleHub.Domain.Entities.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("CommentText")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("comments");
                });

            modelBuilder.Entity("PeopleHub.Domain.Entities.Education", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("InstitutionName")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<int?>("YearOfCompletion")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("educational_background");
                });

            modelBuilder.Entity("PeopleHub.Domain.Entities.Friend", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("FriendId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("UserFriendId")
                        .HasColumnType("char(36)");

                    b.HasKey("UserId", "FriendId");

                    b.HasIndex("UserFriendId");

                    b.ToTable("user_friends");
                });

            modelBuilder.Entity("PeopleHub.Domain.Entities.Group", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(500) CHARACTER SET utf8mb4")
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("PhotoUrl")
                        .IsRequired()
                        .HasColumnType("varchar(500) CHARACTER SET utf8mb4")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("groups");
                });

            modelBuilder.Entity("PeopleHub.Domain.Entities.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("GroupId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("posts");
                });

            modelBuilder.Entity("PeopleHub.Domain.Entities.ProfessionalExperience", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("InstitutionName")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsCurrentJob")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("professional_experience");
                });

            modelBuilder.Entity("PeopleHub.Domain.Entities.RelationshipStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("relationship_status");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Unknown"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Single"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Casual"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Crush"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Dating"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Engaged"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Married"
                        });
                });

            modelBuilder.Entity("PeopleHub.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(150) CHARACTER SET utf8mb4")
                        .HasMaxLength(150);

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("varchar(400) CHARACTER SET utf8mb4")
                        .HasMaxLength(400);

                    b.Property<int?>("RelationshipStatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RelationshipStatusId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("PeopleHub.Domain.Entities.UserGroup", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("GroupId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("UserId", "GroupId");

                    b.HasIndex("GroupId");

                    b.ToTable("user_groups");
                });

            modelBuilder.Entity("PeopleHub.Domain.Entities.Comment", b =>
                {
                    b.HasOne("PeopleHub.Domain.Entities.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PeopleHub.Domain.Entities.Education", b =>
                {
                    b.HasOne("PeopleHub.Domain.Entities.User", "User")
                        .WithMany("EducationalBackground")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PeopleHub.Domain.Entities.Friend", b =>
                {
                    b.HasOne("PeopleHub.Domain.Entities.User", "UserFriend")
                        .WithMany()
                        .HasForeignKey("UserFriendId");

                    b.HasOne("PeopleHub.Domain.Entities.User", "User")
                        .WithMany("Friends")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PeopleHub.Domain.Entities.Post", b =>
                {
                    b.HasOne("PeopleHub.Domain.Entities.Group", "Group")
                        .WithMany("Posts")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PeopleHub.Domain.Entities.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PeopleHub.Domain.Entities.ProfessionalExperience", b =>
                {
                    b.HasOne("PeopleHub.Domain.Entities.User", "User")
                        .WithMany("ProfessionalExperience")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PeopleHub.Domain.Entities.User", b =>
                {
                    b.HasOne("PeopleHub.Domain.Entities.RelationshipStatus", "RelationshipStatus")
                        .WithMany()
                        .HasForeignKey("RelationshipStatusId");

                    b.OwnsOne("PeopleHub.Domain.ValueObjects.Name", "Name", b1 =>
                        {
                            b1.Property<Guid>("UserId")
                                .HasColumnType("char(36)");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasColumnName("FirstName")
                                .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                                .HasMaxLength(50);

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasColumnName("LastName")
                                .HasColumnType("varchar(150) CHARACTER SET utf8mb4")
                                .HasMaxLength(150);

                            b1.HasKey("UserId");

                            b1.ToTable("users");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });
                });

            modelBuilder.Entity("PeopleHub.Domain.Entities.UserGroup", b =>
                {
                    b.HasOne("PeopleHub.Domain.Entities.Group", "Group")
                        .WithMany("Groups")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PeopleHub.Domain.Entities.User", "User")
                        .WithMany("Groups")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
