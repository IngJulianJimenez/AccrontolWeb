using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AccrontolWeb.App.Dominio; //comunicar con proyecto
using AccrontolWeb.App.Persistencia; //comunicar con proyecto

namespace AccrontolWeb.App.WebApp
{
    public class CreateModel : PageModel
    {
        //inastaciar el repositorio para el CRUD
        private ITrabajadorRepository _TrabajadorRepository = new TrabajadorRepository(new AccrontolWeb.App.Persistencia.AppContext());

        public void OnGet()
        {
        }

        public void OnPost()
        {
            //variables capturadas formulario
            //var = Request.Form [name html]
            var _identificacion = Request.Form["identificacion"];
            var _nombre = Request.Form["nombre"];
            var _usuario = Request.Form["usuario"];
            var _password = Request.Form["password"];
            var _active = 1; //usuario nuevo se registra Activo
            var _Areaid = Request.Form["Areaid"];
            var _Sedeid = Request.Form["Sedeid"];

            //validar datos de las personas con seguridad back

            var crearEmpleado = new Trabajador
            {
                //atributoTabla = variableCapturada
                identificacion = _identificacion,
                nombre = _nombre,
                usuario = _usuario,
                password = _password,
                active = _active,
                Areaid = int.Parse(_Areaid),
                Sedeid = int.Parse(_Sedeid),
            };

            //realizar el CRUD 
            //tener presente el valor de retorno          
            var result = _TrabajadorRepository.Add(crearEmpleado);

            //mostrar al front el resultado de la operacion
            if (result > 0)
            {
                Console.WriteLine("Empleado Registrado");
            }
            else
            {
                Console.WriteLine("Error al registrar empleado");
            }
        }
    }
}
