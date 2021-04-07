using Kpo4162.nmv.Lib;
using Kpo4162_nmv.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4162_nmv.lib
{
    public class MockDetailsListCommand
    {
        public MockDetailsListCommand()
        {
            this._employeeList = null;
            //this._detailsList = new List<Lib.Details>();
        }

        private readonly string _dataFileName = "";
        private List<Employee> _employeeList = null;
        //private List<Lib.Details> _detailsList = new List<Lib.Details>();

        public List<Employee> employeeList
        {
            get { return employeeList; }
        }

        public void Execute()
        {
            try
            {
                // Фигурная скобка для ограничения видимости переменной details
                {
                    Employee employee = new Employee()
                    {
                        substance = "Zn",
                        type = "М-Металл",
                        temperature = 0.8 //0.8-0.8
                    };
                    _employeeList.Add(employee);
                }
                {
                    Employee employee = new Employee()
                    {
                        substance = "Pb-Au",
                        type = "П-сплав",
                        temperature = 2.0 // "2.0-7.3"
                    };
                    _employeeList.Add(employee);
                }
                {
                    Employee employee = new Employee()
                    {
                        substance = "NbC",
                        type = "С-соединение",
                        temperature = 10.0   // "10.1-10.5"
                    };
                    _employeeList.Add(employee);
                }
            }

            //Установить статус чтения данных в успешно
            catch (Exception ex) { LogUtility.ErrorLog(ex); }
        }

    }
}
