﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Semana13.Data;

#nullable disable

namespace Semana_13.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("Semana13.Models.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.Property<string>("Endereco")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("TEXT");

                    b.HasKey("IdCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Semana13.Models.ItemPedido", b =>
                {
                    b.Property<int>("IdPedido")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdProduto")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantidade")
                        .HasColumnType("INTEGER");

                    b.Property<double>("ValorUnitario")
                        .HasColumnType("REAL");

                    b.HasKey("IdPedido", "IdProduto");

                    b.HasIndex("IdProduto");

                    b.ToTable("ItensPedido");
                });

            modelBuilder.Entity("Semana13.Models.Pedido", b =>
                {
                    b.Property<int>("IdPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataHora")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdCliente")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdPedido");

                    b.HasIndex("IdCliente");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("Semana13.Models.Produto", b =>
                {
                    b.Property<int>("IdProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Estoque")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.Property<double>("Preco")
                        .HasColumnType("REAL");

                    b.HasKey("IdProduto");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Semana13.Models.ItemPedido", b =>
                {
                    b.HasOne("Semana13.Models.Pedido", "Pedido")
                        .WithMany("Itens")
                        .HasForeignKey("IdPedido")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Semana13.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("IdProduto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Semana13.Models.Pedido", b =>
                {
                    b.HasOne("Semana13.Models.Cliente", "Cliente")
                        .WithMany("Pedidos")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Semana13.Models.Cliente", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("Semana13.Models.Pedido", b =>
                {
                    b.Navigation("Itens");
                });
#pragma warning restore 612, 618
        }
    }
}