﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SerialKeyGenerate;

#nullable disable

namespace SerialKeyGenerate.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240413151131_FirstMigration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SerialKeyGenerate.Models.srialkey", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("End_Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Matchserialkey")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Start_Date")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("addi1")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("addi2")
                        .HasColumnType("int");

                    b.Property<int>("dyscunt")
                        .HasColumnType("int");

                    b.Property<string>("licncekeys")
                        .HasColumnType("longtext");

                    b.Property<string>("serialkey")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("srialkey");
                });
#pragma warning restore 612, 618
        }
    }
}
