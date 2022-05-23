
namespace winFormUI.Forms
{
    partial class AssigmentPage
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
            this.dataGridViewAssigment = new System.Windows.Forms.DataGridView();
            this.AssigmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssigmentDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubmitedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Personnel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonnelFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonnelLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxUnit = new System.Windows.Forms.ComboBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.comboBoxBranch = new System.Windows.Forms.ComboBox();
            this.comboBoxAssigment = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssigment)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAssigment
            // 
            this.dataGridViewAssigment.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewAssigment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssigment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssigmentName,
            this.AssigmentDescription,
            this.Deadline,
            this.SubmitedDate,
            this.Personnel,
            this.PersonnelFirstName,
            this.PersonnelLastName,
            this.unit});
            this.dataGridViewAssigment.Location = new System.Drawing.Point(60, 93);
            this.dataGridViewAssigment.Name = "dataGridViewAssigment";
            this.dataGridViewAssigment.RowHeadersWidth = 51;
            this.dataGridViewAssigment.RowTemplate.Height = 29;
            this.dataGridViewAssigment.Size = new System.Drawing.Size(1404, 498);
            this.dataGridViewAssigment.TabIndex = 0;
            this.dataGridViewAssigment.Click += new System.EventHandler(this.dataGridViewAssigment_Click);
            // 
            // AssigmentName
            // 
            this.AssigmentName.HeaderText = "Görev Adı";
            this.AssigmentName.MinimumWidth = 6;
            this.AssigmentName.Name = "AssigmentName";
            this.AssigmentName.Width = 200;
            // 
            // AssigmentDescription
            // 
            this.AssigmentDescription.HeaderText = "Görev Tanımı";
            this.AssigmentDescription.MinimumWidth = 6;
            this.AssigmentDescription.Name = "AssigmentDescription";
            this.AssigmentDescription.Width = 350;
            // 
            // Deadline
            // 
            this.Deadline.HeaderText = "son teslim tarihi";
            this.Deadline.MinimumWidth = 6;
            this.Deadline.Name = "Deadline";
            this.Deadline.Width = 125;
            // 
            // SubmitedDate
            // 
            this.SubmitedDate.HeaderText = "Teslim Edilen tarih";
            this.SubmitedDate.MinimumWidth = 6;
            this.SubmitedDate.Name = "SubmitedDate";
            this.SubmitedDate.Width = 125;
            // 
            // Personnel
            // 
            this.Personnel.HeaderText = "Personel";
            this.Personnel.MinimumWidth = 6;
            this.Personnel.Name = "Personnel";
            this.Personnel.Width = 125;
            // 
            // PersonnelFirstName
            // 
            this.PersonnelFirstName.HeaderText = "İsmi";
            this.PersonnelFirstName.MinimumWidth = 6;
            this.PersonnelFirstName.Name = "PersonnelFirstName";
            this.PersonnelFirstName.Width = 150;
            // 
            // PersonnelLastName
            // 
            this.PersonnelLastName.HeaderText = "Soyisim";
            this.PersonnelLastName.MinimumWidth = 6;
            this.PersonnelLastName.Name = "PersonnelLastName";
            this.PersonnelLastName.Width = 150;
            // 
            // unit
            // 
            this.unit.HeaderText = "Birimi";
            this.unit.MinimumWidth = 6;
            this.unit.Name = "unit";
            this.unit.Width = 150;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.BtnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnUpdate.Location = new System.Drawing.Point(673, 976);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.BtnUpdate.Size = new System.Drawing.Size(143, 35);
            this.BtnUpdate.TabIndex = 16;
            this.BtnUpdate.Text = "Güncelle";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.BtnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAdd.Location = new System.Drawing.Point(1178, 664);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.BtnAdd.Size = new System.Drawing.Size(237, 35);
            this.BtnAdd.TabIndex = 15;
            this.BtnAdd.Text = "Görev Ekleme";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(112, 48);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(256, 28);
            this.comboBoxFilter.TabIndex = 17;
            this.comboBoxFilter.SelectedValueChanged += new System.EventHandler(this.comboBoxFilter_SelectedValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(719, 664);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.button1.Size = new System.Drawing.Size(143, 35);
            this.button1.TabIndex = 28;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxUnit
            // 
            this.comboBoxUnit.FormattingEnabled = true;
            this.comboBoxUnit.Location = new System.Drawing.Point(495, 671);
            this.comboBoxUnit.Name = "comboBoxUnit";
            this.comboBoxUnit.Size = new System.Drawing.Size(175, 28);
            this.comboBoxUnit.TabIndex = 27;
            this.comboBoxUnit.Text = "Birim Seçiniz";
            this.comboBoxUnit.SelectedIndexChanged += new System.EventHandler(this.comboBoxUnit_SelectedIndexChanged);
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(294, 671);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(175, 28);
            this.comboBoxDepartment.TabIndex = 26;
            this.comboBoxDepartment.Text = "Departman Seçiniz";
            this.comboBoxDepartment.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartment_SelectedIndexChanged);
            // 
            // comboBoxBranch
            // 
            this.comboBoxBranch.FormattingEnabled = true;
            this.comboBoxBranch.Location = new System.Drawing.Point(86, 671);
            this.comboBoxBranch.Name = "comboBoxBranch";
            this.comboBoxBranch.Size = new System.Drawing.Size(175, 28);
            this.comboBoxBranch.TabIndex = 25;
            this.comboBoxBranch.Text = "Şube Seçiniz";
            this.comboBoxBranch.SelectedValueChanged += new System.EventHandler(this.comboBoxBranch_SelectedValueChanged);
            // 
            // comboBoxAssigment
            // 
            this.comboBoxAssigment.FormattingEnabled = true;
            this.comboBoxAssigment.Location = new System.Drawing.Point(86, 781);
            this.comboBoxAssigment.Name = "comboBoxAssigment";
            this.comboBoxAssigment.Size = new System.Drawing.Size(330, 28);
            this.comboBoxAssigment.TabIndex = 29;
            this.comboBoxAssigment.Text = "Assigment Seçiniz";
            this.comboBoxAssigment.SelectedIndexChanged += new System.EventHandler(this.comboBoxAssigment_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(454, 777);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.button2.Size = new System.Drawing.Size(143, 35);
            this.button2.TabIndex = 30;
            this.button2.Text = "Listele";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(86, 743);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Görev ismine göre sorgulama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(86, 634);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Bölüm bilgilerine göre sorgulama";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(1178, 743);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.button3.Size = new System.Drawing.Size(237, 35);
            this.button3.TabIndex = 33;
            this.button3.Text = "Görev\'e Personel Atama ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(1178, 828);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.button4.Size = new System.Drawing.Size(237, 35);
            this.button4.TabIndex = 34;
            this.button4.Text = "Görev güncelleme";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AssigmentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1532, 955);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxAssigment);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxUnit);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.comboBoxBranch);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.dataGridViewAssigment);
            this.Name = "AssigmentPage";
            this.Text = "AssigmentPage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssigment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAssigment;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssigmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssigmentDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubmitedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Personnel;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonnelFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonnelLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxUnit;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.ComboBox comboBoxBranch;
        private System.Windows.Forms.ComboBox comboBoxAssigment;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}