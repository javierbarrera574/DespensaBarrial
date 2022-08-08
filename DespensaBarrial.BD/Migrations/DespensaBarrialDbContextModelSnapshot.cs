﻿// <auto-generated />
using System;
using DespensaBarrial.BD.Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DespensaBarrial.BD.Migrations
{
    [DbContext(typeof(DespensaBarrialDbContext))]
    partial class DespensaBarrialDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DespensaBarrial.BD.Datos.Entidades.Categorias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("NumeroDeCategoria")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductosId")
                        .HasColumnType("int");

                    b.Property<int>("ProveedorId")
                        .HasColumnType("int");

                    b.Property<int?>("ProveedoresId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductosId");

                    b.HasIndex("ProveedoresId");

                    b.HasIndex(new[] { "ProductoId" }, "Categoria_Producto_Proveedor:1234")
                        .IsUnique();

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("DespensaBarrial.BD.Datos.Entidades.Productos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaveProducto")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("DescripcionProducto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaVencimientoProducto")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreProducto")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("PrecioProducto")
                        .HasPrecision(14, 2)
                        .HasColumnType("decimal(14,2)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "NombreProducto" }, "Producto: Dragon Ball Z")
                        .IsUnique();

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("DespensaBarrial.BD.Datos.Entidades.Proveedores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CorreoElectronico")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("DNI")
                        .HasMaxLength(8)
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaNacimiento")
                        .HasColumnType("Date");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroTelefono")
                        .HasMaxLength(8)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "DNI" }, "Proveedor: 34902124")
                        .IsUnique();

                    b.ToTable("Proveedores");
                });

            modelBuilder.Entity("DespensaBarrial.BD.Datos.Entidades.Categorias", b =>
                {
                    b.HasOne("DespensaBarrial.BD.Datos.Entidades.Productos", "Productos")
                        .WithMany("categorias")
                        .HasForeignKey("ProductosId");

                    b.HasOne("DespensaBarrial.BD.Datos.Entidades.Proveedores", "Proveedores")
                        .WithMany("categorias")
                        .HasForeignKey("ProveedoresId");

                    b.Navigation("Productos");

                    b.Navigation("Proveedores");
                });

            modelBuilder.Entity("DespensaBarrial.BD.Datos.Entidades.Productos", b =>
                {
                    b.Navigation("categorias");
                });

            modelBuilder.Entity("DespensaBarrial.BD.Datos.Entidades.Proveedores", b =>
                {
                    b.Navigation("categorias");
                });
#pragma warning restore 612, 618
        }
    }
}
