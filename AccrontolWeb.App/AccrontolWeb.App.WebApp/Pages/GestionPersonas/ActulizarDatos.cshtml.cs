using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AccrontolWeb.App.Dominio; //comunicar con proyecto
using AccrontolWeb.App.Persistencia; //comunicar con proyecto

namespace AccrontolWeb.App.WebApp
{
    public class ActulizarDatosModel : PageModel
    { 
        //instaciar (crear conexion) el repositorio para el CRUD
        private ITrabajadorRepository _TrabajadorRepository = new TrabajadorRepository(new AccrontolWeb.App.Persistencia.AppContext());
        
        //Variable publica para mostrar el resultado en el front
        public Trabajador empleado = new Trabajador();
        //recibe un id
        public void OnGet(int id)
        {    //buscar por id
            var empleado =_TrabajadorRepository.BuscadorTrabajadorId(id);
        }
    }
}
