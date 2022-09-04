﻿// <auto-generated />
using System;
using AccrontolWeb.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AccrontolWeb.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20220904001901_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AccrontolWeb.App.Dominio.Administracion", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("descripcionAdm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("idTrabajadorAdmid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("idTrabajadorAdmid");

                    b.ToTable("Administracion");
                });

            modelBuilder.Entity("AccrontolWeb.App.Dominio.Area", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("area")
                        .HasColumnType("int");

                    b.Property<string>("descripcionArea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Area");
                });

            modelBuilder.Entity("AccrontolWeb.App.Dominio.Empresa", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("nit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("AccrontolWeb.App.Dominio.RegistroHora", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("descripcionHh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fecha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("horaFinal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("horaInicio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("idTrabajadorid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("idTrabajadorid");

                    b.ToTable("RegistroHora");
                });

            modelBuilder.Entity("AccrontolWeb.App.Dominio.Sede", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ciudad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("idEmpresaid")
                        .HasColumnType("int");

                    b.Property<string>("nombreSede")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("idEmpresaid");

                    b.ToTable("Sede");
                });

            modelBuilder.Entity("AccrontolWeb.App.Dominio.SuperAdminTrabajador", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("idAdministradorid")
                        .HasColumnType("int");

                    b.Property<int?>("idSupervisorid")
                        .HasColumnType("int");

                    b.Property<int?>("idTrabajadorid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("idAdministradorid");

                    b.HasIndex("idSupervisorid");

                    b.HasIndex("idTrabajadorid");

                    b.ToTable("SuperAdminTrabajador");
                });

            modelBuilder.Entity("AccrontolWeb.App.Dominio.Supervisor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("IdTrabajadorSprid")
                        .HasColumnType("int");

                    b.Property<string>("descripcionSpr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("IdTrabajadorSprid");

                    b.ToTable("Supervisor");
                });

            modelBuilder.Entity("AccrontolWeb.App.Dominio.Trabajador", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("active")
                        .HasColumnType("int");

                    b.Property<int?>("idAreaid")
                        .HasColumnType("int");

                    b.Property<int?>("idSedeid")
                        .HasColumnType("int");

                    b.Property<string>("identificacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("idAreaid");

                    b.HasIndex("idSedeid");

                    b.ToTable("Trabajador");
                });

            modelBuilder.Entity("AccrontolWeb.App.Dominio.Administracion", b =>
                {
                    b.HasOne("AccrontolWeb.App.Dominio.Trabajador", "idTrabajadorAdm")
                        .WithMany()
                        .HasForeignKey("idTrabajadorAdmid");

                    b.Navigation("idTrabajadorAdm");
                });

            modelBuilder.Entity("AccrontolWeb.App.Dominio.RegistroHora", b =>
                {
                    b.HasOne("AccrontolWeb.App.Dominio.Trabajador", "idTrabajador")
                        .WithMany()
                        .HasForeignKey("idTrabajadorid");

                    b.Navigation("idTrabajador");
                });

            modelBuilder.Entity("AccrontolWeb.App.Dominio.Sede", b =>
                {
                    b.HasOne("AccrontolWeb.App.Dominio.Empresa", "idEmpresa")
                        .WithMany()
                        .HasForeignKey("idEmpresaid");

                    b.Navigation("idEmpresa");
                });

            modelBuilder.Entity("AccrontolWeb.App.Dominio.SuperAdminTrabajador", b =>
                {
                    b.HasOne("AccrontolWeb.App.Dominio.Administracion", "idAdministrador")
                        .WithMany()
                        .HasForeignKey("idAdministradorid");

                    b.HasOne("AccrontolWeb.App.Dominio.Supervisor", "idSupervisor")
                        .WithMany()
                        .HasForeignKey("idSupervisorid");

                    b.HasOne("AccrontolWeb.App.Dominio.Trabajador", "idTrabajador")
                        .WithMany()
                        .HasForeignKey("idTrabajadorid");

                    b.Navigation("idAdministrador");

                    b.Navigation("idSupervisor");

                    b.Navigation("idTrabajador");
                });

            modelBuilder.Entity("AccrontolWeb.App.Dominio.Supervisor", b =>
                {
                    b.HasOne("AccrontolWeb.App.Dominio.Trabajador", "IdTrabajadorSpr")
                        .WithMany()
                        .HasForeignKey("IdTrabajadorSprid");

                    b.Navigation("IdTrabajadorSpr");
                });

            modelBuilder.Entity("AccrontolWeb.App.Dominio.Trabajador", b =>
                {
                    b.HasOne("AccrontolWeb.App.Dominio.Area", "idArea")
                        .WithMany()
                        .HasForeignKey("idAreaid");

                    b.HasOne("AccrontolWeb.App.Dominio.Sede", "idSede")
                        .WithMany()
                        .HasForeignKey("idSedeid");

                    b.Navigation("idArea");

                    b.Navigation("idSede");
                });
#pragma warning restore 612, 618
        }
    }
}
