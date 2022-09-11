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
        private static IAreaRepository _AreaRepository = new AreaRepository(new AccrontolWeb.App.Persistencia.AppContext()); //Tabla Area
        private static ISedeRepository _SedeRepository = new SedeRepository(new AccrontolWeb.App.Persistencia.AppContext()); //Tabla Sede
        private static ITrabajadorRepository _TrabajadorRepository = new TrabajadorRepository(new AccrontolWeb.App.Persistencia.AppContext()); //Tabla Trabajador

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
            //metodos CRUD basicos
            //_AgregarArea();
            //_ObtebnerArea();
            //_ObtebnerAreaDos();
            //_ObtebnerAreaTres();
            //_BuscadorArea();
            //_BuscadorAreaId();
            //_ActulizarArea();
            //_EliminarArea();

            //metodos Proyecto
            //_BuscadorSedeId();
            //_ObtebnerTrabajadorDos();
            //_BuscadorTrabajadorId();
            _ActulizarTrabajador();
        }

        /*****************************************************
        metodos para agregar registros en un tabla
        *****************************************************/

        public static void _AgregarArea()
        {
            var insertTablaArea = new Area
            {
                descripcionArea = "soporte IT",
                area = 3
            };
            var result = _AreaRepository.Add(insertTablaArea);
            if (result > 0)
            {
                Console.WriteLine("Insert exitoso");
            }
            else
            {
                Console.WriteLine("Ha ocurrido un problema");
            }

        }
        /*****************************************************
        metodos posibles para listar
        *****************************************************/

        //listar primer metodo, trae todo el contenido de una tabla
        public static void _ObtebnerArea()
        {
            var listadoAreas = _AreaRepository.ObtebnerArea();
            foreach (var area in listadoAreas)
            {
                Console.WriteLine("Id: " + area.id + " Descripcion: " + area.descripcionArea + " numero Area: " + area.area);
            }
        }

        //listar segundo metodo, trae el contenido que tenga el mismo valor que se envia como parametro
        public static void _ObtebnerAreaDos()
        {
            var listadoAreas = _AreaRepository.ObtebnerAreaDos("administrativos");
            foreach (var area in listadoAreas)
            {
                Console.WriteLine("Id: " + area.id + " Descripcion: " + area.descripcionArea + " numero Area: " + area.area);
            }
        }

        //listar segundo metodo, trae todo el contenido que contenga uno o dos caracteres como parametros
        public static void _ObtebnerAreaTres()
        {
            var listadoAreas = _AreaRepository.ObtebnerAreaTres("admin");
            foreach (var area in listadoAreas)
            {
                Console.WriteLine("Id: " + area.id + " Descripcion: " + area.descripcionArea + " numero Area: " + area.area);
            }
        }

        /*****************************************************
        metodos posibles para buscar
        *****************************************************/

        //buscador, se usa para varias columnas, con la ayuda de operadores logicos || &&
        //las columnas a buscar deben ser del mismo valor int o string
        public static void _BuscadorArea()
        {
            var listadoAreas = _AreaRepository.BuscadorArea("admin");
            foreach (var area in listadoAreas)
            {
                Console.WriteLine("Id: " + area.id + " Descripcion: " + area.descripcionArea + " numero Area: " + area.area);
            }
        }

        //buscar por Id, usar antes de eliminar y actulizar, para saber si el registro existe
        public static void _BuscadorAreaId()
        {
            var result = _AreaRepository.BuscadorAreaId(2);
            Console.WriteLine("Id: " + result.id + " Descripcion: " + result.descripcionArea + " numero Area: " + result.area);
            var n = result.id;
            Console.WriteLine("El valor del area =" + n + " El area es entero?:" + n.GetType());

        }
        public static void _BuscadorSedeId()
        {
            var result = _SedeRepository.BuscadorSedeId(2);
            Console.WriteLine("Id: " + result.id + " NombreSede: " + result.nombreSede + " numero Sede: " + result.id);
        }

        /*****************************************************
        Actulizar registros
        *****************************************************/

        //Actulizar, retorna un entero con el numero de registros afectados
        public static void _ActulizarArea()
        {
            //buscar si existe, preferiblemete por Id
            var existe = _AreaRepository.BuscadorAreaId(2);
            if (existe != null)
            {
                existe.descripcionArea = "desarollo";
                existe.area = 14;
                var result = _AreaRepository.ActulizarArea(existe);
                if (result > 0)
                {
                    Console.WriteLine("Se actulizo registro");
                }
                else
                {
                    Console.WriteLine("No actulizo registro");
                }
            }
            else
            {
                Console.WriteLine("No existe registro a actulizar");
            }
        }

        /*****************************************************
        Eliminar registros
        *****************************************************/
        public static void _EliminarArea()
        {
            //buscar si existe, preferiblemete por Id
            var existe = _AreaRepository.BuscadorAreaId(2);
            if (existe != null)
            {
                var result = _AreaRepository.EliminarArea(existe);
                if (result > 0)
                {
                    Console.WriteLine("Se elimino registro");
                }
                else
                {
                    Console.WriteLine("No elimino registro");
                }
            }
            else
            {
                Console.WriteLine("No existe registro a eliminar");
            }
        }

        /*****************************************************
        
        *****************************************************/
        public static void _AgregarTrabajador()
        {
            var _idArea = _AreaRepository.BuscadorAreaId(2);
            var _idSede = _SedeRepository.BuscadorSedeId(3);
            if ((_idArea != null) && (_idSede != null))
            {
                var insertTablaTRabajador = new Trabajador
                {
                    identificacion = "1234567890",
                    nombre = "Julian Jimenez Ariza",
                    usuario = "jjimeneza",
                    password = "1234",
                    active = 1,
                    Areaid = _idArea.id, // solo el id
                    Sedeid = _idSede.id  // solo el id
                };
                var result = _TrabajadorRepository.Add(insertTablaTRabajador);
                if (result > 0)
                {
                    Console.WriteLine("Trabajador ingresado con exito");
                }
                else
                {
                    Console.WriteLine("Ha ocurrido un error con los datos ingresados");
                }
            }
            else
            {
                Console.WriteLine("Ha ocurrido un error con los datos ingresados");
            }
        }
        //listar
        public static void _ObtebnerTrabajadorDos()
        {
            var listado = _TrabajadorRepository.ObtebnerTrabajadorDos("1234567890");
            foreach (var lst in listado)
            {
                Console.WriteLine("identificacion " + lst.identificacion + " nombre " + lst.nombre + " Areaid " + lst.Areaid + " Sedeid " + lst.Sedeid + " Activo " + lst.active);
            }
        }

        //buscar por Id, usar antes de eliminar y actulizar, para saber si el registro existe
        public static void _BuscadorTrabajadorId()
        {
            var lst = _TrabajadorRepository.BuscadorTrabajadorId(1);
            Console.WriteLine("id " + lst.id + " identificacion " + lst.identificacion + " nombre " + lst.nombre + " Areaid " + lst.Areaid + " Sedeid " + lst.Sedeid + " Activo " + lst.active);
        }

        //Actulizar, retorna un entero con el numero de registros afectados
        public static void _ActulizarTrabajador()
        {
            //buscar si existe, preferiblemete por Id
            var existe = _TrabajadorRepository.BuscadorTrabajadorId(1);
            if (existe != null)
            {
                existe.nombre = "Prueba vs Code";
                existe.usuario = "2345";
                existe.password = "2345";
                existe.active = 0;
                existe.Areaid = 1;
                existe.Sedeid = 1;

                var result = _TrabajadorRepository.ActulizarTrabajador(existe);
                if (result > 0)
                {
                    Console.WriteLine("Se actulizo registro");
                }
                else
                {
                    Console.WriteLine("No actulizo registro");
                }
            }
            else
            {
                Console.WriteLine("No existe registro a actulizar");
            }
        }
    }
}

