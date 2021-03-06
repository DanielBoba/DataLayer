﻿// <auto-generated />
using System;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataLayer.Migrations
{
    [DbContext(typeof(DBContextCryptoBots))]
    [Migration("20180811182920_three")]
    partial class three
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataLayer.Models.BitfinexFundings", b =>
                {
                    b.Property<Guid>("Key")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount");

                    b.Property<long>("Id");

                    b.Property<DateTime>("Mts");

                    b.Property<double>("Period");

                    b.Property<double>("Rate");

                    b.Property<string>("Symbol");

                    b.HasKey("Key");

                    b.ToTable("BitfinexFundings");
                });

            modelBuilder.Entity("DataLayer.Models.BitfinexTrades", b =>
                {
                    b.Property<Guid>("Key")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount");

                    b.Property<long>("Id");

                    b.Property<DateTime>("Mts");

                    b.Property<string>("Pair");

                    b.Property<double>("Price");

                    b.HasKey("Key");

                    b.ToTable("BitfinexTrades");
                });
#pragma warning restore 612, 618
        }
    }
}
