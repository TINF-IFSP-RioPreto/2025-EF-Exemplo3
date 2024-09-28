﻿// <auto-generated />
using EF.Exemplo3;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EF.Exemplo3.Migrations
{
    [DbContext(typeof(ProdutoDbContext))]
    partial class ProdutoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EF.Exemplo3.Produto", b =>
                {
                    b.Property<int>("ProdutoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ProdutoID"));

                    b.Property<bool>("ProdutoAtivo")
                        .HasColumnType("boolean");

                    b.Property<int>("ProdutoEstoque")
                        .HasColumnType("integer");

                    b.Property<string>("ProdutoNome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("ProdutoPreco")
                        .HasColumnType("numeric");

                    b.HasKey("ProdutoID");

                    b.ToTable("tblProdutos");
                });
#pragma warning restore 612, 618
        }
    }
}
