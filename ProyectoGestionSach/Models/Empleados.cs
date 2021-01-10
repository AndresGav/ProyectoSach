using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGestionSach.Models
{
    class Empleados
    {
        public string cedula_emp { get; set; }
        public string nombre_emp { get; set; }
        public string apellido_emp { get; set; }
        public string cargo_emp { get; set; }
        public string direccion_emp { get; set; }
        public string telefono_emp { get; set; }
        public string usuario_emp { get; set; }
        public string password { get; set; }
        public int status { get; set; }

        public Empleados() { }

        public Empleados(string cedula_emp, string nombre_emp, string apellido_emp, string cargo_emp, string direccion_emp, string telefono_emp, string usuario_emp, string password, int status)
        {
            this.cedula_emp = cedula_emp;
            this.nombre_emp = nombre_emp;
            this.apellido_emp = apellido_emp;
            this.cargo_emp = cargo_emp;
            this.direccion_emp = direccion_emp;
            this.telefono_emp = telefono_emp;
            this.usuario_emp = usuario_emp;
            this.password = password;
            this.status = status;
        }

    }
}
