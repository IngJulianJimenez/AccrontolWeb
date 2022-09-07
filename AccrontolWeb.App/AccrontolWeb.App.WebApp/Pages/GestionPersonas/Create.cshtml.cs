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
            //var = Request.Form [name html]
            var descripcion = Request.Form["descripcion"];
            var nombre = Request.Form["nombre"];
            var usuario = Request.Form["usuario"];
            var password = Request.Form["password"];
            var active = 1; //usuario nuevo se registra nuevo
            var idAreaid = Request.Form["idAreaid"];
            var idSedeid = Request.Form["idSedeid"];

            //selector
            //var SelectorArea = Request.Form["SelectorArea"];

            //validar datos de las personas


        }
    }
}
