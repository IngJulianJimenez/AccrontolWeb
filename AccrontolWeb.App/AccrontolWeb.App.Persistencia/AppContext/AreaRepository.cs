/*****************************************************
Importar clases
*****************************************************/
using System;
using AccrontolWeb.App.Dominio;

/*****************************************************
namespace agrupa los atributos de la clase para identificarlos,
otra clase puede trener el mismo nombre para un atributo, pero la logica es diferente
*****************************************************/
namespace AccrontolWeb.App.Persistencia{
    //con los : implemeto una clase >> AreaRepository : IAreaRepository (AreaRepository implementa de IAreaRepository)
    public class AreaRepository : IAreaRepository{

        /*****************************************************
        El contexto me permite la comuniocan con la BD
        acceder al AppContext.cs en modo lectura
        en el AppContext.cs se instancian las clases del proyecto Dominio (las clases de la BD), para hacer el CRUD
        *****************************************************/
        private readonly AppContext _appContext;

        /*****************************************************
        Constructor:
        NombreClase (TipoDato NombreObjeto)
        TipoDato = a una clase en este caso es el Contexto que hace puento con el Dominio
        NombreObjeto = objeto(variable) del TipoDato
        *****************************************************/
        public AreaRepository(AppContext context){ //(clase NombreObjeto) 
            _appContext = context;
        }

        /*****************************************************
        metodos crud hacia la BD 
        en la interface IAreaRepository.cs se escriben las acciones o contratos
        en la calse AreaRepository.cs se ejecutan las acciones

        valorRetorno nombreIntertface.metodoCRUD (ClaseDominio NombreObjeto){} 

        ClaseDominio = a una clase del dominio en este caso son tablas
        por ende trae todos sus atributos 
        NombreObjeto = objeto(variable) del ClaseDominio

        nombreIntertface = nombreIntertface a implementar
        metodoCRUD = metodo definido en la interface

        posterior al punto del _appContext. se listan las clases (del Dominio) que se definieron en AppContex.cs
        
        Para ejecutar de forma manual, generar el codigo desde el proyecto Consola (Program.cs)
        *****************************************************/

        int IAreaRepository.Add (Area area){ //insertar en una tabla
            var TablaArea = _appContext.Area.Add(area);
            var result = _appContext.SaveChanges();
            return result;
        } 
    }
}