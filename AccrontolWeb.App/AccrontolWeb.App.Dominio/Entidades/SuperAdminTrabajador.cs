/*****************************************************
Importar clases
*****************************************************/
using System;

/*****************************************************
namespace agrupa los atributos de la clase para identificarlos,
otra clase puede trener el mismo nombre para un atributo, pero la logica es diferente
*****************************************************/
namespace AccrontolWeb.App.Dominio
{
    /*****************************************************
    crear clases
    los atributos de la clase tiene los getter y setter en {}
    *****************************************************/
    public class SuperAdminTrabajador{

        public int id { get; set; }

        /*****************************************************
        foreaneas
        *****************************************************/
        public int Trabajadorid { get; set; }
        public int? Supervisorid { get; set; }
        public int? Administracionid { get; set; }

        /*****************************************************
        relacion entre las clases Trabajador, Supervisor y Administrador 
        accedo a los atributos de la clase dependiente
        *****************************************************/
        public Trabajador Trabajador { get; set; }
        public Supervisor Supervisor { get; set; }
        public Administracion Administracion { get; set; }
        
    }
}