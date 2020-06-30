﻿// <auto-generated />
using System;
using CaStreetStyle.CaStreetStyleDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CaStreetStyle.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5");

            modelBuilder.Entity("CaStreetStyle.Models.Articulo", b =>
                {
                    b.Property<int>("ArticuloId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Ganancia")
                        .HasColumnType("REAL");

                    b.Property<int?>("MonedaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<double>("Precio")
                        .HasColumnType("REAL");

                    b.HasKey("ArticuloId");

                    b.HasIndex("MonedaId");

                    b.ToTable("Articulos");
                });

            modelBuilder.Entity("CaStreetStyle.Models.Moneda", b =>
                {
                    b.Property<int>("MonedaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("ValorMonetario")
                        .HasColumnType("REAL");

                    b.HasKey("MonedaId");

                    b.ToTable("Monedas");
                });

            modelBuilder.Entity("CaStreetStyle.Models.Articulo", b =>
                {
                    b.HasOne("CaStreetStyle.Models.Moneda", "Moneda")
                        .WithMany()
                        .HasForeignKey("MonedaId");
                });
#pragma warning restore 612, 618
        }
    }
}
