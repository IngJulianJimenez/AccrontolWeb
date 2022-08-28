using System;
namespace AccrontolWeb.App.Dominio
{
    public class RegistroHora
    {
        public int Id { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFinal { get; set; }
        public Date Fecha { get; set; }
        public String IdTrabajador { get; set; }
        public string Descripcion { get; set; }
        
    }
}