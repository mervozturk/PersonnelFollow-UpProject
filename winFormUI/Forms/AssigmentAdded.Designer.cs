
namespace winFormUI.Forms
{
    partial class AssigmentAdded
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
            this.textBoxAssigmentName = new System.Windows.Forms.TextBox();
            this.textBoxAssigmentDescription = new System.Windows.Forms.TextBox();
            this.dateTimePickerDeadline = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxUnit
            // 
            this.comboBoxUnit.FormattingEnabled = true;
            this.comboBoxUnit.Location = new System.Drawing.Point(111, 205);
            this.comboBoxUnit.Name = "comboBoxUnit";
            this.comboBoxUnit.Size = new System.Drawing.Size(175, 28);
            this.comboBoxUnit.TabIndex = 23;
            this.comboBoxUnit.Text = "Birim Seçiniz";
            this.comboBoxUnit.SelectedIndexChanged += new System.EventHandler(this.comboBoxUnit_SelectedIndexChanged);
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(111, 136);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(175, 28);
            this.comboBoxDepartment.TabIndex = 22;
            this.comboBoxDepartment.Text = "Departman Seçiniz";
            this.comboBoxDepartment.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartment_SelectedIndexChanged);
            // 
            // comboBoxBranch
            // 
            this.comboBoxBranch.FormattingEnabled = true;
            this.comboBoxBranch.Location = new System.Drawing.Point(111, 67);
            this.comboBoxBranch.Name = "comboBoxBranch";
            this.comboBoxBranch.Size = new System.Drawing.Size(175, 28);
            this.comboBoxBranch.TabIndex = 21;
            this.comboBoxBranch.Text = "Şube Seçiniz";
            this.comboBoxBranch.SelectedValueChanged += new System.EventHandler(this.comboBoxBranch_SelectedValueChanged);
            // 
            // textBoxAssigmentName
            // 
            this.textBoxAssigmentName.Location = new System.Drawing.Point(378, 71);
            this.textBoxAssigmentName.Name = "textBoxAssigmentName";
            this.textBoxAssigmentName.Size = new System.Drawing.Size(238, 27);
            this.textBoxAssigmentName.TabIndex = 24;
            // 
            // textBoxAssigmentDescription
            // 
            this.textBoxAssigmentDescription.Location = new System.Drawing.Point(378, 146);
            this.textBoxAssigmentDescription.Multiline = true;
            this.textBoxAssigmentDescription.Name = "textBoxAssigmentDescription";
            this.textBoxAssigmentDescription.Size = new System.Drawing.Size(406, 150);
            this.textBoxAssigmentDescription.TabIndex = 25;
            // 
            // dateTimePickerDeadline
            // 
            this.dateTimePickerDeadline.Location = new System.Drawing.Point(378, 354);
            this.dateTimePickerDeadline.Name = "dateTimePickerDeadline";
            this.dateTimePickerDeadline.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerDeadline.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Görev Adı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Görev Tanımı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Son teslim tarihi";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(313, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 40);
            this.button1.TabIndex = 31;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AssigmentAdded
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(929, 571);
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
            this.Name = "AssigmentAdded";
            this.Text = "AssigmentAdded";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUnit;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.ComboBox comboBoxBranch;
        private System.Windows.Forms.TextBox textBoxAssigmentName;
        private System.Windows.Forms.TextBox textBoxAssigmentDescription;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeadline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}