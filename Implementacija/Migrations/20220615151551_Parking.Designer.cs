﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projekat___Parking.Data;

#nullable disable

namespace Projekat___Parking.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220615151551_Parking")]
    partial class Parking
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Projekat___Parking.Models.BankovniRacun", b =>
                {
                    b.Property<int>("brojRacuna")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("brojRacuna"), 1L, 1);

                    b.Property<int>("jmbgVlasnikaRacuna")
                        .HasColumnType("int");

                    b.Property<double>("raspolozivaSredstva")
                        .HasColumnType("float");

                    b.HasKey("brojRacuna");

                    b.ToTable("BankovniRacun", (string)null);
                });

            modelBuilder.Entity("Projekat___Parking.Models.Grad", b =>
                {
                    b.Property<int>("postanskiBroj")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("postanskiBroj"), 1L, 1);

                    b.Property<int>("brojStanovnika")
                        .HasColumnType("int");

                    b.Property<string>("imeGrada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("postanskiBroj");

                    b.ToTable("Grad", (string)null);
                });

            modelBuilder.Entity("Projekat___Parking.Models.Osoba", b =>
                {
                    b.Property<string>("jmbg")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("jmbg");

                    b.ToTable("Osoba", (string)null);
                });

            modelBuilder.Entity("Projekat___Parking.Models.Parking", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("Grad")
                        .HasColumnType("int");

                    b.Property<string>("Vlasnik")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("brojRezervisanihMjesta")
                        .HasColumnType("int");

                    b.Property<int>("brojZauzetihMjesta")
                        .HasColumnType("int");

                    b.Property<double>("cijenaParkinga")
                        .HasColumnType("float");

                    b.Property<int>("kapacitetParkinga")
                        .HasColumnType("int");

                    b.Property<string>("nazivParkinga")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Grad");

                    b.HasIndex("Vlasnik");

                    b.ToTable("Parking", (string)null);
                });

            modelBuilder.Entity("Projekat___Parking.Models.Vozilo", b =>
                {
                    b.Property<string>("tabliceVozila")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("tipVozila")
                        .HasColumnType("int");

                    b.HasKey("tabliceVozila");

                    b.ToTable("Vozilo", (string)null);
                });

            modelBuilder.Entity("Projekat___Parking.Models.Korisnik", b =>
                {
                    b.HasBaseType("Projekat___Parking.Models.Osoba");

                    b.Property<int>("racunbrojRacuna")
                        .HasColumnType("int");

                    b.Property<string>("vozilotabliceVozila")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasIndex("racunbrojRacuna");

                    b.HasIndex("vozilotabliceVozila");

                    b.ToTable("Korisnik", (string)null);
                });

            modelBuilder.Entity("Projekat___Parking.Models.Radnik", b =>
                {
                    b.HasBaseType("Projekat___Parking.Models.Osoba");

                    b.Property<int>("Parking")
                        .HasColumnType("int");

                    b.HasIndex("Parking");

                    b.ToTable("Radnik", (string)null);
                });

            modelBuilder.Entity("Projekat___Parking.Models.Vlasnik", b =>
                {
                    b.HasBaseType("Projekat___Parking.Models.Osoba");

                    b.Property<int>("Parking")
                        .HasColumnType("int");

                    b.HasIndex("Parking");

                    b.ToTable("Vlasnik", (string)null);
                });

            modelBuilder.Entity("Projekat___Parking.Models.VIPKorisnik", b =>
                {
                    b.HasBaseType("Projekat___Parking.Models.Korisnik");

                    b.Property<int>("Parking")
                        .HasColumnType("int");

                    b.HasIndex("Parking");

                    b.ToTable("VIPKorisnik", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Projekat___Parking.Models.Parking", b =>
                {
                    b.HasOne("Projekat___Parking.Models.Grad", "grad")
                        .WithMany()
                        .HasForeignKey("Grad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projekat___Parking.Models.Vlasnik", "vlasnik")
                        .WithMany()
                        .HasForeignKey("Vlasnik");

                    b.Navigation("grad");

                    b.Navigation("vlasnik");
                });

            modelBuilder.Entity("Projekat___Parking.Models.Korisnik", b =>
                {
                    b.HasOne("Projekat___Parking.Models.Osoba", null)
                        .WithOne()
                        .HasForeignKey("Projekat___Parking.Models.Korisnik", "jmbg")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("Projekat___Parking.Models.BankovniRacun", "racun")
                        .WithMany()
                        .HasForeignKey("racunbrojRacuna")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projekat___Parking.Models.Vozilo", "vozilo")
                        .WithMany()
                        .HasForeignKey("vozilotabliceVozila")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("racun");

                    b.Navigation("vozilo");
                });

            modelBuilder.Entity("Projekat___Parking.Models.Radnik", b =>
                {
                    b.HasOne("Projekat___Parking.Models.Parking", "parking")
                        .WithMany()
                        .HasForeignKey("Parking")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projekat___Parking.Models.Osoba", null)
                        .WithOne()
                        .HasForeignKey("Projekat___Parking.Models.Radnik", "jmbg")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("parking");
                });

            modelBuilder.Entity("Projekat___Parking.Models.Vlasnik", b =>
                {
                    b.HasOne("Projekat___Parking.Models.Parking", "parking")
                        .WithMany()
                        .HasForeignKey("Parking")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projekat___Parking.Models.Osoba", null)
                        .WithOne()
                        .HasForeignKey("Projekat___Parking.Models.Vlasnik", "jmbg")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("parking");
                });

            modelBuilder.Entity("Projekat___Parking.Models.VIPKorisnik", b =>
                {
                    b.HasOne("Projekat___Parking.Models.Parking", "parkingVip")
                        .WithMany()
                        .HasForeignKey("Parking")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projekat___Parking.Models.Korisnik", null)
                        .WithOne()
                        .HasForeignKey("Projekat___Parking.Models.VIPKorisnik", "jmbg")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("parkingVip");
                });
#pragma warning restore 612, 618
        }
    }
}