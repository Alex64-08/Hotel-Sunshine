using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Modelos.Entidades
{
    public class Servicios
    {
        private int idServicio;
        private string nombreServicio;
        private string descripcion;
        private decimal precio;
        public int IdServicio { get => idServicio; set => idServicio = value; }
        public string NombreServicio { get => nombreServicio; set => nombreServicio = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public decimal Precio { get => precio; set => precio = value; }
    }
}
