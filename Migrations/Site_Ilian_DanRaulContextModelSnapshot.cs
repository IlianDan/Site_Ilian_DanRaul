﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Site_Ilian_DanRaul.Data;

#nullable disable

namespace Site_Ilian_DanRaul.Migrations
{
    [DbContext(typeof(Site_Ilian_DanRaulContext))]
    partial class Site_Ilian_DanRaulContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Site_Ilian_DanRaul.Models.ListaAnimecs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DataFinal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInceput")
                        .HasColumnType("datetime2");

                    b.Property<int?>("NotaID")
                        .HasColumnType("int");

                    b.Property<int?>("StatutID")
                        .HasColumnType("int");

                    b.Property<int?>("TitluID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NotaID");

                    b.HasIndex("StatutID");

                    b.HasIndex("TitluID");

                    b.ToTable("ListaAnimecs");
                });

            modelBuilder.Entity("Site_Ilian_DanRaul.Models.Nota", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("NotaAnime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Nota");
                });

            modelBuilder.Entity("Site_Ilian_DanRaul.Models.Statut", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Stare")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("Site_Ilian_DanRaul.Models.Titlu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("TitluAnime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Titlu");
                });

            modelBuilder.Entity("Site_Ilian_DanRaul.Models.ListaAnimecs", b =>
                {
                    b.HasOne("Site_Ilian_DanRaul.Models.Nota", "Nota")
                        .WithMany("ListeAninme")
                        .HasForeignKey("NotaID");

                    b.HasOne("Site_Ilian_DanRaul.Models.Statut", "Statut")
                        .WithMany("ListaAnimeuri")
                        .HasForeignKey("StatutID");

                    b.HasOne("Site_Ilian_DanRaul.Models.Titlu", "Titlu")
                        .WithMany("ListaAnimeuri")
                        .HasForeignKey("TitluID");

                    b.Navigation("Nota");

                    b.Navigation("Statut");

                    b.Navigation("Titlu");
                });

            modelBuilder.Entity("Site_Ilian_DanRaul.Models.Nota", b =>
                {
                    b.Navigation("ListeAninme");
                });

            modelBuilder.Entity("Site_Ilian_DanRaul.Models.Statut", b =>
                {
                    b.Navigation("ListaAnimeuri");
                });

            modelBuilder.Entity("Site_Ilian_DanRaul.Models.Titlu", b =>
                {
                    b.Navigation("ListaAnimeuri");
                });
#pragma warning restore 612, 618
        }
    }
}
