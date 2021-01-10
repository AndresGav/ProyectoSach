using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGestionSach.Models
{
    class Alquileres
    {
        public int id_alquiler { get; set; }
        public string cedula_cliA { get; set; }
        public string codigo_habA { get; set; }
        public string cedula_empA { get; set; }
        public string fechaIng_alq { get; set; }
        public string fechaSal_alq { get; set; }
        public int numDias_alq { get; set; }
        public double prcTotal_alq { get; set; }
        public string estado_alq { get; set; }

        public Alquileres() { }

        public Alquileres(int id_alquiler, string cedula_cliA, string codigo_habA, string cedula_empA, string fechaIng_alq, string fechaSal_alq, int numDias_alq, double prcTotal_alq, string estado_alq)
        {
            this.id_alquiler = id_alquiler;
            this.cedula_cliA = cedula_cliA;
            this.codigo_habA = codigo_habA;
            this.cedula_empA = cedula_empA;
            this.fechaIng_alq = fechaIng_alq;
            this.fechaSal_alq = fechaSal_alq;
            this.numDias_alq = numDias_alq;
            this.prcTotal_alq = prcTotal_alq;
            this.estado_alq = estado_alq;
        }
    }
}
