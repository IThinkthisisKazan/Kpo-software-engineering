using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kpo4162_nmv.Lib;

namespace Kpo4162_nmv.Main.source
{
    public partial class FrmSubstance : Form
    {
        public FrmSubstance()
        {
            InitializeComponent();
            _employee = null;   
        }
        private Employee _employee = null;
        public Employee employee 
        { 
            get { return _employee; }
        }


        public void SetEmployee(Employee employee)
        {
            //инициализировать скрытое поля класса 
            this._employee = employee;
            //присвоить значение данных сотрудника элементам редактирования 
            this.textBoxTitle.Text = _employee.substance;
            //his.txtboxTitle.Text = _employee.title;
        }
        private void FrmSubstance_Load(object sender, EventArgs e)
        {

        }
        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
