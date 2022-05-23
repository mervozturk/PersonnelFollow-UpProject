
namespace winFormUI.Forms
{
    partial class Hompage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewAssigment = new System.Windows.Forms.DataGridView();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelNot = new System.Windows.Forms.Label();
            this.ColumnAssigmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAssigmentDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonnelFirtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonnelLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssigment)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAssigment
            // 
            this.dataGridViewAssigment.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewAssigment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAssigment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAssigment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssigment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAssigmentName,
            this.ColumnAssigmentDescription,
            this.ColumnDate,
            this.Column2,
            this.PersonnelFirtName,
            this.PersonnelLastName});
            this.dataGridViewAssigment.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewAssigment.Location = new System.Drawing.Point(115, 220);
            this.dataGridViewAssigment.Margin = new System.Windows.Forms.Padding(30);
            this.dataGridViewAssigment.MinimumSize = new System.Drawing.Size(200, 0);
            this.dataGridViewAssigment.Name = "dataGridViewAssigment";
            this.dataGridViewAssigment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAssigment.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAssigment.RowHeadersWidth = 51;
            this.dataGridViewAssigment.RowTemplate.Height = 29;
            this.dataGridViewAssigment.Size = new System.Drawing.Size(1378, 502);
            this.dataGridViewAssigment.TabIndex = 0;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelDate.Location = new System.Drawing.Point(668, 74);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(78, 32);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "label1";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNot
            // 
            this.labelNot.AutoSize = true;
            this.labelNot.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNot.Location = new System.Drawing.Point(688, 188);
            this.labelNot.Name = "labelNot";
            this.labelNot.Size = new System.Drawing.Size(193, 23);
            this.labelNot.TabIndex = 2;
            this.labelNot.Text = "Tamalanmamış Görevler";
            // 
            // ColumnAssigmentName
            // 
            this.ColumnAssigmentName.HeaderText = "Görev Adı";
            this.ColumnAssigmentName.MinimumWidth = 6;
            this.ColumnAssigmentName.Name = "ColumnAssigmentName";
            this.ColumnAssigmentName.Width = 250;
            // 
            // ColumnAssigmentDescription
            // 
            this.ColumnAssigmentDescription.HeaderText = "Görev Açıklaması";
            this.ColumnAssigmentDescription.MinimumWidth = 6;
            this.ColumnAssigmentDescription.Name = "ColumnAssigmentDescription";
            this.ColumnAssigmentDescription.Width = 500;
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "Son teslim tarihi";
            this.ColumnDate.MinimumWidth = 6;
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Personel";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // PersonnelFirtName
            // 
            this.PersonnelFirtName.HeaderText = "İsim";
            this.PersonnelFirtName.MinimumWidth = 6;
            this.PersonnelFirtName.Name = "PersonnelFirtName";
            this.PersonnelFirtName.Width = 150;
            // 
            // PersonnelLastName
            // 
            this.PersonnelLastName.HeaderText = "Soyisim";
            this.PersonnelLastName.MinimumWidth = 6;
            this.PersonnelLastName.Name = "PersonnelLastName";
            this.PersonnelLastName.Width = 150;
            // 
            // Hompage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1582, 776);
            this.Controls.Add(this.labelNot);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dataGridViewAssigment);
            this.Name = "Hompage";
            this.Text = "Hompage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssigment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAssigment;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelNot;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAssigmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAssigmentDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonnelFirtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonnelLastName;
    }
}