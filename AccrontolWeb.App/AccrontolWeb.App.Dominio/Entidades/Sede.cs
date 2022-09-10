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
    public class Sede
    {
        /*****************************************************
        crear clases
        los atributos de la clase tiene los getter y setter en {}
        *****************************************************/
        public int id { get; set; }
        public string ciudad { get; set; }
        public string nombreSede { get; set; }
        public string direccion { get; set; }
        public string telefono{ get; set; }
        public int Empresaid { get; set; }//foranea

        /*****************************************************
        relacion entre las clases Sede y Empresa
        accedo a los atributos de la clase dependiente
        *****************************************************/
        public Empresa Empresa { get; set; }
        
    }
}