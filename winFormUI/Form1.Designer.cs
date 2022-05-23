
namespace winFormUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.AssigmentPage = new FontAwesome.Sharp.IconButton();
            this.PersonnelPage = new FontAwesome.Sharp.IconButton();
            this.HomePage = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.welcomBtn = new FontAwesome.Sharp.IconButton();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDeskop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.AssigmentPage);
            this.panelMenu.Controls.Add(this.PersonnelPage);
            this.panelMenu.Controls.Add(this.HomePage);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 953);
            this.panelMenu.TabIndex = 0;
            // 
            // AssigmentPage
            // 
            this.AssigmentPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.AssigmentPage.FlatAppearance.BorderSize = 0;
            this.AssigmentPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AssigmentPage.ForeColor = System.Drawing.Color.Gainsboro;
            this.AssigmentPage.IconChar = FontAwesome.Sharp.IconChar.Paste;
            this.AssigmentPage.IconColor = System.Drawing.Color.Gainsboro;
            this.AssigmentPage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AssigmentPage.IconSize = 32;
            this.AssigmentPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AssigmentPage.Location = new System.Drawing.Point(0, 260);
            this.AssigmentPage.Name = "AssigmentPage";
            this.AssigmentPage.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.AssigmentPage.Size = new System.Drawing.Size(220, 60);
            this.AssigmentPage.TabIndex = 3;
            this.AssigmentPage.Text = "Görevler";
            this.AssigmentPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AssigmentPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AssigmentPage.UseVisualStyleBackColor = true;
            this.AssigmentPage.Click += new System.EventHandler(this.AssigmentPage_Click);
            // 
            // PersonnelPage
            // 
            this.PersonnelPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.PersonnelPage.FlatAppearance.BorderSize = 0;
            this.PersonnelPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PersonnelPage.ForeColor = System.Drawing.Color.Gainsboro;
            this.PersonnelPage.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.PersonnelPage.IconColor = System.Drawing.Color.Gainsboro;
            this.PersonnelPage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PersonnelPage.IconSize = 32;
            this.PersonnelPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PersonnelPage.Location = new System.Drawing.Point(0, 200);
            this.PersonnelPage.Name = "PersonnelPage";
            this.PersonnelPage.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.PersonnelPage.Size = new System.Drawing.Size(220, 60);
            this.PersonnelPage.TabIndex = 1;
            this.PersonnelPage.Text = "Personel";
            this.PersonnelPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PersonnelPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PersonnelPage.UseVisualStyleBackColor = true;
            this.PersonnelPage.Click += new System.EventHandler(this.PersonnelPage_Click);
            // 
            // HomePage
            // 
            this.HomePage.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomePage.FlatAppearance.BorderSize = 0;
            this.HomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomePage.ForeColor = System.Drawing.Color.Gainsboro;
            this.HomePage.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            this.HomePage.IconColor = System.Drawing.Color.Gainsboro;
            this.HomePage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HomePage.IconSize = 32;
            this.HomePage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomePage.Location = new System.Drawing.Point(0, 140);
            this.HomePage.Name = "HomePage";
            this.HomePage.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.HomePage.Size = new System.Drawing.Size(220, 60);
            this.HomePage.TabIndex = 0;
            this.HomePage.Text = "Anasayfa";
            this.HomePage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomePage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomePage.UseVisualStyleBackColor = true;
            this.HomePage.Click += new System.EventHandler(this.HomePage_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.welcomBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 140);
            this.panel1.TabIndex = 0;
            // 
            // welcomBtn
            // 
            this.welcomBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomBtn.FlatAppearance.BorderSize = 0;
            this.welcomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.welcomBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcomBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.welcomBtn.IconChar = FontAwesome.Sharp.IconChar.Meteor;
            this.welcomBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.welcomBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.welcomBtn.Location = new System.Drawing.Point(0, 0);
            this.welcomBtn.Name = "welcomBtn";
            this.welcomBtn.Size = new System.Drawing.Size(220, 140);
            this.welcomBtn.TabIndex = 1;
            this.welcomBtn.Text = "Hoşgeldiniz";
            this.welcomBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.welcomBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.welcomBtn.UseVisualStyleBackColor = true;
            this.welcomBtn.Click += new System.EventHandler(this.ıconButton1_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(220, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(962, 30);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitle_Paint);
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 30);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(962, 10);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDeskop
            // 
            this.panelDeskop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeskop.Location = new System.Drawing.Point(220, 40);
            this.panelDeskop.Name = "panelDeskop";
            this.panelDeskop.Size = new System.Drawing.Size(962, 913);
            this.panelDeskop.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 953);
            this.Controls.Add(this.panelDeskop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Personel Takip Sistemi";
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton AssigmentPage;
        private FontAwesome.Sharp.IconButton PersonnelPage;
        private FontAwesome.Sharp.IconButton HomePage;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton welcomBtn;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDeskop;
    }
}

