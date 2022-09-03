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
        relacion entre las clases Trabajador, Supervisor y Administrador 
        accedo a los atributos de la clase dependiente
        *****************************************************/
        public Trabajador idTrabajador { get; set; }
        public Supervisor idSupervisor { get; set; }
        public Administracion idAdministrador { get; set; }
    }
}