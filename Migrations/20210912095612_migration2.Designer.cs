﻿// <auto-generated />
using BudgetStatus.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BudgetStatus.Migrations
{
    [DbContext(typeof(SalesDbContext))]
    [Migration("20210912095612_migration2")]
    partial class migration2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BudgetStatus.Models.Bdgfixmonth", b =>
                {
                    b.Property<int>("Counter")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bbudget")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Blongmonth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Bmonth")
                        .HasColumnType("int");

                    b.Property<int>("Byear")
                        .HasColumnType("int");

                    b.Property<int>("Closed")
                        .HasColumnType("int");

                    b.Property<string>("Current")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Counter");

                    b.ToTable("Bdgfixmonth");
                });
#pragma warning restore 612, 618
        }
    }
}