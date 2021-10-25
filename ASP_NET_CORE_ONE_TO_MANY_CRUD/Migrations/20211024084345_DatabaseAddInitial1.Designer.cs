﻿// <auto-generated />
using ASP_NET_CORE_ONE_TO_MANY_CRUD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASP_NET_CORE_ONE_TO_MANY_CRUD.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211024084345_DatabaseAddInitial1")]
    partial class DatabaseAddInitial1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASP_NET_CORE_ONE_TO_MANY_CRUD.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tbl_Department");
                });

            modelBuilder.Entity("ASP_NET_CORE_ONE_TO_MANY_CRUD.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("ID");

                    b.HasIndex("DepId");

                    b.ToTable("tbl_Student");
                });

            modelBuilder.Entity("ASP_NET_CORE_ONE_TO_MANY_CRUD.Models.Student", b =>
                {
                    b.HasOne("ASP_NET_CORE_ONE_TO_MANY_CRUD.Models.Department", "Department")
                        .WithMany("students")
                        .HasForeignKey("DepId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("ASP_NET_CORE_ONE_TO_MANY_CRUD.Models.Department", b =>
                {
                    b.Navigation("students");
                });
#pragma warning restore 612, 618
        }
    }
}
