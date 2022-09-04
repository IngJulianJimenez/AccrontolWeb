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
        }
    }
}