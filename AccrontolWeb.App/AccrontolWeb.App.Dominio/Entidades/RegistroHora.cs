/*****************************************************
Importar clases
*****************************************************/
using System;

/*****************************************************
namespace agrupa los atributos de la clase para identificarlos
otra clase puede tener el mismo nombre para un atributo, pero diferente logica
*****************************************************/
namespace AccrontolWeb.App.Dominio
{
    /*****************************************************
    crear clases
    los atributos de la clase tiene los getter y setter en {}
    *****************************************************/
    public class RegistroHora
    {
        public int id { get; set; }
        public string horaInicio { get; set; }
        public string horaFinal { get; set; }
        public string fecha { get; set; }
        public string descripcion { get; set; }

        /*****************************************************
        relacion entre las clases RegistroHora y Trabajador
        accedo a los atributos de la clase dependiente
        *****************************************************/
        public Trabajador idTrabajador { get; set; }
        
        
    }
}