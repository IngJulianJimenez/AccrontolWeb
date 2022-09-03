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
    public class Trabajador
    {
        public int id { get; set; }
        public string identificacion { get; set; }
        public string nombre { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }
        public int active { get; set; }

        /*****************************************************
        relacion entre las clases 
        accedo a los atributos de la clase dependiente
        *****************************************************/
        public Area idArea { get; set; }
        public Sede idSede { get; set; }
    }
}