﻿// <auto-generated />
using System;
using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(AppDataContext))]
    partial class AppDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("API.Models.Produto", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantidade")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Valor")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}

/*
dotnet tool install --global dotnet ef  //instalar globalmente
dotnet ef migrations add VersaoInicial... // adiciona uma migracao ao prpjeto
dotnet ef database update // atualiza a migracao
dotnet ef migrations remove // remove a migracao
*/

