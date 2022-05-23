
namespace winFormUI.Forms
{
    partial class PersonnelAssigment
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
            this.labelAssigment = new System.Windows.Forms.Label();
            this.labelPersonnel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewPersonnel = new System.Windows.Forms.DataGridView();
            this.IdentityNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Occupation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDateOfEmployment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewAssigment = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxUnit = new System.Windows.Forms.ComboBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.comboBoxBranch = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonnel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssigment)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAssigment
            // 
            this.labelAssigment.AutoSize = true;
            this.labelAssigment.Location = new System.Drawing.Point(1051, 329);
            this.labelAssigment.Name = "labelAssigment";
            this.labelAssigment.Size = new System.Drawing.Size(50, 20);
            this.labelAssigment.TabIndex = 3;
            this.labelAssigment.Text = "label1";
            this.labelAssigment.Visible = false;
            // 
            // labelPersonnel
            // 
            this.labelPersonnel.AutoSize = true;
            this.labelPersonnel.Location = new System.Drawing.Point(1051, 648);
            this.labelPersonnel.Name = "labelPersonnel";
            this.labelPersonnel.Size = new System.Drawing.Size(50, 20);
            this.labelPersonnel.TabIndex = 4;
            this.labelPersonnel.Text = "label2";
            this.labelPersonnel.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1051, 782);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.button1.Size = new System.Drawing.Size(230, 48);
            this.button1.TabIndex = 29;
            this.button1.Text = "Görevi PersoneleAta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dataGridViewPersonnel.Location = new System.Drawing.Point(116, 551);
            this.dataGridViewPersonnel.Name = "dataGridViewPersonnel";
            this.dataGridViewPersonnel.RowHeadersWidth = 51;
            this.dataGridViewPersonnel.RowTemplate.Height = 29;
            this.dataGridViewPersonnel.Size = new System.Drawing.Size(717, 370);
            this.dataGridViewPersonnel.TabIndex = 30;
            this.dataGridViewPersonnel.Click += new System.EventHandler(this.dataGridViewPersonnel_Click);
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
            // dataGridViewAssigment
            // 
            this.dataGridViewAssigment.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewAssigment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssigment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.deadline});
            this.dataGridViewAssigment.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewAssigment.Location = new System.Drawing.Point(116, 169);
            this.dataGridViewAssigment.Name = "dataGridViewAssigment";
            this.dataGridViewAssigment.RowHeadersWidth = 51;
            this.dataGridViewAssigment.RowTemplate.Height = 29;
            this.dataGridViewAssigment.Size = new System.Drawing.Size(705, 328);
            this.dataGridViewAssigment.TabIndex = 31;
            this.dataGridViewAssigment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridViewAssigment.Click += new System.EventHandler(this.dataGridViewAssigment_Click);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Görev Adı";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Görev Açıklaması";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 300;
            // 
            // deadline
            // 
            this.deadline.HeaderText = "Son teslim tarihi";
            this.deadline.MinimumWidth = 6;
            this.deadline.Name = "deadline";
            this.deadline.Width = 150;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(721, 65);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.button2.Size = new System.Drawing.Size(143, 35);
            this.button2.TabIndex = 35;
            this.button2.Text = "Listele";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxUnit
            // 
            this.comboBoxUnit.FormattingEnabled = true;
            this.comboBoxUnit.Location = new System.Drawing.Point(481, 69);
            this.comboBoxUnit.Name = "comboBoxUnit";
            this.comboBoxUnit.Size = new System.Drawing.Size(175, 28);
            this.comboBoxUnit.TabIndex = 34;
            this.comboBoxUnit.Text = "Birim Seçiniz";
            this.comboBoxUnit.SelectedIndexChanged += new System.EventHandler(this.comboBoxUnit_SelectedIndexChanged);
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(280, 69);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(175, 28);
            this.comboBoxDepartment.TabIndex = 33;
            this.comboBoxDepartment.Text = "Departman Seçiniz";
            this.comboBoxDepartment.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartment_SelectedIndexChanged);
            // 
            // comboBoxBranch
            // 
            this.comboBoxBranch.FormattingEnabled = true;
            this.comboBoxBranch.Location = new System.Drawing.Point(72, 69);
            this.comboBoxBranch.Name = "comboBoxBranch";
            this.comboBoxBranch.Size = new System.Drawing.Size(175, 28);
            this.comboBoxBranch.TabIndex = 32;
            this.comboBoxBranch.Text = "Şube Seçiniz";
            this.comboBoxBranch.SelectedValueChanged += new System.EventHandler(this.comboBoxBranch_SelectedValueChanged);
            // 
            // PersonnelAssigment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1547, 937);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxUnit);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.comboBoxBranch);
            this.Controls.Add(this.dataGridViewAssigment);
            this.Controls.Add(this.dataGridViewPersonnel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelPersonnel);
            this.Controls.Add(this.labelAssigment);
            this.Name = "PersonnelAssigment";
            this.Text = "PersonnelAssigment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonnel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssigment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAssigment;
        private System.Windows.Forms.Label labelPersonnel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewPersonnel;
        private System.Windows.Forms.DataGridView dataGridViewAssigment;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentityNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Occupation;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDateOfEmployment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadline;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxUnit;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.ComboBox comboBoxBranch;
    }
}