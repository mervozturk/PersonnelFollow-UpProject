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
    public partial class PersonnelAdd : Form
    {
        IPersonnelService _personnelService;
        IBranchService _branchService;
        IDepartmentService _departmentService;
        IUnitService _unitService;
        Department department;
        public PersonnelAdd()
        {
            InitializeComponent();
            _personnelService = new PersonnelManager(new EfPersonnelDal());
            _branchService = new BranchManager(new EfBranchDal());
            _departmentService = new DepartmentManager(new EfDepartmentDal());
            _unitService = new UnitManager(new EfUnitDal());
            comboBoxBranch.DataSource = BranchName();
            comboBoxDepartment.DataSource = DepartmentName();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personnel personnel = new Personnel()
            {
                BranchId = _branchService.GetAll().Data[comboBoxBranch.SelectedIndex].BranchId,
                UnitId= _unitService.GetByDepartmentId(department.DepartmentId).Data[comboBoxUnit.SelectedIndex].UnitId,
                IdentityNumber = textBoxTC.Text,
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                Birthdate = dateTimePickerBirthDate.Value,
                StartDateOfEmployment = dateTimePickerStartofEmployment.Value,
                BirthPlace = textBoxBirthPlace.Text,
                EducationalStatus = textBoxEducationalState.Text,
                Occupation = textBoxOccupation.Text,
                IsActive = true,
                TerminationDate = new DateTime(1900, 01, 01)
            };
            
            if (_personnelService.Add(personnel).Success)
            {
                MessageBox.Show("Personel eklendi");
            }

            base.Close();
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

        private void comboBoxDepartment_SelectedValueChanged(object sender, EventArgs e)
        {
            department = _departmentService.GetAll().Data[comboBoxDepartment.SelectedIndex];
            comboBoxUnit.DataSource = UnitName(department.DepartmentId);
        }

        private void comboBoxBranch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
