
namespace winFormUI.Forms
{
    partial class AssigmentUpdate
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDeadline = new System.Windows.Forms.DateTimePicker();
            this.textBoxAssigmentDescription = new System.Windows.Forms.TextBox();
            this.textBoxAssigmentName = new System.Windows.Forms.TextBox();
            this.dateTimePickersubmited = new System.Windows.Forms.DateTimePicker();
            this.labelsubmited = new System.Windows.Forms.Label();
            this.checkBoxSubmited = new System.Windows.Forms.CheckBox();
            this.comboBoxAssigmentName = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridViewPersonnel = new System.Windows.Forms.DataGridView();
            this.IdentityNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Occupation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDateOfEmployment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxUnit
            // 
            this.comboBoxUnit.FormattingEnabled = true;
            this.comboBoxUnit.Location = new System.Drawing.Point(444, 96);
            this.comboBoxUnit.Name = "comboBoxUnit";
            this.comboBoxUnit.Size = new System.Drawing.Size(175, 28);
            this.comboBoxUnit.TabIndex = 39;
            this.comboBoxUnit.Text = "Birim Seçiniz";
            this.comboBoxUnit.SelectedIndexChanged += new System.EventHandler(this.comboBoxUnit_SelectedIndexChanged);
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(243, 96);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(175, 28);
            this.comboBoxDepartment.TabIndex = 38;
            this.comboBoxDepartment.Text = "Departman Seçiniz";
            this.comboBoxDepartment.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartment_SelectedIndexChanged);
            // 
            // comboBoxBranch
            // 
            this.comboBoxBranch.FormattingEnabled = true;
            this.comboBoxBranch.Location = new System.Drawing.Point(35, 96);
            this.comboBoxBranch.Name = "comboBoxBranch";
            this.comboBoxBranch.Size = new System.Drawing.Size(175, 28);
            this.comboBoxBranch.TabIndex = 37;
            this.comboBoxBranch.Text = "Şube Seçiniz";
            this.comboBoxBranch.SelectedIndexChanged += new System.EventHandler(this.comboBoxBranch_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(1012, 573);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 40);
            this.button1.TabIndex = 47;
            this.button1.Text = "Güncelleme";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(936, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Son teslim tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(936, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Görev Tanımı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(936, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Görev Adı";
            // 
            // dateTimePickerDeadline
            // 
            this.dateTimePickerDeadline.Location = new System.Drawing.Point(936, 404);
            this.dateTimePickerDeadline.Name = "dateTimePickerDeadline";
            this.dateTimePickerDeadline.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerDeadline.TabIndex = 43;
            // 
            // textBoxAssigmentDescription
            // 
            this.textBoxAssigmentDescription.Location = new System.Drawing.Point(936, 196);
            this.textBoxAssigmentDescription.Multiline = true;
            this.textBoxAssigmentDescription.Name = "textBoxAssigmentDescription";
            this.textBoxAssigmentDescription.Size = new System.Drawing.Size(406, 150);
            this.textBoxAssigmentDescription.TabIndex = 42;
            // 
            // textBoxAssigmentName
            // 
            this.textBoxAssigmentName.Location = new System.Drawing.Point(936, 121);
            this.textBoxAssigmentName.Name = "textBoxAssigmentName";
            this.textBoxAssigmentName.Size = new System.Drawing.Size(238, 27);
            this.textBoxAssigmentName.TabIndex = 41;
            // 
            // dateTimePickersubmited
            // 
            this.dateTimePickersubmited.Location = new System.Drawing.Point(1125, 497);
            this.dateTimePickersubmited.Name = "dateTimePickersubmited";
            this.dateTimePickersubmited.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickersubmited.TabIndex = 48;
            this.dateTimePickersubmited.Visible = false;
            // 
            // labelsubmited
            // 
            this.labelsubmited.AutoSize = true;
            this.labelsubmited.Location = new System.Drawing.Point(1125, 461);
            this.labelsubmited.Name = "labelsubmited";
            this.labelsubmited.Size = new System.Drawing.Size(124, 20);
            this.labelsubmited.TabIndex = 49;
            this.labelsubmited.Text = "Telim edilen tarih";
            this.labelsubmited.Visible = false;
            // 
            // checkBoxSubmited
            // 
            this.checkBoxSubmited.AutoSize = true;
            this.checkBoxSubmited.Location = new System.Drawing.Point(936, 481);
            this.checkBoxSubmited.Name = "checkBoxSubmited";
            this.checkBoxSubmited.Size = new System.Drawing.Size(169, 24);
            this.checkBoxSubmited.TabIndex = 50;
            this.checkBoxSubmited.Text = "Görev tamalandı mı?";
            this.checkBoxSubmited.UseVisualStyleBackColor = true;
            this.checkBoxSubmited.CheckedChanged += new System.EventHandler(this.checkBoxSubmited_CheckedChanged);
            // 
            // comboBoxAssigmentName
            // 
            this.comboBoxAssigmentName.FormattingEnabled = true;
            this.comboBoxAssigmentName.Location = new System.Drawing.Point(35, 170);
            this.comboBoxAssigmentName.Name = "comboBoxAssigmentName";
            this.comboBoxAssigmentName.Size = new System.Drawing.Size(486, 28);
            this.comboBoxAssigmentName.TabIndex = 51;
            this.comboBoxAssigmentName.SelectedIndexChanged += new System.EventHandler(this.comboBoxAssigmentName_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(602, 170);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.button3.Size = new System.Drawing.Size(143, 35);
            this.button3.TabIndex = 52;
            this.button3.Text = "Listele";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridViewPersonnel
            // 
            this.dataGridViewPersonnel.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonnel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdentityNumber,
            this.FirstName,
            this.LastName,
            this.Occupation,
            this.StartDateOfEmployment});
            this.dataGridViewPersonnel.Location = new System.Drawing.Point(35, 243);
            this.dataGridViewPersonnel.Name = "dataGridViewPersonnel";
            this.dataGridViewPersonnel.RowHeadersWidth = 51;
            this.dataGridViewPersonnel.RowTemplate.Height = 29;
            this.dataGridViewPersonnel.Size = new System.Drawing.Size(717, 370);
            this.dataGridViewPersonnel.TabIndex = 53;
            this.dataGridViewPersonnel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPersonnel_CellContentClick);
            // 
            // IdentityNumber
            // 
            this.IdentityNumber.HeaderText = "TC";
            this.IdentityNumber.MinimumWidth = 11;
            this.IdentityNumber.Name = "IdentityNumber";
            this.IdentityNumber.Width = 175;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "Görev Adı";
            // 
            // AssigmentUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1441, 709);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewPersonnel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBoxAssigmentName);
            this.Controls.Add(this.checkBoxSubmited);
            this.Controls.Add(this.labelsubmited);
            this.Controls.Add(this.dateTimePickersubmited);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerDeadline);
            this.Controls.Add(this.textBoxAssigmentDescription);
            this.Controls.Add(this.textBoxAssigmentName);
            this.Controls.Add(this.comboBoxUnit);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.comboBoxBranch);
            this.Name = "AssigmentUpdate";
            this.Text = "AssigmentUpdate";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonnel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxUnit;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.ComboBox comboBoxBranch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeadline;
        private System.Windows.Forms.TextBox textBoxAssigmentDescription;
        private System.Windows.Forms.TextBox textBoxAssigmentName;
        private System.Windows.Forms.DateTimePicker dateTimePickersubmited;
        private System.Windows.Forms.Label labelsubmited;
        private System.Windows.Forms.CheckBox checkBoxSubmited;
        private System.Windows.Forms.ComboBox comboBoxAssigmentName;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridViewPersonnel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentityNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Occupation;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDateOfEmployment;
        private System.Windows.Forms.Label label5;
    }
}