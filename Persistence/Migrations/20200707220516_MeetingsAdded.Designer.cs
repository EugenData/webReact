﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200707220516_MeetingsAdded")]
    partial class MeetingsAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("Domain.Meeting", b =>
                {
                    b.Property<Guid>("MeetingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT").HasMaxLength(256);

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT").HasMaxLength(256);

                    b.Property<Guid>("PatientId")
                        .HasColumnType("TEXT").HasMaxLength(256);

                    b.Property<string>("Titel")
                        .HasColumnType("TEXT").HasMaxLength(256);

                    b.Property<bool>("isDone")
                        .HasColumnType("INTEGER");

                    b.HasKey("MeetingId");

                    b.HasIndex("PatientId");

                    b.ToTable("Meetings");
                });

            modelBuilder.Entity("Domain.Patient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT").HasMaxLength(256);

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT").HasMaxLength(256);

                    b.Property<string>("Patient_name")
                        .HasColumnType("TEXT").HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("Domain.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT").HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("Values");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "value1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "value2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "value3"
                        });
                });

            modelBuilder.Entity("Domain.Meeting", b =>
                {
                    b.HasOne("Domain.Patient", "Patient")
                        .WithMany("Meetings")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
