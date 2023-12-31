﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NutriPlanApi.Data;

#nullable disable

namespace NutriPlanApi.Migrations
{
    [DbContext(typeof(NutriPlanContext))]
    partial class NutriPlanContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("NutriPlanApi.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("UsuarioEmail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UsuarioNome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UsuarioSenha")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UsuarioTelefone")
                        .HasColumnType("longtext");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
