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
    con los : aplico herencia >> Administracion : Trabajador (Administracion hereda de Trabajador)
    no se aplica herencia
    *****************************************************/
    public class Administracion
    {
        public int id { get; set; }
        public Trabajador idTrabajadorAdm { get; set; }
        public string descripcionAdm { get; set; }
        
    }
}