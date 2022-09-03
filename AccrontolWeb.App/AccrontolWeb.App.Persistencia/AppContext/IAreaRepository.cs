/*****************************************************
Importar clases
*****************************************************/
using System;
using AccrontolWeb.App.Dominio;

/*****************************************************
namespace agrupa los atributos de la clase para identificarlos,
otra clase puede trener el mismo nombre para un atributo, pero la logica es diferente
*****************************************************/
namespace AccrontolWeb.App.Persistencia
{
    /*****************************************************
    metodos crud
    NombreClase metodoCRUD (TipoDato NombreObjeto)

    se escriben los contratos
    *****************************************************/
    public interface IAreaRepository{
        //agregar
        int Add(Area area); 
    }
}