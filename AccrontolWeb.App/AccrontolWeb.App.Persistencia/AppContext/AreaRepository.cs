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
        
        //acceder al AppContext.cs en modo lectura
        //en el AppContext.cs se instancian las clases del proyecto Dominio (las clases de la BD), para hacer el CRUD
        private readonly AppContext _appContext;

        //constructor
        public AreaRepository(AppContext context){ //(clase NombreObjeto) 
            _appContext = context;
        }

        /*****************************************************
        metodos crud hacia la BD 
        en la interface IAreaRepository.cs se escriben las acciones o contratos
        en la calse AreaRepository.cs se ejecutan las acciones

        valorRetorno nombreIntertface.metodoCRUD (clase NombreObjeto){} 
        posterior al punto del _appContext. se listan las clases (del Dominio) que se definieron en AppContex.cs
        *****************************************************/

        int IAreaRepository.Add (Area area){ //insertar en una tabla
            var TablaArea = _appContext.Area.Add(area);
            var result = _appContext.SaveChanges();
            return result;
        } 
    }
}