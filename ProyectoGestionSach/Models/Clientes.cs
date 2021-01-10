using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGestionSach.Models
{
    class Clientes
    {
        public string cedula_cli { get; set; }
        public string nombre_cli { get; set; }
        public string apellido_cli { get; set; }
        public string direccion_cli { get; set; }
        public string telefono_cli { get; set; }

        public Clientes() { }

        public Clientes(string cedula_cli, string nombre_cli, string apellido_cli, string direccion_cli, string telefono_cli)
        {
            this.cedula_cli = cedula_cli;
            this.nombre_cli = nombre_cli;
            this.apellido_cli = apellido_cli;
            this.direccion_cli = direccion_cli;
            this.telefono_cli = telefono_cli;
        }
    }
}
