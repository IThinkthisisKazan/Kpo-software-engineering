using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using Kpo4162_nmv.Lib;
using Kpo4162_nmv.lib;
using Kpo4162_nmv.Main.source;

namespace Kpo4162_nmv.Main
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private List<Employee> employeeList = null;
        private BindingSource bsEmploees = new BindingSource();

        private List<Substance> detailsList = null;
        private BindingSource bsDetails = new BindingSource();

        private void mnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnOpen_Click(object sender, EventArgs e)
        {
            try
            {

                //dgvEmployees.DataSource = loader.employeeList;  
                //Вызов исключения "Метод не реализован" 
                //throw new NotImplementedException();
                //Вызов базового исключения
                //throw new Exception("Неправильные входные параметры");
                MockDetailsListCommand loader = new MockDetailsListCommand();
                loader.Execute();
                bsEmploees.DataSource = employeeList;
                dgvEmployees.DataSource = bsEmploees;
                //dvgEmployee.DataSource = loader.employeeList;
                //loader.Execute();
                //bsDetails.DataSource = loader.detailsList;
                //dgvMyClasses.DataSource = bsDetails;
            }
            //обработка исключения "Метод не реализован" 
            catch (NotImplementedException ex)
            {
                MessageBox.Show("Ошибка №1: " + ex.Message);
                File.AppendAllText("error.log", ex.Message + "\n");
                
            }
            //обработка остальных исключений
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка №2: " + ex.Message);
            }
        }

        private void dgvMyClasses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mmFile_Click(object sender, EventArgs e)
        {

        }

        private void веществоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void открытьДанныеОВеществеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Создать экземпляр формы
            FrmSubstance frmEmployee = new FrmSubstance();
            //Задать сылка на текущий объект в таблицы
            Employee employee = (bsEmploees.Current as Employee);
            frmEmployee.SetEmployee(employee);
            //открыть форму в модальном режиме
            frmEmployee.ShowDialog();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
