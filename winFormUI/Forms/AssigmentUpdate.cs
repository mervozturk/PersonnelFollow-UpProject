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
    public partial class AssigmentUpdate : Form
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
        
        public AssigmentUpdate()
        {
            InitializeComponent();
            _assigmentService = new AssigmentManager(new EfAssigmentDal());
            _personnelService = new PersonnelManager(new EfPersonnelDal());
            _branchService = new BranchManager(new EfBranchDal());
            _departmentService = new DepartmentManager(new EfDepartmentDal());
            _unitService = new UnitManager(new EfUnitDal());
            _assigment_PersonnelService = new Assigment_PersonnelManager(new EfAssigment_PersonnelDal());
            comboBoxBranch.DataSource = BranchName();
            comboBoxDepartment.DataSource = DepartmentName();
            dataGridViewPersonnel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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

        private List<string> AssigmentsName()
        {
            List<string> name = new List<string>();
            foreach (var item in _assigmentService.GetAllActive(branch.BranchId,unit.UnitId).Data)
            {
                name.Add(item.AssigmentName);
            }
            return name;
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
            comboBoxAssigmentName.DataSource = AssigmentsName();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBoxBranch.SelectedValue == null && comboBoxDepartment.SelectedValue == null && comboBoxUnit.SelectedValue == null)
            {
                MessageBox.Show("Tüm parametreleri seçtiğinizden emin olunuz!");
            }
            var resultPersonnel = _assigment_PersonnelService.GetPersonByAssigmentId(assigment.AssigmentId).Data;
            DataGridFillPersonnel(resultPersonnel);
            textBoxAssigmentName.Text = assigment.AssigmentName;
            textBoxAssigmentDescription.Text = assigment.AssigmentDescription;
            dateTimePickerDeadline.Value = assigment.Deadline;
        }

        private void comboBoxAssigmentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            assigment = new Assigment();
            assigment = _assigmentService.GetAllActive(branch.BranchId, unit.UnitId).Data[comboBoxAssigmentName.SelectedIndex];
        }

        private void checkBoxSubmited_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSubmited.Checked)
            {
                labelsubmited.Visible = Visible;
                dateTimePickersubmited.Visible = Visible;
            }
            else if (!checkBoxSubmited.Checked)
            {
                labelsubmited.Visible = false;
                dateTimePickersubmited.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Assigment UpdateAssigment = new Assigment()
            {
                AssigmentId = assigment.AssigmentId,
                AssigmentName = textBoxAssigmentName.Text,
                AssigmentDescription = textBoxAssigmentDescription.Text,
                BranchId = branch.BranchId,
                UnitId = unit.UnitId,
                Deadline = dateTimePickerDeadline.Value
            };
            if (checkBoxSubmited.Checked)
            {
                UpdateAssigment.SubmittedDate = dateTimePickersubmited.Value;
                UpdateAssigment.IsActive = false;
            }
            if (_assigmentService.Update(UpdateAssigment).Success)
            {
                MessageBox.Show("Görev güncellendi.");
            }
            base.Close();
        }

        private void dataGridViewPersonnel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            personnel = new Personnel();
            personnel = _assigment_PersonnelService.GetPersonByAssigmentId(assigment.AssigmentId).Data[dataGridViewPersonnel.SelectedRows[0].Index];
            DialogResult dialogResult = MessageBox.Show("Bu personeli bu görevden çıkartmak ister miniz?", "Personnel Çıkartma", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
               Assigment_Personnel assigment_Personnel = _assigment_PersonnelService.GetAssigment_Personnel(assigment.AssigmentId, personnel.PersonnelId).Data;
                _assigment_PersonnelService.Delete(assigment_Personnel);
                var resultPersonnel = _assigment_PersonnelService.GetPersonByAssigmentId(assigment.AssigmentId).Data;
                DataGridFillPersonnel(resultPersonnel);
            }
        }
    }
}
