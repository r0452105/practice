﻿// <auto-generated />
using System;
using CyclingAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CyclingAPI.Migrations
{
    [DbContext(typeof(CyclingAPIContext))]
    [Migration("20220528121029_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CyclingAPILib.Cyclist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ACC")
                        .HasColumnType("int");

                    b.Property<int>("ATT")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CO")
                        .HasColumnType("int");

                    b.Property<int>("DO")
                        .HasColumnType("int");

                    b.Property<int>("END")
                        .HasColumnType("int");

                    b.Property<double>("EstimateWeight")
                        .HasColumnType("float");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HIL")
                        .HasColumnType("int");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MO")
                        .HasColumnType("int");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PR")
                        .HasColumnType("int");

                    b.Property<int>("REC")
                        .HasColumnType("int");

                    b.Property<int>("RES")
                        .HasColumnType("int");

                    b.Property<int>("RY")
                        .HasColumnType("int");

                    b.Property<int>("SP")
                        .HasColumnType("int");

                    b.Property<int>("TT")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cyclist");

                    b.HasData(
                        new
                        {
                            Id = 1000000,
                            ACC = 10,
                            ATT = 10,
                            BirthDate = new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CO = 10,
                            DO = 10,
                            END = 10,
                            EstimateWeight = 45.0,
                            FirstName = "Aaron",
                            HIL = 10,
                            Height = 1.45,
                            LastName = "Sprangers",
                            MO = 10,
                            Nationality = "Belgium",
                            PR = 10,
                            REC = 10,
                            RES = 10,
                            RY = 10,
                            SP = 10,
                            TT = 10
                        },
                        new
                        {
                            Id = 1000001,
                            ACC = 10,
                            ATT = 10,
                            BirthDate = new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CO = 10,
                            DO = 10,
                            END = 10,
                            EstimateWeight = 45.0,
                            FirstName = "Kevin",
                            HIL = 10,
                            Height = 1.45,
                            LastName = "Ceusters",
                            MO = 10,
                            Nationality = "Belgium",
                            PR = 10,
                            REC = 10,
                            RES = 10,
                            RY = 10,
                            SP = 10,
                            TT = 10
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
