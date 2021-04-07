using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4162_nmv.lib
{
    public class MockDetailsListCommand : IDetailsListLoader
    {
        public MockDetailsListCommand()
        {
            this._detailsList = new List<Details>();
        }

        private List<Details> _detailsList = new List<Details>();

        public List<Details> detailsList
        {
            get { return _detailsList; }
        }

        public void Execute()
        {
            try
            {
                // Фигурная скобка для ограничения видимости переменной details
                {
                    Details details = new Details()
                    {
                        substance = "Zn",
                        type = "М-Металл",
                        temperature = "0.8-0.8"
                    };
                    _detailsList.Add(details);
                }
                {
                    Details details = new Details()
                    {
                        substance = "Pb-Au",
                        type = "П-сплав",
                        temperature = "2.0-7.3"
                    };
                    _detailsList.Add(details);
                }
                {
                    Details details = new Details()
                    {
                        substance = "NbC",
                        type = "С-соединение",
                        temperature = "10.1-10.5"
                    };
                    _detailsList.Add(details);
                }
            }

            //Установить статус чтения данных в успешно
            catch (Exception ex) { LogUtility.ErrorLog(ex); }
        }

    }
}
