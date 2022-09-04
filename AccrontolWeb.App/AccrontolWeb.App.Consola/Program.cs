/*****************************************************
Importar clases
*****************************************************/
using System;
using AccrontolWeb.App.Dominio;
using AccrontolWeb.App.Persistencia;


namespace Consola// Note: actual namespace depends on the project name.
{
    class Program
    {   
        //instanciar la interface del proyecto persistencia (para la Clase Dominio Area o Tabla Area)
        private static IAreaRepository _AreaRepository = new AreaRepository(new AccrontolWeb.App.Persistencia.AppContext());

        static void Main(string[] args)
        { 
            /*
            Console.WriteLine("Hacer primer insert BD");

            //crear una variable con los atributos de la clase Dominio
            var insertTablaArea = new Area
            {
                descripcionArea = "insert desde codigo",
                area = 2
            };

            //lanzar el query en BD
            var result = _AreaRepository.Add(insertTablaArea);
            if (result > 0)
            {
                Console.WriteLine("Insert exitoso");
            }
            else
            {
                Console.WriteLine("Ha ocurrido un problema");
            }
            */
            _AgregarArea();
            //_ObtebnerArea();
            //_ObtebnerAreaDos();
            //_ObtebnerAreaTres();
            //_BuscadorArea();
            //_BuscadorAreaId();
            //_ActulizarArea();
            //_EliminarArea();

        }

        /*****************************************************
        metodos para agregar registros en un tabla
        *****************************************************/

        public static void _AgregarArea(){
            var insertTablaArea = new Area{
                descripcionArea = "Agregar desde codigo",
                area = 2
            };
            var result = _AreaRepository.Add(insertTablaArea);
            if (result > 0){
                Console.WriteLine("Insert exitoso");
            }
            else{
                Console.WriteLine("Ha ocurrido un problema");
            }

        }
        /*****************************************************
        metodos posibles para listar
        *****************************************************/

        //listar primer metodo, trae todo el contenido de una tabla
        public static void _ObtebnerArea(){
            var listadoAreas = _AreaRepository.ObtebnerArea();
            foreach (var area in listadoAreas)
            {
                Console.WriteLine ("Id: "+ area.id +" Descripcion: "+ area.descripcionArea +" numero Area: "+area.area);
            }
        }

        //listar segundo metodo, trae el contenido que tenga el mismo valor que se envia como parametro
        public static void _ObtebnerAreaDos(){
            var listadoAreas = _AreaRepository.ObtebnerAreaDos("Prueba insert Visual");
            foreach (var area in listadoAreas)
            {
                Console.WriteLine ("Id: "+ area.id +" Descripcion: "+ area.descripcionArea +" numero Area: "+area.area);
            }
        }

        //listar segundo metodo, trae todo el contenido que contenga uno o dos caracteres como parametros
        public static void _ObtebnerAreaTres(){
            var listadoAreas = _AreaRepository.ObtebnerAreaTres("ual");
            foreach (var area in listadoAreas)
            {
                Console.WriteLine ("Id: "+ area.id +" Descripcion: "+ area.descripcionArea +" numero Area: "+area.area);
            }
        }

        /*****************************************************
        metodos posibles para buscar
        *****************************************************/

        //buscador, se usa para varias columnas, con la ayuda de operadpres logicos || &&
        //las columnas a buscar deben ser del mismo valor int o string
        public static void _BuscadorArea(){
            var listadoAreas = _AreaRepository.BuscadorArea("ual");
            foreach (var area in listadoAreas)
            {
                Console.WriteLine ("Id: "+ area.id +" Descripcion: "+ area.descripcionArea +" numero Area: "+area.area);
            }
        }

         //buscar por Id, usar antes de eliminar y actulizar, para saber si el registro existe
        public static void _BuscadorAreaId(){
            var result = _AreaRepository.BuscadorAreaId(2);
            Console.WriteLine ("Descripcion: "+ result.descripcionArea + " numero Area: "+result.area);
        }

        /*****************************************************
        Actulizar registros
        *****************************************************/

        //Actulizar, retorna un entero con el numero de registros afectados
        public static void _ActulizarArea(){
            //buscar si existe, preferiblemete por Id
            var existe = _AreaRepository.BuscadorAreaId(2);
            if (existe != null){
                existe.descripcionArea = "Actualizo desde VsCode";
                existe.area=14;
                var result =_AreaRepository.ActulizarArea(existe);
                if (result > 0){
                    Console.WriteLine("Se actulizo registro");
                }else{
                    Console.WriteLine("No actulizo registro");
                }
            }else {
                Console.WriteLine("No existe registro a actulizar");
            }
        }

        /*****************************************************
        Eliminar registros
        *****************************************************/
        public static void _EliminarArea(){
            //buscar si existe, preferiblemete por Id
            var existe = _AreaRepository.BuscadorAreaId(2);
            if (existe != null){
                var result =_AreaRepository.EliminarArea(existe);
                if (result > 0){
                    Console.WriteLine("Se elimino registro");
                }else{
                    Console.WriteLine("No elimino registro");
                }
            }else {
                Console.WriteLine("No existe registro a eliminar");
            }
        }
    }
}