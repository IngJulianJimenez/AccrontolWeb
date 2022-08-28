using System;
namespace AccrontolWeb.App.Dominio
{
    public class Supervisor:Trabajador
    {
        public int Id { get; set; }
        public string IdTrabajador { get; set; }
        public string Descripcion { get; set; }
        
    }
}