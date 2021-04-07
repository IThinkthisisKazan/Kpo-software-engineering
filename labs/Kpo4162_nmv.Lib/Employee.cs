using System;

namespace Kpo4162_nmv.Lib
{
    public class Employee
    {
        public Employee()
        {
            // Температура перехода веществ в сверхпроводниковое состояние
            substance = "";
            type = "";
            temperature = 0;
        }
        public string substance { get; set; }
        public string type { get; set; }
        public double temperature { get; set; }
    }
}
