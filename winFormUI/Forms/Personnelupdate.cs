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
    public partial class Personnelupdate : Form
    {
        IPersonnelService _personnelService;
        IBranchService _branchService;
        IDepartmentService _departmentService;
        IUnitService _unitService;
        Department department;
        Unit unit;
        Branch branch;
        Personnel personnel;
        public Personnelupdate()
        {
            InitializeComponent();
            _personnelService = new PersonnelManager(new EfPersonnelDal());
            _branchService = new BranchManager(new EfBranchDal());
            _departmentService = new DepartmentManager(new EfDepartmentDal());
            _unitService = new UnitManager(new EfUnitDal());
            comboBoxBranch.DataSource = BranchName();
            comboBoxDepartment.DataSource = DepartmentName();
            dataGridViewPersonnel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void datagridFill(List<Personnel> personnelList)
        {
            dataGridViewPersonnel.Rows.Clear();

            for (int i = 0; i < personnelList.Count; i++)
            {
                dataGridViewPersonnel.Rows.Add();
                dataGridViewPersonnel.Rows[i].Cells[0].Value = personnelList[i].IdentityNumber;
                dataGridViewPersonnel.Rows[i].Cells[1].Value = personnelList[i].FirstName;
                dataGridViewPersonnel.Rows[i].Cells[2].Value = personnelList[i].LastName;
                dataGridViewPersonnel.Rows[i].Cells[3].Value = personnelList[i].Birthdate.ToString("dd-MM-yyy");
                dataGridViewPersonnel.Rows[i].Cells[4].Value = personnelList[i].BirthPlace;
                dataGridViewPersonnel.Rows[i].Cells[5].Value = personnelList[i].EducationalStatus;
                dataGridViewPersonnel.Rows[i].Cells[6].Value = personnelList[i].Occupation;
                dataGridViewPersonnel.Rows[i].Cells[7].Value = personnelList[i].StartDateOfEmployment.ToString("dd-MM-yyy");
                if (personnelList[i].TerminationDate.ToString("dd-MM-yyy") == "01-01-1900")
                {
                    dataGridViewPersonnel.Rows[i].Cells[8].Value = "-";
                }
                else
                {
                    dataGridViewPersonnel.Rows[i].Cells[8].Value = personnelList[i].TerminationDate.ToString("dd-MM-yyy");
                }
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



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                labelcontinue.Visible = Visible;
                dateTimePickerTerminationDate.Visible = Visible;
            }
            else if (!checkBox1.Checked)
            {
                labelcontinue.Visible = false;
                dateTimePickerTerminationDate.Visible = false;
            }

        }

        private void comboBoxBranch_SelectedIndexChanged(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxBranch.SelectedValue == null && comboBoxDepartment.SelectedValue == null && comboBoxUnit.SelectedValue == null)
            {
                MessageBox.Show("Tüm parametreleri seçtiğinizden emin olunuz!");
            }
            var result = _personnelService.GetPersonnelByBranchAndUnit(branch.BranchId, unit.UnitId).Data;
            datagridFill(result);
        }

        private void dataGridViewPersonnel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            personnel = new Personnel();
            personnel = _personnelService.GetPersonnelByBranchAndUnit(branch.BranchId, unit.UnitId).Data[dataGridViewPersonnel.SelectedRows[0].Index];

            textBoxFirstName.Text = personnel.FirstName;
            textBoxLastName.Text = personnel.LastName;
            textBoxOccupation.Text = personnel.Occupation;
            textBoxBirthPlace.Text = personnel.BirthPlace;
            textBoxTC.Text = personnel.IdentityNumber;
            dateTimePickerStartofEmployment.Value = personnel.StartDateOfEmployment;
            dateTimePickerBirthDate.Value = personnel.Birthdate;
            textBoxEducationalState.Text = personnel.EducationalStatus;
            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Personnel newpersonnel = new Personnel()
            {
                PersonnelId=personnel.PersonnelId,
                BranchId = _branchService.GetAll().Data[comboBoxBranch.SelectedIndex].BranchId,
                UnitId = _unitService.GetByDepartmentId(department.DepartmentId).Data[comboBoxUnit.SelectedIndex].UnitId,
                IdentityNumber = textBoxTC.Text,
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                Birthdate = dateTimePickerBirthDate.Value,
                StartDateOfEmployment = dateTimePickerStartofEmployment.Value,
                BirthPlace = textBoxBirthPlace.Text,
                EducationalStatus = textBoxEducationalState.Text,
                Occupation = textBoxOccupation.Text,
                IsActive = true,
            };
            if (checkBox1.Checked)
            {
                newpersonnel.TerminationDate = dateTimePickerTerminationDate.Value;
                newpersonnel.IsActive = false;
            }
            else if (!checkBox1.Checked)
            {
                newpersonnel.TerminationDate = new DateTime(1900, 001, 01);
            }
            if (_personnelService.Update(newpersonnel).Success)
            {
                MessageBox.Show("Personel Güncellendi");
            }

            base.Close();
        }
    }
}
