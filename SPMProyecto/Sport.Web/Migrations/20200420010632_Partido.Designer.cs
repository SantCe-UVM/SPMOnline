﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sport.Web.Data;

namespace Sport.Web.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200420010632_Partido")]
    partial class Partido
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sport.Web.Data.Entities.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("MatchDate");

                    b.Property<int>("MatchHours")
                        .HasMaxLength(25);

                    b.Property<string>("MatchLocation")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<int>("MatchMinutes")
                        .HasMaxLength(25);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Sport")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.HasKey("Id");

                    b.ToTable("Matchs");
                });

            modelBuilder.Entity("Sport.Web.Data.Entities.Tournament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Sport")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.HasKey("Id");

                    b.ToTable("Tournaments");
                });

            modelBuilder.Entity("Sport.Web.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Age")
                        .HasMaxLength(2);

                    b.Property<DateTime>("BirthDate");

                    b.Property<bool>("Coach")
                        .HasMaxLength(2);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Health")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<float>("Height")
                        .HasMaxLength(2);

                    b.Property<string>("HomeCountry")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("Sport")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<float>("Weight")
                        .HasMaxLength(2);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
