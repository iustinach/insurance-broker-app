using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceBrokerApp.Models
{
    public class PolitaRCA : Polita
    {
        public int CapacitateCilindrica { get; set; }
        public int VarstaSofer { get; set; }

        public override double CalculeazaPret()
        {
            double baza = 500;

            if (VarstaSofer < 25)
                baza += 300;

            if (CapacitateCilindrica > 2000)
                baza += 200;

            Pret = baza;
            return Pret;
        }
    }
}
