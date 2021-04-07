using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4162_nmv.lib
{
    public class Details
    {
        // title - вещество, type - тип, temperature - температура

        public Details()
        {
            Title = Type = "";
            temperature = 0;
        }

        public string Title { get; set; }
        public string Type { get; set; }
        public int temperature { get; set; }
    }
}
