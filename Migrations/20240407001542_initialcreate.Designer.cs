﻿// <auto-generated />
using Centralita1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Centralita.Migrations
{
    [DbContext(typeof(BloggingContext))]
    [Migration("20240407001542_initialcreate")]
    partial class initialcreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("Centralita1.Llamada", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("costollamada")
                        .HasColumnType("INTEGER");

                    b.Property<string>("destino")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("duracion")
                        .HasColumnType("INTEGER");

                    b.Property<string>("origen")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("llamadas");
                });
#pragma warning restore 612, 618
        }
    }
}
