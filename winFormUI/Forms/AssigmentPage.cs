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
    public partial class AssigmentPage : Form
    {
        IAssigmentService _assigmentService;
        IPersonnelService _personnelService;
        IBranchService _branchService;
        IDepartmentService _departmentService;
        IUnitService _unitService;
        Department department;
        Unit units;
        Branch branch;
        Assigment assigment;
        public AssigmentPage()
        {
            InitializeComponent();
            _assigmentService = new AssigmentManager(new EfAssigmentDal());
            _personnelService = new PersonnelManager(new EfPersonnelDal());
            _branchService = new BranchManager(new EfBranchDal());
            _departmentService = new DepartmentManager(new EfDepartmentDal());
            _unitService = new UnitManager(new EfUnitDal());

            comboBoxBranch.DataSource = BranchName();
            comboBoxDepartment.DataSource = DepartmentName();
            comboBoxAssigment.DataSource = AssigmentsName();

            List<string> filterlist = new List<string>();
            filterlist.Add("Tümü");
            filterlist.Add("Tamamlanmış görevler");
            filterlist.Add("Tamamlanmamış görevler");

            comboBoxFilter.DataSource = filterlist;
            var result = _assigmentService.GetAllDetail().Data;
            DatagridFill(result);

            dataGridViewAssigment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void DatagridFill(List<AssigmentDetailDto> result)
        {
            dataGridViewAssigment.Rows.Clear();
            for (int i = 0; i < result.Count; i++)
            {
                dataGridViewAssigment.Rows.Add();
                dataGridViewAssigment.Rows[i].Cells[0].Value = result[i].AssigmentName;
                dataGridViewAssigment.Rows[i].Cells[1].Value = result[i].AssigmentDescription;
                dataGridViewAssigment.Rows[i].Cells[2].Value = result[i].Deadline.ToString("dd-MM-yyy");
                
                if (result[i].SubmittedDate.ToString("dd-MM-yyy")=="01-01-1900")
                {
                    dataGridViewAssigment.Rows[i].Cells[3].Value = "-";
                }
                else
                {
                    dataGridViewAssigment.Rows[i].Cells[3].Value = result[i].SubmittedDate.ToString("dd-MM-yyy");
                }
                dataGridViewAssigment.Rows[i].Cells[5].Value = result[i].PersonnelFirstName;
                dataGridViewAssigment.Rows[i].Cells[6].Value = result[i].PersonnelFLastName;
                dataGridViewAssigment.Rows[i].Cells[7].Value = result[i].UnitName;

            }
        }

        private void comboBoxFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (comboBoxFilter.SelectedIndex)
            {
                case 0:
                    var GetAll = _assigmentService.GetAllDetail().Data;
                    DatagridFill(GetAll);
                    break;
                case 1:
                    var GetActive = _assigmentService.GetAllDetailPassive().Data;
                    DatagridFill(GetActive);
                    break;
                case 2:

                    var result = _assigmentService.GetAllDetailActive().Data;
                    DatagridFill(result);
                    break;
                default:
                    break;
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
        private List<string> AssigmentsName()
        {
            List<string> name = new List<string>();
            foreach (var item in _assigmentService.GetAll().Data)
            {
                name.Add(item.AssigmentName);
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
            units = new Unit();
            units = _unitService.GetByDepartmentId(department.DepartmentId).Data[comboBoxUnit.SelectedIndex];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<AssigmentDetailDto> result = new List<AssigmentDetailDto>();
            if (comboBoxBranch.SelectedValue == null && comboBoxDepartment.SelectedValue == null && comboBoxUnit.SelectedValue == null)
            {
                MessageBox.Show("Tüm parametreleri seçtiğinizden emin olunuz!");
            }
            result = _assigmentService.GetAssigmentByBranchAndUnit(branch.BranchId, units.UnitId).Data;
          
            DatagridFill(result);
        }

        private void comboBoxAssigment_SelectedIndexChanged(object sender, EventArgs e)
        {
            assigment = new Assigment();
            assigment = _assigmentService.GetAll().Data[comboBoxAssigment.SelectedIndex];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = _assigmentService.GetAllDetailByAssigmentId(assigment.AssigmentId).Data;
            DatagridFill(result);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AssigmentAdded assigmentAdded = new AssigmentAdded();
            assigmentAdded.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonnelAssigment personnelAssigment = new PersonnelAssigment();
            personnelAssigment.Show();
        }

        private void dataGridViewAssigment_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AssigmentUpdate assigmentUpdate = new AssigmentUpdate();
            assigmentUpdate.Show();
        }
    }
}
