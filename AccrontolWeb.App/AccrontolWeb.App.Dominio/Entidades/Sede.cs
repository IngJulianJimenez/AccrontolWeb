using System;
namespace AccrontolWeb.App.Dominio
{
    public class Sede
    {
        public EmpresaSede EmpresaSede { get; set; }
        public int Id { get; set; }
        public string Ciudad { get; set; }
        public string NombreSede { get; set; }
        public string Direccion { get; set; }
        public string Telefono{ get; set; }
        public string IdEmpresa{ get; set; }
    }
}