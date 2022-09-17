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
    no se aplica herencia
    *****************************************************/
    public class Supervisor
    {
        public int id { get; set; }
        public int Trabajadorid { get; set; }
        public string descripcionSpr { get; set; }

        /*****************************************************
        relacion entre las clases 
        accedo a los atributos de la clase dependiente
        *****************************************************/
        public Trabajador Trabajador { get; set; }
    }
}