using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Modelos.Entidades
{
    public class Reservas
    {
        private int idReserva;
        private int idCliente;
        private int idHabitacion;
        private DateTime inicioReserva;
        private DateTime finReserva;
        private string estadoReserva;

        public int IdReserva { get => idReserva; set => idReserva = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdHabitacion { get => idHabitacion; set => idHabitacion = value; }
        public DateTime InicioReserva { get => inicioReserva; set => inicioReserva = value; }
        public DateTime FinReserva { get => finReserva; set => finReserva = value; }
        public string EstadoReserva { get => estadoReserva; set => estadoReserva = value; }
    }
}
