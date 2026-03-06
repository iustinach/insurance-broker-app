using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceBrokerApp.Models
{
    public class PolitaCASCO : Polita
    {
        public double ValoareMasina { get; set; }
        public int AnFabricatie { get; set; }

        public override double CalculeazaPret()
        {
            Pret = ValoareMasina * 0.05;
            return Pret;
        }
    }
}
