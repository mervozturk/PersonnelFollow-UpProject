using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winFormUI.Forms
{
    public partial class Hompage : Form
    {
        IAssigmentService _assigmentService;
        public Hompage()
        {
            InitializeComponent();
            _assigmentService = new AssigmentManager(new EfAssigmentDal());
            labelDate.Text = DateTime.Now.ToString("dd dddd MMMM yyyy");
            DatagridFill();
            dataGridViewAssigment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


        }

        private void DatagridFill()
        {
            var result = _assigmentService.GetAllDetailActive().Data;
            for (int i = 0; i < result.Count; i++)
            {
                dataGridViewAssigment.Rows.Add();
                dataGridViewAssigment.Rows[i].Cells[0].Value = result[i].AssigmentName;
                dataGridViewAssigment.Rows[i].Cells[1].Value = result[i].AssigmentDescription;
                dataGridViewAssigment.Rows[i].Cells[2].Value = result[i].Deadline.ToString("dd-MM-yyy");
                dataGridViewAssigment.Rows[i].Cells[4].Value = result[i].PersonnelFirstName;
                dataGridViewAssigment.Rows[i].Cells[5].Value = result[i].PersonnelFLastName;

            }
        }
        private void labelNot_Click(object sender, EventArgs e)
        {

        }
    }
}
