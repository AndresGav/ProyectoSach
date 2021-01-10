using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGestionSach.Models
{
    class Reservas
    {
        public int id_reserva { get; set; }
        public string cedula_cliR { get; set; }
        public string codigo_habR { get; set; }
        public string cedula_empR { get; set; }
        public string fechaReg_res { get; set; }
        public string fechaIng_res { get; set; }
        public string fechaSal_res { get; set; }
        public int numDias_res { get; set; }
        public double prdTotal_res { get; set; }
        public double abono_res { get; set; }
        public double saldo_res { get; set; }
        public string estado_res { get; set; }

        public Reservas() { }

        public Reservas(int id_reserva, string cedula_cliR, string codigo_habR, string cedula_empR, string fechaReg_res, string fechaIng_res, string fechaSal_res, int numDias_res, double prdTotal_res, double abono_res, double saldo_res, string estado_res)
        {
            this.id_reserva = id_reserva;
            this.cedula_cliR = cedula_cliR;
            this.codigo_habR = codigo_habR;
            this.cedula_empR = cedula_empR;
            this.fechaReg_res = fechaReg_res;
            this.fechaIng_res = fechaIng_res;
            this.fechaSal_res = fechaSal_res;
            this.numDias_res = numDias_res;
            this.prdTotal_res = prdTotal_res;
            this.abono_res = abono_res;
            this.saldo_res = saldo_res;
            this.estado_res = estado_res;
        }
    }
}
