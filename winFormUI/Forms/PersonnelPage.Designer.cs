
namespace winFormUI.Forms
{
    partial class PersonnelPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewPersonnel = new System.Windows.Forms.DataGridView();
            this.IdentityNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EducationalStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Occupation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDateOfEmployment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.comboBoxListed = new System.Windows.Forms.ComboBox();
            this.comboBoxUnit = new System.Windows.Forms.ComboBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.comboBoxBranch = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPersonnel
            // 
            this.dataGridViewPersonnel.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonnel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdentityNumber,
            this.FirstName,
            this.LastName,
            this.Birthdate,
            this.BirthPlace,
            this.EducationalStatus,
            this.Occupation,
            this.StartDateOfEmployment,
            this.Column1});
            this.dataGridViewPersonnel.Location = new System.Drawing.Point(179, 150);
            this.dataGridViewPersonnel.Name = "dataGridViewPersonnel";
            this.dataGridViewPersonnel.RowHeadersWidth = 51;
            this.dataGridViewPersonnel.RowTemplate.Height = 29;
            this.dataGridViewPersonnel.Size = new System.Drawing.Size(1160, 504);
            this.dataGridViewPersonnel.TabIndex = 0;
            this.dataGridViewPersonnel.Click += new System.EventHandler(this.dataGridViewPersonnel_Click);
            // 
            // IdentityNumber
            // 
            this.IdentityNumber.HeaderText = "TC";
            this.IdentityNumber.MinimumWidth = 11;
            this.IdentityNumber.Name = "IdentityNumber";
            this.IdentityNumber.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "İsim";
            this.FirstName.MinimumWidth = 10;
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Soyİsim";
            this.LastName.MinimumWidth = 10;
            this.LastName.Name = "LastName";
            this.LastName.Width = 125;
            // 
            // Birthdate
            // 
            this.Birthdate.HeaderText = "Doğum tarihi";
            this.Birthdate.MinimumWidth = 6;
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.Width = 125;
            // 
            // BirthPlace
            // 
            this.BirthPlace.HeaderText = "Doğum yeri";
            this.BirthPlace.MinimumWidth = 10;
            this.BirthPlace.Name = "BirthPlace";
            this.BirthPlace.Width = 125;
            // 
            // EducationalStatus
            // 
            this.EducationalStatus.HeaderText = "Eğitim Durumu";
            this.EducationalStatus.MinimumWidth = 10;
            this.EducationalStatus.Name = "EducationalStatus";
            this.EducationalStatus.Width = 125;
            // 
            // Occupation
            // 
            this.Occupation.HeaderText = "Meslek";
            this.Occupation.MinimumWidth = 10;
            this.Occupation.Name = "Occupation";
            this.Occupation.Width = 125;
            // 
            // StartDateOfEmployment
            // 
            this.StartDateOfEmployment.HeaderText = "İşe başlama tarihi";
            this.StartDateOfEmployment.MinimumWidth = 6;
            this.StartDateOfEmployment.Name = "StartDateOfEmployment";
            this.StartDateOfEmployment.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "İşten Çıkış";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.BtnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAdd.Location = new System.Drawing.Point(1366, 270);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.BtnAdd.Size = new System.Drawing.Size(143, 35);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "Ekleme";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.BtnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnUpdate.Location = new System.Drawing.Point(1366, 364);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.BtnUpdate.Size = new System.Drawing.Size(143, 35);
            this.BtnUpdate.TabIndex = 7;
            this.BtnUpdate.Text = "Güncelle";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // comboBoxListed
            // 
            this.comboBoxListed.FormattingEnabled = true;
            this.comboBoxListed.Location = new System.Drawing.Point(197, 78);
            this.comboBoxListed.Name = "comboBoxListed";
            this.comboBoxListed.Size = new System.Drawing.Size(129, 28);
            this.comboBoxListed.TabIndex = 8;
            this.comboBoxListed.Text = "Seçiniz";
            this.comboBoxListed.SelectedValueChanged += new System.EventHandler(this.comboBoxListed_SelectedValueChanged);
            // 
            // comboBoxUnit
            // 
            this.comboBoxUnit.FormattingEnabled = true;
            this.comboBoxUnit.Location = new System.Drawing.Point(588, 697);
            this.comboBoxUnit.Name = "comboBoxUnit";
            this.comboBoxUnit.Size = new System.Drawing.Size(175, 28);
            this.comboBoxUnit.TabIndex = 23;
            this.comboBoxUnit.Text = "Birim Seçiniz";
            this.comboBoxUnit.SelectedValueChanged += new System.EventHandler(this.comboBoxUnit_SelectedValueChanged);
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(387, 697);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(175, 28);
            this.comboBoxDepartment.TabIndex = 22;
            this.comboBoxDepartment.Text = "Departman Seçiniz";
            this.comboBoxDepartment.SelectedValueChanged += new System.EventHandler(this.comboBoxDepartment_SelectedValueChanged_1);
            // 
            // comboBoxBranch
            // 
            this.comboBoxBranch.FormattingEnabled = true;
            this.comboBoxBranch.Location = new System.Drawing.Point(179, 697);
            this.comboBoxBranch.Name = "comboBoxBranch";
            this.comboBoxBranch.Size = new System.Drawing.Size(175, 28);
            this.comboBoxBranch.TabIndex = 21;
            this.comboBoxBranch.Text = "Şube Seçiniz";
            this.comboBoxBranch.SelectedValueChanged += new System.EventHandler(this.comboBoxBranch_SelectedValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(828, 693);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.button1.Size = new System.Drawing.Size(143, 35);
            this.button1.TabIndex = 24;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PersonnelPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1534, 776);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxUnit);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.comboBoxBranch);
            this.Controls.Add(this.comboBoxListed);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.dataGridViewPersonnel);
            this.Name = "PersonnelPage";
            this.Text = "PersonnelPage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonnel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPersonnel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentityNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn EducationalStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Occupation;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDateOfEmployment;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.ComboBox comboBoxListed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ComboBox comboBoxUnit;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.ComboBox comboBoxBranch;
        private System.Windows.Forms.Button button1;
    }
}