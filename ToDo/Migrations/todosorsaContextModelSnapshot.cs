﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToDo.Data;

#nullable disable

namespace ToDo.Migrations
{
    [DbContext(typeof(todosorsaContext))]
    partial class todosorsaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8mb4_general_ci")
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb4");

            modelBuilder.Entity("Aspnetuserrole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId")
                        .HasName("PRIMARY")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                    b.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");

                    b.ToTable("aspnetuserroles", (string)null);
                });

            modelBuilder.Entity("ToDo.Aspnetrole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "NormalizedName" }, "RoleNameIndex")
                        .IsUnique();

                    b.ToTable("aspnetroles", (string)null);
                });

            modelBuilder.Entity("ToDo.Aspnetroleclaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "RoleId" }, "IX_AspNetRoleClaims_RoleId");

                    b.ToTable("aspnetroleclaims", (string)null);
                });

            modelBuilder.Entity("ToDo.Aspnetuser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int(11)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("LockoutEnd")
                        .HasMaxLength(6)
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "NormalizedEmail" }, "EmailIndex");

                    b.HasIndex(new[] { "NormalizedUserName" }, "UserNameIndex")
                        .IsUnique();

                    b.ToTable("aspnetusers", (string)null);
                });

            modelBuilder.Entity("ToDo.Aspnetuserclaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "UserId" }, "IX_AspNetUserClaims_UserId");

                    b.ToTable("aspnetuserclaims", (string)null);
                });

            modelBuilder.Entity("ToDo.Aspnetuserlogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey")
                        .HasName("PRIMARY")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                    b.HasIndex(new[] { "UserId" }, "IX_AspNetUserLogins_UserId");

                    b.ToTable("aspnetuserlogins", (string)null);
                });

            modelBuilder.Entity("ToDo.Aspnetusertoken", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name")
                        .HasName("PRIMARY")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                    b.ToTable("aspnetusertokens", (string)null);
                });

            modelBuilder.Entity("ToDo.Data.SharedTodo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Kuvaus")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Luoja")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Luotu")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("SharedTodos");
                });

            modelBuilder.Entity("ToDo.Data.todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Kuvaus")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Luoja")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Luotu")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Muokattu")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Muokkaaja")
                        .HasColumnType("longtext");

                    b.Property<bool>("Personal")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("SharedTodoId")
                        .HasColumnType("int");

                    b.Property<int>("Tila")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SharedTodoId");

                    b.ToTable("Todos");
                });

            modelBuilder.Entity("ToDo.Data.todoMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("SharedTodoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SharedTodoId");

                    b.ToTable("TodoMembers");
                });

            modelBuilder.Entity("Aspnetuserrole", b =>
                {
                    b.HasOne("ToDo.Aspnetrole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_AspNetUserRoles_AspNetRoles_RoleId");

                    b.HasOne("ToDo.Aspnetuser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_AspNetUserRoles_AspNetUsers_UserId");
                });

            modelBuilder.Entity("ToDo.Aspnetroleclaim", b =>
                {
                    b.HasOne("ToDo.Aspnetrole", "Role")
                        .WithMany("Aspnetroleclaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_AspNetRoleClaims_AspNetRoles_RoleId");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ToDo.Aspnetuserclaim", b =>
                {
                    b.HasOne("ToDo.Aspnetuser", "User")
                        .WithMany("Aspnetuserclaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_AspNetUserClaims_AspNetUsers_UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ToDo.Aspnetuserlogin", b =>
                {
                    b.HasOne("ToDo.Aspnetuser", "User")
                        .WithMany("Aspnetuserlogins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_AspNetUserLogins_AspNetUsers_UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ToDo.Aspnetusertoken", b =>
                {
                    b.HasOne("ToDo.Aspnetuser", "User")
                        .WithMany("Aspnetusertokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_AspNetUserTokens_AspNetUsers_UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ToDo.Data.todo", b =>
                {
                    b.HasOne("ToDo.Data.SharedTodo", null)
                        .WithMany("Tehtavat")
                        .HasForeignKey("SharedTodoId");
                });

            modelBuilder.Entity("ToDo.Data.todoMember", b =>
                {
                    b.HasOne("ToDo.Data.SharedTodo", "SharedTodo")
                        .WithMany("Jasenet")
                        .HasForeignKey("SharedTodoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SharedTodo");
                });

            modelBuilder.Entity("ToDo.Aspnetrole", b =>
                {
                    b.Navigation("Aspnetroleclaims");
                });

            modelBuilder.Entity("ToDo.Aspnetuser", b =>
                {
                    b.Navigation("Aspnetuserclaims");

                    b.Navigation("Aspnetuserlogins");

                    b.Navigation("Aspnetusertokens");
                });

            modelBuilder.Entity("ToDo.Data.SharedTodo", b =>
                {
                    b.Navigation("Jasenet");

                    b.Navigation("Tehtavat");
                });
#pragma warning restore 612, 618
        }
    }
}
