﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ONGWebAPI.Repository.EntityRepository;

#nullable disable

namespace ONGWebAPI.Migrations
{
    [DbContext(typeof(ONGContext))]
    [Migration("20220817021942_OitavaAtualizacao")]
    partial class OitavaAtualizacao
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ONGWebAPI.Models.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool?>("Castrado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("Deficiencia")
                        .HasColumnType("bit");

                    b.Property<bool>("Disponibilidade")
                        .HasColumnType("bit");

                    b.Property<string>("Especie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Idade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Localizacao")
                        .HasColumnType("int");

                    b.Property<bool?>("Microchip")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Porte")
                        .HasColumnType("int");

                    b.Property<int?>("RegistroAdocaoId")
                        .HasColumnType("int");

                    b.Property<int?>("RegistroDoacaoId")
                        .HasColumnType("int");

                    b.Property<int>("Sexo")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<string>("Vacinas")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RegistroAdocaoId");

                    b.HasIndex("RegistroDoacaoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Animais");
                });

            modelBuilder.Entity("ONGWebAPI.Models.InteresseAdocao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AnimalId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.ToTable("InteresseAdocao");
                });

            modelBuilder.Entity("ONGWebAPI.Models.RegistroAdocao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("RegistroAdocao");
                });

            modelBuilder.Entity("ONGWebAPI.Models.RegistroDoacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("RegistroDoacao");
                });

            modelBuilder.Entity("ONGWebAPI.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Localizacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ONGWebAPI.Models.Animal", b =>
                {
                    b.HasOne("ONGWebAPI.Models.RegistroAdocao", null)
                        .WithMany("Animais")
                        .HasForeignKey("RegistroAdocaoId");

                    b.HasOne("ONGWebAPI.Models.RegistroDoacao", null)
                        .WithMany("Animais")
                        .HasForeignKey("RegistroDoacaoId");

                    b.HasOne("ONGWebAPI.Models.Usuario", "Usuario")
                        .WithMany("Animais")
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ONGWebAPI.Models.InteresseAdocao", b =>
                {
                    b.HasOne("ONGWebAPI.Models.Animal", "Animal")
                        .WithMany()
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");
                });

            modelBuilder.Entity("ONGWebAPI.Models.RegistroAdocao", b =>
                {
                    b.Navigation("Animais");
                });

            modelBuilder.Entity("ONGWebAPI.Models.RegistroDoacao", b =>
                {
                    b.Navigation("Animais");
                });

            modelBuilder.Entity("ONGWebAPI.Models.Usuario", b =>
                {
                    b.Navigation("Animais");
                });
#pragma warning restore 612, 618
        }
    }
}
