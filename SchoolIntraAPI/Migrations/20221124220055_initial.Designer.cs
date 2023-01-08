﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolIntraAPI.Data;

#nullable disable

namespace SchoolIntraAPI.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    [Migration("20221124220055_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("School_Intra_PupilContacts", b =>
                {
                    b.Property<Guid>("ContactPersonsId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("PupilsId")
                        .HasColumnType("char(36)");

                    b.HasKey("ContactPersonsId", "PupilsId");

                    b.HasIndex("PupilsId");

                    b.ToTable("School_Intra_PupilContacts");
                });

            modelBuilder.Entity("SchoolIntraAPI.Data.ContactPerson", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Firstnames")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("School_Intra_ContactPersons");
                });

            modelBuilder.Entity("SchoolIntraAPI.Data.Pupil", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ClassId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Firstnames")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.ToTable("School_Intra_Pupils");
                });

            modelBuilder.Entity("SchoolIntraAPI.Data.SchoolClass", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.ToTable("School_Intra_SchoolClasses");
                });

            modelBuilder.Entity("School_Intra_PupilContacts", b =>
                {
                    b.HasOne("SchoolIntraAPI.Data.ContactPerson", null)
                        .WithMany()
                        .HasForeignKey("ContactPersonsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolIntraAPI.Data.Pupil", null)
                        .WithMany()
                        .HasForeignKey("PupilsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SchoolIntraAPI.Data.Pupil", b =>
                {
                    b.HasOne("SchoolIntraAPI.Data.SchoolClass", "Class")
                        .WithMany("Pupils")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");
                });

            modelBuilder.Entity("SchoolIntraAPI.Data.SchoolClass", b =>
                {
                    b.Navigation("Pupils");
                });
#pragma warning restore 612, 618
        }
    }
}
