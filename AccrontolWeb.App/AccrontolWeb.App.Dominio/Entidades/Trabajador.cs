using System;
namespace AccrontolWeb.App.Dominio
{
    public class Trabajador
    {
        public int Id { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string IdArea { get; set; }
        public string IdSede { get; set; }
    }
}