using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGestionSach.Models
{
    class Habitaciones
    {
        public string codigo_hab { get; set; }
        public string tipo_hab { get; set; }
        public string estado_hab { get; set; }
        public string descr_hab { get; set; }
        public double prcAlto { get; set; }
        public double prcBajo { get; set; }

        public Habitaciones() { }

        public Habitaciones(string cod_hab, string tipo_hab, string estado_hab, string descr_hab, double prcAlto, double prcBajo)
        {
            this.codigo_hab = cod_hab;
            this.tipo_hab = tipo_hab;
            this.estado_hab = estado_hab;
            this.descr_hab = descr_hab;
            this.prcAlto = prcAlto;
            this.prcBajo = prcBajo;
        }

        public Habitaciones(string cod_hab, string tipo_hab, string estado_hab)
        {
            this.codigo_hab = cod_hab;
            this.tipo_hab = tipo_hab;
            this.estado_hab = estado_hab;
        }
    }
}
