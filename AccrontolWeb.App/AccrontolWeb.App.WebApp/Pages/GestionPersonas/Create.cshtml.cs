using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AccrontolWeb.App.Dominio; //comunicar con proyecto
using AccrontolWeb.App.Persistencia; //comunicar con proyecto

namespace AccrontolWeb.App.WebApp
{
    public class CreateModel : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost(){
            //campo name en el html
            var descripcion = Request.Form["descripcion"];

            //selector
            var SelectorArea = Request.Form["SelectorArea"];

            //validar datos de las personas


        }
    }
}
