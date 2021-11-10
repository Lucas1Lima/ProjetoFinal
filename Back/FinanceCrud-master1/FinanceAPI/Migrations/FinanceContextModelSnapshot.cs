﻿// <auto-generated />
using System;
using FinanceAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinanceAPI.Migrations
{
    [DbContext(typeof(FinanceContext))]
    partial class FinanceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FinanceAPI.Models.Caixa", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("SaldoAtual")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("Caixas");
                });

            modelBuilder.Entity("FinanceAPI.Models.Extrato", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Entrada")
                        .HasColumnType("bit");

                    b.Property<string>("Parcela")
                        .IsRequired()
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("Valor")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("ID");

                    b.ToTable("Extratos");
                });
#pragma warning restore 612, 618
        }
    }
}
