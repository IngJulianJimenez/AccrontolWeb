using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AccrontolWeb.App.Dominio; //comunicar con proyecto
using AccrontolWeb.App.Persistencia; //comunicar con proyecto

namespace AccrontolWeb.App.WebApp
{
    public class ConsultarHorasModel : PageModel
    {
        //instaciar (crear conexion) el repositorio para el CRUD
        private ITrabajadorRepository _TrabajadorRepository = new TrabajadorRepository(new AccrontolWeb.App.Persistencia.AppContext());

        //listado para que lo consuma el front (probar con IEnumerable)
        //para lista por documento
        public List<Trabajador> listadoEmpleado = new List<Trabajador>();

        //para lista por grupo
        public List<Trabajador> listado_Empleados = new List<Trabajador>();

        //pedir solicitar al servidor
        //consultar por grupo
        public void OnGet()
        {
            //consultar todos los empelados
            listado_Empleados = _TrabajadorRepository.ObtenerTodoTrabajador();
            Console.WriteLine(listado_Empleados);
        }

        //consultar por documento
        public void OnPost()
        {
            //consultar un empleado
            listadoEmpleado = _TrabajadorRepository.ObtebnerTrabajadorDos(Request.Form["identificacion"]);
            Console.WriteLine("result: "+listadoEmpleado[0]);
        }
    }
}
