using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGestionSach.Models
{
    class VistasReservas
    {

        public string Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Habitacion { get; set; }
        public string Fecha_Ingreso { get; set; }
        public string Fecha_Salida { get; set; }
        public double Precio_Total { get; set; }
        public double Saldo { get; set; }

        public VistasReservas()
        {

        }

        public VistasReservas(string id, string cedula, string nombre, string habitacion, string fecha_Ingreso, string fecha_Salida, double precio_Total, double saldo)
        {
            Id = id;
            Cedula = cedula;
            Nombre = nombre;
            Habitacion = habitacion;
            Fecha_Ingreso = fecha_Ingreso;
            Fecha_Salida = fecha_Salida;
            Precio_Total = precio_Total;
            Saldo = saldo;
        }
    }
}
