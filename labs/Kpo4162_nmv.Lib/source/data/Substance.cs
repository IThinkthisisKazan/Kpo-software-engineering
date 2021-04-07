using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Kpo4162_nmv.Lib
{
    public class Substance
    {
        // title - вещество, type - тип, temperature - температура
        public Substance()
        {
            substance = "";
            type = "";
            temperature = 0;
        }

        public string substance { get; set; }
        public string type { get; set; }
        public double temperature { get; set; }
    }
}
