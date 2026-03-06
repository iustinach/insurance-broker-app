using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceBrokerApp.Models
{
    public abstract class Polita
    {
        public int Id { get; set; }
        public DateTime DataInceput { get; set; }
        public DateTime DataExpirare { get; set; }
        public double Pret { get; protected set; }

        public CompanieAsigurare Companie { get; set; }

        public bool EsteActiva()
        {
            return DateTime.Now <= DataExpirare;
        }

        public abstract double CalculeazaPret();
    }
}
