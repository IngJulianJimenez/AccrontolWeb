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
    //con los : implemeto una clase >> AreaRepository : ITrabajadorRepository (AreaRepository implementa de ITrabajadorRepository)
    public class TrabajadorRepository : ITrabajadorRepository
    {

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
        public TrabajadorRepository(AppContext context)
        { //(clase NombreObjeto) 
            _appContext = context;
        }

        /*****************************************************
        metodos crud hacia la BD 
        en la interface ITrabajadorRepository.cs se escriben las acciones o contratos
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
        //insertar en una tabla
        int ITrabajadorRepository.Add(Trabajador empleado)
        {
            var TablaTrabajador = _appContext.Trabajador.Add(empleado);
            var result = _appContext.SaveChanges();
            return result;
        }

        //listar primer metodo trae todo
        List<Trabajador> ITrabajadorRepository.ObtenerTodoTrabajador()
        {
            return _appContext.Trabajador.ToList();
        }

        //listar
        List<Trabajador> ITrabajadorRepository.ObtebnerTrabajadorDos(string documento)
        {
            return _appContext.Trabajador.Where(vr => vr.identificacion == documento).ToList();
            //_appContext.Area.Where(vr => vr.descripcionArea == busqueda1 && vr.area ==vr.busqueda2); 
        }

        //buscar por Id
        Trabajador ITrabajadorRepository.BuscadorTrabajadorId(int id)
        {
            return _appContext.Trabajador.Find(id);
        }

        //Actulizar, retorna un entero con el numero de registros afectados
        int ITrabajadorRepository.ActulizarTrabajador(Trabajador empleado)
        {
            _appContext.Trabajador.Update(empleado);
            return _appContext.SaveChanges();
        }
    }
}