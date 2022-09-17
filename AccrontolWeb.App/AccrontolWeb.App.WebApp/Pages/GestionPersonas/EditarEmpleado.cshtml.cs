using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AccrontolWeb.App.Dominio; //comunicar con proyecto
using AccrontolWeb.App.Persistencia; //comunicar con proyecto


namespace AccrontolWeb.App.WebApp
{
    public class EditarEmpleadoModel : PageModel
    {
        //instaciar (crear conexion) el repositorio para el CRUD
        private ITrabajadorRepository _TrabajadorRepository = new TrabajadorRepository(new AccrontolWeb.App.Persistencia.AppContext());
        
        //variable para pasar la data al front(objeto)
        public Trabajador trabajador = new Trabajador();

        //recibo el id del empleado a consultar (viene desde ConsultarHoras)
        //para redirigir camabiar void por IActionResult
        public IActionResult OnGet(int id)
        {
            trabajador = _TrabajadorRepository.BuscadorTrabajadorId(id);

            //ya estando en la apgina de editar si el id no existe, redirigir a otra pagina
            if (trabajador == null)
            {  
               return RedirectToPage("./ConsultarHoras");
            }
            else
            {
                return Page();
            }
        }
    }
}
