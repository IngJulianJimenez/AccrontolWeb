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
    public class Empresa
    {
        public int id { get; set; }
        public string nit { get; set; }
        public string nombre { get; set; }
    }
}