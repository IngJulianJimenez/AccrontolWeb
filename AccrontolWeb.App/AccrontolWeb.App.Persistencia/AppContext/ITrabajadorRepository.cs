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
    public interface ITrabajadorRepository
    {
        //agregar
        int Add(Trabajador empleado);
                
        //listar primer metodo, trae todo
        List<Trabajador> ObtenerTodoTrabajador();

        //listar
        List<Trabajador> ObtebnerTrabajadorDos(string documento);

        //buscar por Id
        Trabajador BuscadorTrabajadorId(int id);

        //Actulizar, retorna un entero con el numero de registros afectados
        int ActulizarTrabajador(Trabajador empleado);


    }
}