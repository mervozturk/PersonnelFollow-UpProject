using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
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
    public partial class AssigmentAdded : Form
    {
        IAssigmentService _assigmentService;
        IBranchService _branchService;
        IDepartmentService _departmentService;
        IUnitService _unitService;
        Department department;
        Unit unit;
        Branch branch;
        public AssigmentAdded()
        {
            InitializeComponent();
            _assigmentService = new AssigmentManager(new EfAssigmentDal());
            _branchService = new BranchManager(new EfBranchDal());
            _departmentService = new DepartmentManager(new EfDepartmentDal());
            _unitService = new UnitManager(new EfUnitDal());
            comboBoxBranch.DataSource = BranchName();
            comboBoxDepartment.DataSource = DepartmentName();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Assigment assigment = new Assigment()
            {
                BranchId = branch.BranchId,
                UnitId = unit.UnitId,
                AssigmentName = textBoxAssigmentName.Text,
                AssigmentDescription = textBoxAssigmentDescription.Text,
                Deadline = dateTimePickerDeadline.Value,
                IsActive = true,
                SubmittedDate = new DateTime(1900, 01, 01)

            };
            if (_assigmentService.Add(assigment).Success)
            {
                MessageBox.Show("Görev eklendi");
            }
            base.Close();
        }
    }
}
