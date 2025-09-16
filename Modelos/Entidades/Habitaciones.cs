using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Modelos.Entidades
{
    public class Habitaciones
    {
        private int idHabitacion;
        private string numeroHabitacion;
        private string tipoHabitacion;
        private string estado;
        private decimal precio;
        
        public int IdHabitacion { get => idHabitacion; set => idHabitacion = value; }
        public string NumeroHabitacion { get => numeroHabitacion; set => numeroHabitacion = value; }
        public string TipoHabitacion { get => tipoHabitacion; set => tipoHabitacion = value; }
        public string Estado { get => estado; set => estado = value; }
        public decimal Precio { get => precio; set => precio = value; }
    }
}
