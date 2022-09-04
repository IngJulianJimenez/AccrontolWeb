/*****************************************************
Importar clases
*****************************************************/
using System;
using AccrontolWeb.App.Dominio;
using System.Collections.Generic;
using System.Linq;


/*****************************************************
namespace agrupa los atributos de la clase para identificarlos,
otra clase puede trener el mismo nombre para un atributo, pero la logica es diferente
*****************************************************/
namespace AccrontolWeb.App.Persistencia
{
    /*****************************************************
    metodos crud
    NombreClase metodoCRUD (TipoDato NombreObjeto)
    TipoDato = a una clase del dominio en este caso son tablas
    por ende trae todos sus atributos 
    NombreObjeto = objeto(variable) del TipoDato

    en la interface crear las acciones CrUd
    *****************************************************/
    public interface IAreaRepository{

        //agregar
        int Add(Area area); 
      
        //listar primer metodo
        IEnumerable<Area> ObtebnerArea();

        //listar segundo metodo, con parametro de busqueda
        List<Area> ObtebnerAreaDos(string busqueda1);

        //listar tercer metodo, coincidir caracteres
        List<Area> ObtebnerAreaTres(string busqueda3);

        //buscador, se usa  para varias columnas, con la ayuda del || 0 &&, con el mimso tipo de valor preferiblemente String, int 
        IEnumerable<Area> BuscadorArea(string buesqueda4);

        //buscar por Id
        Area BuscadorAreaId(int id);

        //Actulizar, retorna un entero con el numero de registros afectados
        int ActulizarArea (Area area);

        //Eliminar, retorna un entero con el numero de registros afectados
        int EliminarArea (Area area);
    }
}