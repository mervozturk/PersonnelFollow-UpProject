
namespace winFormUI.Forms
{
    partial class Personnelupdate
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
            this.comboBoxUnit = new System.Windows.Forms.ComboBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.comboBoxBranch = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxOccupation = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerStartofEmployment = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBirthPlace = new System.Windows.Forms.TextBox();
            this.textBoxEducationalState = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxTC = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelcontinue = new System.Windows.Forms.Label();
            this.dateTimePickerTerminationDate = new System.Windows.Forms.DateTimePicker();
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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxUnit
            // 
            this.comboBoxUnit.FormattingEnabled = true;
            this.comboBoxUnit.Location = new System.Drawing.Point(469, 61);
            this.comboBoxUnit.Name = "comboBoxUnit";
            this.comboBoxUnit.Size = new System.Drawing.Size(175, 28);
            this.comboBoxUnit.TabIndex = 40;
            this.comboBoxUnit.Text = "Birim Seçiniz";
            this.comboBoxUnit.SelectedIndexChanged += new System.EventHandler(this.comboBoxUnit_SelectedIndexChanged);
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(262, 61);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(175, 28);
            this.comboBoxDepartment.TabIndex = 39;
            this.comboBoxDepartment.Text = "Departman Seçiniz";
            this.comboBoxDepartment.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartment_SelectedIndexChanged);
            // 
            // comboBoxBranch
            // 
            this.comboBoxBranch.FormattingEnabled = true;
            this.comboBoxBranch.Location = new System.Drawing.Point(42, 61);
            this.comboBoxBranch.Name = "comboBoxBranch";
            this.comboBoxBranch.Size = new System.Drawing.Size(175, 28);
            this.comboBoxBranch.TabIndex = 38;
            this.comboBoxBranch.Text = "Şube Seçiniz";
            this.comboBoxBranch.SelectedIndexChanged += new System.EventHandler(this.comboBoxBranch_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1201, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Meslek";
            // 
            // textBoxOccupation
            // 
            this.textBoxOccupation.Location = new System.Drawing.Point(1201, 323);
            this.textBoxOccupation.Name = "textBoxOccupation";
            this.textBoxOccupation.Size = new System.Drawing.Size(250, 27);
            this.textBoxOccupation.TabIndex = 36;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.buttonUpdate.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonUpdate.Location = new System.Drawing.Point(1004, 594);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(269, 45);
            this.buttonUpdate.TabIndex = 35;
            this.buttonUpdate.Text = "Güncelle";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1201, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "İşe Başlama tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1201, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Doğum Tarihi";
            // 
            // dateTimePickerStartofEmployment
            // 
            this.dateTimePickerStartofEmployment.Location = new System.Drawing.Point(1201, 386);
            this.dateTimePickerStartofEmployment.Name = "dateTimePickerStartofEmployment";
            this.dateTimePickerStartofEmployment.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerStartofEmployment.TabIndex = 32;
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(1201, 235);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerBirthDate.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1201, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Doğum yeri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(914, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Eğitim Durumu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(914, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Soyisim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(914, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "İsim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(914, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "TC kimlik Numarası";
            // 
            // textBoxBirthPlace
            // 
            this.textBoxBirthPlace.Location = new System.Drawing.Point(1201, 156);
            this.textBoxBirthPlace.Name = "textBoxBirthPlace";
            this.textBoxBirthPlace.Size = new System.Drawing.Size(250, 27);
            this.textBoxBirthPlace.TabIndex = 25;
            // 
            // textBoxEducationalState
            // 
            this.textBoxEducationalState.Location = new System.Drawing.Point(914, 376);
            this.textBoxEducationalState.Name = "textBoxEducationalState";
            this.textBoxEducationalState.Size = new System.Drawing.Size(218, 27);
            this.textBoxEducationalState.TabIndex = 24;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(914, 302);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(218, 27);
            this.textBoxLastName.TabIndex = 23;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(914, 225);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(218, 27);
            this.textBoxFirstName.TabIndex = 22;
            // 
            // textBoxTC
            // 
            this.textBoxTC.Location = new System.Drawing.Point(914, 158);
            this.textBoxTC.Name = "textBoxTC";
            this.textBoxTC.Size = new System.Drawing.Size(218, 27);
            this.textBoxTC.TabIndex = 21;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1201, 441);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(180, 24);
            this.checkBox1.TabIndex = 41;
            this.checkBox1.Text = "Personel işten çıktı mı?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // labelcontinue
            // 
            this.labelcontinue.AutoSize = true;
            this.labelcontinue.Location = new System.Drawing.Point(1201, 477);
            this.labelcontinue.Name = "labelcontinue";
            this.labelcontinue.Size = new System.Drawing.Size(110, 20);
            this.labelcontinue.TabIndex = 43;
            this.labelcontinue.Text = "İşten çıkış tarihi";
            this.labelcontinue.Visible = false;
            // 
            // dateTimePickerTerminationDate
            // 
            this.dateTimePickerTerminationDate.Location = new System.Drawing.Point(1201, 509);
            this.dateTimePickerTerminationDate.Name = "dateTimePickerTerminationDate";
            this.dateTimePickerTerminationDate.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerTerminationDate.TabIndex = 42;
            this.dateTimePickerTerminationDate.Visible = false;
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
            this.dataGridViewPersonnel.Location = new System.Drawing.Point(53, 125);
            this.dataGridViewPersonnel.Name = "dataGridViewPersonnel";
            this.dataGridViewPersonnel.RowHeadersWidth = 51;
            this.dataGridViewPersonnel.RowTemplate.Height = 29;
            this.dataGridViewPersonnel.Size = new System.Drawing.Size(663, 504);
            this.dataGridViewPersonnel.TabIndex = 44;
            this.dataGridViewPersonnel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPersonnel_CellContentClick);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(685, 54);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.button1.Size = new System.Drawing.Size(143, 35);
            this.button1.TabIndex = 45;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Personnelupdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1641, 729);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewPersonnel);
            this.Controls.Add(this.labelcontinue);
            this.Controls.Add(this.dateTimePickerTerminationDate);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBoxUnit);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.comboBoxBranch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxOccupation);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerStartofEmployment);
            this.Controls.Add(this.dateTimePickerBirthDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBirthPlace);
            this.Controls.Add(this.textBoxEducationalState);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxTC);
            this.Name = "Personnelupdate";
            this.Text = "Personnelupdate";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonnel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUnit;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.ComboBox comboBoxBranch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxOccupation;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartofEmployment;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBirthPlace;
        private System.Windows.Forms.TextBox textBoxEducationalState;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxTC;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label labelcontinue;
        private System.Windows.Forms.DateTimePicker dateTimePickerTerminationDate;
        private System.Windows.Forms.DataGridView dataGridViewPersonnel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentityNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn EducationalStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Occupation;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDateOfEmployment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button button1;
    }
}