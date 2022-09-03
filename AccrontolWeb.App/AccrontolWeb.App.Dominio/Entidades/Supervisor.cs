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
    con los : aplico herencia >> Supervisor : Trabajador (Supervisor hereda de Trabajador)
    *****************************************************/
    public class Supervisor:Trabajador
    {
        public int id { get; set; }
        public string IdTrabajador { get; set; }
        public string Descripcion { get; set; }
    }
}