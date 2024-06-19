﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(TUContext))]
    [Migration("20240619102013_Update")]
    partial class Update
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.Domain.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Core.Domain.ClientClick", b =>
                {
                    b.Property<int>("ClientClickId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientClickId"));

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("CompteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("date_dernier_cnx")
                        .HasColumnType("datetime");

                    b.HasKey("ClientClickId");

                    b.HasIndex("ClientId");

                    b.HasIndex("CompteId");

                    b.ToTable("ClientClick");
                });

            modelBuilder.Entity("Core.Domain.Compte", b =>
                {
                    b.Property<int>("CompteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompteId"));

                    b.Property<int>("ClientFk")
                        .HasColumnType("int");

                    b.Property<DateTime>("date_dernier_cnx")
                        .HasColumnType("datetime");

                    b.Property<string>("lien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompteId");

                    b.HasIndex("ClientFk");

                    b.ToTable("Comptes");
                });

            modelBuilder.Entity("Core.Domain.ClientClick", b =>
                {
                    b.HasOne("Core.Domain.Client", "Client")
                        .WithMany("ClientClicks")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Core.Domain.Compte", "Compte")
                        .WithMany("ClientClicks")
                        .HasForeignKey("CompteId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Compte");
                });

            modelBuilder.Entity("Core.Domain.Compte", b =>
                {
                    b.HasOne("Core.Domain.Client", "Client")
                        .WithMany("Comptes")
                        .HasForeignKey("ClientFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Core.Domain.Client", b =>
                {
                    b.Navigation("ClientClicks");

                    b.Navigation("Comptes");
                });

            modelBuilder.Entity("Core.Domain.Compte", b =>
                {
                    b.Navigation("ClientClicks");
                });
#pragma warning restore 612, 618
        }
    }
}
