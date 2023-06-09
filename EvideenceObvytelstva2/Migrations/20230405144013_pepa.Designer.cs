﻿// <auto-generated />
using System;
using EvideenceObvytelstva2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EvideenceObvytelstva2.Migrations
{
    [DbContext(typeof(ApplicationDB))]
    [Migration("20230405144013_pepa")]
    partial class pepa
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("EvideenceObvytelstva2.Models.Adresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Obec")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Ulice")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("cisloPopisne")
                        .HasColumnType("INTEGER");

                    b.Property<int>("psc")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Adresses");
                });

            modelBuilder.Entity("EvideenceObvytelstva2.Models.Osoba", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AddressId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("KrestniJmeno")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Prijmeni")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("StudentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TitulPred")
                        .HasColumnType("TEXT");

                    b.Property<string>("TitulZa")
                        .HasColumnType("TEXT");

                    b.Property<int>("Vek")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ZamestnanecId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("StudentId");

                    b.HasIndex("ZamestnanecId");

                    b.ToTable("Osobas");
                });

            modelBuilder.Entity("EvideenceObvytelstva2.Models.Skola", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AdresaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NazevSkoly")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Poznamka")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AdresaId");

                    b.ToTable("Skolas");
                });

            modelBuilder.Entity("EvideenceObvytelstva2.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("OborStudia")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Rocnik")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SkolaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SkolaId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EvideenceObvytelstva2.Models.Zamestnanec", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("Nastup")
                        .HasColumnType("TEXT");

                    b.Property<string>("Oddeleni")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ZamestnaniId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ZamestnaniId");

                    b.ToTable("Zamestnanecs");
                });

            modelBuilder.Entity("EvideenceObvytelstva2.Models.Zamestnani", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AdresaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NazevFirmy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Poznamka")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AdresaId");

                    b.ToTable("Zamestnanis");
                });

            modelBuilder.Entity("EvideenceObvytelstva2.Models.Osoba", b =>
                {
                    b.HasOne("EvideenceObvytelstva2.Models.Adresa", "Adresa")
                        .WithMany("Osobas")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("EvideenceObvytelstva2.Models.Student", "Student")
                        .WithMany("Osobas")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("EvideenceObvytelstva2.Models.Zamestnanec", "Zamestnanec")
                        .WithMany("Osobas")
                        .HasForeignKey("ZamestnanecId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Adresa");

                    b.Navigation("Student");

                    b.Navigation("Zamestnanec");
                });

            modelBuilder.Entity("EvideenceObvytelstva2.Models.Skola", b =>
                {
                    b.HasOne("EvideenceObvytelstva2.Models.Adresa", "Adresa")
                        .WithMany("Skolas")
                        .HasForeignKey("AdresaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Adresa");
                });

            modelBuilder.Entity("EvideenceObvytelstva2.Models.Student", b =>
                {
                    b.HasOne("EvideenceObvytelstva2.Models.Skola", "Skola")
                        .WithMany("Students")
                        .HasForeignKey("SkolaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Skola");
                });

            modelBuilder.Entity("EvideenceObvytelstva2.Models.Zamestnanec", b =>
                {
                    b.HasOne("EvideenceObvytelstva2.Models.Zamestnani", "Zamestnani")
                        .WithMany("Zamestnanecs")
                        .HasForeignKey("ZamestnaniId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Zamestnani");
                });

            modelBuilder.Entity("EvideenceObvytelstva2.Models.Zamestnani", b =>
                {
                    b.HasOne("EvideenceObvytelstva2.Models.Adresa", "Adresa")
                        .WithMany("Zamestnanis")
                        .HasForeignKey("AdresaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Adresa");
                });

            modelBuilder.Entity("EvideenceObvytelstva2.Models.Adresa", b =>
                {
                    b.Navigation("Osobas");

                    b.Navigation("Skolas");

                    b.Navigation("Zamestnanis");
                });

            modelBuilder.Entity("EvideenceObvytelstva2.Models.Skola", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("EvideenceObvytelstva2.Models.Student", b =>
                {
                    b.Navigation("Osobas");
                });

            modelBuilder.Entity("EvideenceObvytelstva2.Models.Zamestnanec", b =>
                {
                    b.Navigation("Osobas");
                });

            modelBuilder.Entity("EvideenceObvytelstva2.Models.Zamestnani", b =>
                {
                    b.Navigation("Zamestnanecs");
                });
#pragma warning restore 612, 618
        }
    }
}
