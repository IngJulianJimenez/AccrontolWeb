/*****************************************************
Importar clases
*****************************************************/
using System;
using AccrontolWeb.App.Dominio;
using Microsoft.EntityFrameworkCore;

/*****************************************************
namespace agrupa los atributos de la clase para identificarlos,
otra clase puede trener el mismo nombre para un atributo, pero la logica es diferente
*****************************************************/
namespace AccrontolWeb.App.Persistencia{
    /*****************************************************
    El AppContext conecta las relaciona el Dominio con la BD
    
    los atributos de la clase tiene los getter y setter en {}
    con los : aplico herencia >> AppContext : DbContext (AppContext hereda de DbContext)
    DbSet <NombreClase> EquivalenciaTablaBd
    
    Crear una Interface por cada clase del dominio
    instanciar cada interface con una clase

    en las en las interfaces se crean las acciones CRUD
    en las clases se ejecutan
    *****************************************************/
    public class AppContext : DbContext{
        public DbSet<Area> Area { get; set; }
        public DbSet<Trabajador> Trabajador { get; set; }
        public DbSet<Supervisor> Supervisor { get; set; }
        public DbSet<Administracion> Administracion { get; set; }
        public DbSet<RegistroHora> RegistroHora { get; set; }
        public DbSet<Sede> Sede { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<SuperAdminTrabajador> SuperAdminTrabajador { get; set; }

        /*****************************************************
        conexion BD
        overrride == sobre escribir
        *****************************************************/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if (!optionsBuilder.IsConfigured){
                optionsBuilder
                .UseSqlServer("Server=DESKTOP-J4MCPL0; Database=BD_Proyecto;User ID=mintic_8;Password=mintic_8;");
            }
        }
    }
}