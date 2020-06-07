﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PeopleHub.Infra.Data;

namespace PeopleHub.Infra.Data.Migrations
{
    [DbContext(typeof(PeopleHubContext))]
    [Migration("20200607191853_AddUserGroups")]
    partial class AddUserGroups
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PeopleHub.Domain.Entities.Document", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4")
                        .HasMaxLength(40);

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("documents");
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

                    b.HasKey("Id");

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

            modelBuilder.Entity("PeopleHub.Domain.Entities.Document", b =>
                {
                    b.HasOne("PeopleHub.Domain.Entities.User", "User")
                        .WithOne("Document")
                        .HasForeignKey("PeopleHub.Domain.Entities.Document", "UserId")
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

            modelBuilder.Entity("PeopleHub.Domain.Entities.User", b =>
                {
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