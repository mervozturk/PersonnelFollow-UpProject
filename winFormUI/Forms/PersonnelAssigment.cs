using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
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
    public partial class PersonnelAssigment : Form
    {
        IAssigmentService _assigmentService;
        IPersonnelService _personnelService;
        IBranchService _branchService;
        IDepartmentService _departmentService;
        IUnitService _unitService;
        IAssigment_PersonnelService _assigment_PersonnelService;
        Department department;
        Unit unit;
        Branch branch;
        Assigment assigment;
        Personnel personnel;
        public PersonnelAssigment()
        {
            InitializeComponent();
            _assigmentService = new AssigmentManager(new EfAssigmentDal());
            _personnelService = new PersonnelManager(new EfPersonnelDal());
            _branchService = new BranchManager(new EfBranchDal());
            _departmentService = new DepartmentManager(new EfDepartmentDal());
            _unitService = new UnitManager(new EfUnitDal());
            _assigment_PersonnelService = new Assigment_PersonnelManager(new EfAssigment_PersonnelDal());
            dataGridViewAssigment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPersonnel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            comboBoxBranch.DataSource = BranchName();
            comboBoxDepartment.DataSource = DepartmentName();

        }

        private void DatagridFill(List<Assigment> result)
        {
            dataGridViewAssigment.Rows.Clear();
            for (int i = 0; i < result.Count; i++)
            {
                dataGridViewAssigment.Rows.Add();
                dataGridViewAssigment.Rows[i].Cells[0].Value = result[i].AssigmentName;
                dataGridViewAssigment.Rows[i].Cells[1].Value = result[i].AssigmentDescription;
                dataGridViewAssigment.Rows[i].Cells[2].Value = result[i].Deadline.ToString("dd-MM-yyy");
            }
        }

        private void DataGridFillPersonnel(List<Personnel> personnelList)
        {
            dataGridViewPersonnel.Rows.Clear();

            for (int i = 0; i < personnelList.Count; i++)
            {
                dataGridViewPersonnel.Rows.Add();
                dataGridViewPersonnel.Rows[i].Cells[0].Value = personnelList[i].IdentityNumber;
                dataGridViewPersonnel.Rows[i].Cells[1].Value = personnelList[i].FirstName;
                dataGridViewPersonnel.Rows[i].Cells[2].Value = personnelList[i].LastName;
               
                dataGridViewPersonnel.Rows[i].Cells[3].Value = personnelList[i].Occupation;
                dataGridViewPersonnel.Rows[i].Cells[4].Value = personnelList[i].StartDateOfEmployment.ToString("dd-MM-yyy");
                
            }
        }

        private List<string> BranchName()
        {
            List<string> name = new List<string>();
            foreach (var item in _branchService.GetAll().Data)
            {
                name.Add(item.BranchName);
            }
            return name;
        }
        private List<string> DepartmentName()
        {
            List<string> name = new List<string>();
            foreach (var item in _departmentService.GetAll().Data)
            {
                name.Add(item.DepartmentName);
            }
            return name;
        }
        private List<string> UnitName(int Id)
        {
            List<string> name = new List<string>();
            foreach (var item in _unitService.GetByDepartmentId(Id).Data)
            {
                name.Add(item.UnitName);
            }
            return name;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            assigment = new Assigment();
            assigment = _assigmentService.GetAllActive(branch.BranchId, unit.UnitId).Data[dataGridViewAssigment.SelectedRows[0].Index];
            labelAssigment.Text = assigment.AssigmentName;
            labelAssigment.Visible = Visible;
        }

        private void comboBoxBranch_SelectedValueChanged(object sender, EventArgs e)
        {
            branch = new Branch();
            branch = _branchService.GetAll().Data[comboBoxBranch.SelectedIndex];
        }

        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            department = _departmentService.GetAll().Data[comboBoxDepartment.SelectedIndex];
            comboBoxUnit.DataSource = UnitName(department.DepartmentId);
        }

        private void comboBoxUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            unit = new Unit();
            unit = _unitService.GetByDepartmentId(department.DepartmentId).Data[comboBoxUnit.SelectedIndex];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (comboBoxBranch.SelectedValue == null && comboBoxDepartment.SelectedValue == null && comboBoxUnit.SelectedValue == null)
            {
                MessageBox.Show("Tüm parametreleri seçtiğinizden emin olunuz!");
            }
             var resultAssigment = _assigmentService.GetAllActive(branch.BranchId, unit.UnitId).Data;

            DatagridFill(resultAssigment);
            var resultPersonnel = _personnelService.GetPersonnelByBranchAndUnit(branch.BranchId, unit.UnitId).Data;
            DataGridFillPersonnel(resultPersonnel);

        }

        private void dataGridViewAssigment_Click(object sender, EventArgs e)
        {
            

        }

        private void dataGridViewPersonnel_Click(object sender, EventArgs e)
        {
            personnel = new Personnel();
            personnel = _personnelService.GetPersonnelByBranchAndUnit(branch.BranchId, unit.UnitId).Data[dataGridViewPersonnel.SelectedRows[0].Index];
            labelPersonnel.Text = personnel.FirstName + " " + personnel.LastName;
            labelPersonnel.Visible = Visible;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Assigment_Personnel assigment_Personnel = new Assigment_Personnel()
            {
                AssigmentId = assigment.AssigmentId,
                PersonnelId = personnel.PersonnelId
            };
            if (_assigment_PersonnelService.Add(assigment_Personnel).Success)
            {
                MessageBox.Show("Atama işlemi tamamlandı");
            }

            base.Close(); 
        }
    }
}
