namespace DataTempatMakan
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
            panelSideMenu = new Panel();
            panelDataTempatMakanSubMenu = new Panel();
            buttonDTM = new Button();
            buttonUTM = new Button();
            buttonRTM = new Button();
            buttonCTM = new Button();
            btnDataTempatMakan = new Button();
            panelLogo = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            label12 = new Label();
            label11 = new Label();
            panelChildForm = new Panel();
            panelSideMenu.SuspendLayout();
            panelDataTempatMakanSubMenu.SuspendLayout();
            panelChildForm.SuspendLayout();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.AutoScroll = true;
            panelSideMenu.BackColor = SystemColors.ActiveBorder;
            panelSideMenu.Controls.Add(panelDataTempatMakanSubMenu);
            panelSideMenu.Controls.Add(btnDataTempatMakan);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(324, 977);
            panelSideMenu.TabIndex = 0;
            // 
            // panelDataTempatMakanSubMenu
            // 
            panelDataTempatMakanSubMenu.BackColor = SystemColors.ControlLight;
            panelDataTempatMakanSubMenu.Controls.Add(buttonDTM);
            panelDataTempatMakanSubMenu.Controls.Add(buttonUTM);
            panelDataTempatMakanSubMenu.Controls.Add(buttonRTM);
            panelDataTempatMakanSubMenu.Controls.Add(buttonCTM);
            panelDataTempatMakanSubMenu.Dock = DockStyle.Top;
            panelDataTempatMakanSubMenu.Location = new Point(0, 261);
            panelDataTempatMakanSubMenu.Name = "panelDataTempatMakanSubMenu";
            panelDataTempatMakanSubMenu.Size = new Size(324, 340);
            panelDataTempatMakanSubMenu.TabIndex = 1;
            // 
            // buttonDTM
            // 
            buttonDTM.Dock = DockStyle.Top;
            buttonDTM.FlatAppearance.BorderSize = 0;
            buttonDTM.FlatStyle = FlatStyle.Flat;
            buttonDTM.Location = new Point(0, 255);
            buttonDTM.Name = "buttonDTM";
            buttonDTM.Size = new Size(324, 85);
            buttonDTM.TabIndex = 4;
            buttonDTM.Text = "DELETE TEMPAT MAKAN";
            buttonDTM.UseVisualStyleBackColor = true;
            buttonDTM.Click += buttonDTM_Click;
            // 
            // buttonUTM
            // 
            buttonUTM.Dock = DockStyle.Top;
            buttonUTM.FlatAppearance.BorderSize = 0;
            buttonUTM.FlatStyle = FlatStyle.Flat;
            buttonUTM.Location = new Point(0, 170);
            buttonUTM.Name = "buttonUTM";
            buttonUTM.Size = new Size(324, 85);
            buttonUTM.TabIndex = 3;
            buttonUTM.Text = "UPDATE TEMPAT MAKAN";
            buttonUTM.UseVisualStyleBackColor = true;
            buttonUTM.Click += buttonUTM_Click;
            // 
            // buttonRTM
            // 
            buttonRTM.Dock = DockStyle.Top;
            buttonRTM.FlatAppearance.BorderSize = 0;
            buttonRTM.FlatStyle = FlatStyle.Flat;
            buttonRTM.Location = new Point(0, 85);
            buttonRTM.Name = "buttonRTM";
            buttonRTM.Size = new Size(324, 85);
            buttonRTM.TabIndex = 2;
            buttonRTM.Text = "READ TEMPAT MAKAN";
            buttonRTM.UseVisualStyleBackColor = true;
            buttonRTM.Click += buttonRTM_Click;
            // 
            // buttonCTM
            // 
            buttonCTM.Dock = DockStyle.Top;
            buttonCTM.FlatAppearance.BorderSize = 0;
            buttonCTM.FlatStyle = FlatStyle.Flat;
            buttonCTM.Location = new Point(0, 0);
            buttonCTM.Name = "buttonCTM";
            buttonCTM.Size = new Size(324, 85);
            buttonCTM.TabIndex = 1;
            buttonCTM.Text = "CREATE TEMPAT MAKAN";
            buttonCTM.UseVisualStyleBackColor = true;
            buttonCTM.Click += buttonCTM_Click;
            // 
            // btnDataTempatMakan
            // 
            btnDataTempatMakan.Dock = DockStyle.Top;
            btnDataTempatMakan.FlatAppearance.BorderSize = 0;
            btnDataTempatMakan.FlatStyle = FlatStyle.Flat;
            btnDataTempatMakan.Location = new Point(0, 176);
            btnDataTempatMakan.Name = "btnDataTempatMakan";
            btnDataTempatMakan.Size = new Size(324, 85);
            btnDataTempatMakan.TabIndex = 1;
            btnDataTempatMakan.Text = "DATA TEMPAT MAKAN";
            btnDataTempatMakan.UseVisualStyleBackColor = true;
            btnDataTempatMakan.Click += btnDataTempatMakan_Click;
            // 
            // panelLogo
            // 
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(324, 176);
            panelLogo.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(324, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1098, 91);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(324, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(1098, 85);
            panel2.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ActiveBorder;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(483, 801);
            label12.Name = "label12";
            label12.Size = new Size(98, 28);
            label12.TabIndex = 18;
            label12.Text = "deskripsi :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ActiveBorder;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(483, 848);
            label11.Name = "label11";
            label11.Size = new Size(116, 28);
            label11.TabIndex = 19;
            label11.Text = "no telepon :";
            // 
            // panelChildForm
            // 
            panelChildForm.Controls.Add(label11);
            panelChildForm.Controls.Add(label12);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(324, 176);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(1098, 801);
            panelChildForm.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 977);
            Controls.Add(panelChildForm);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelSideMenu);
            MinimumSize = new Size(1440, 1018);
            Name = "Form1";
            Text = "Form1";
            panelSideMenu.ResumeLayout(false);
            panelDataTempatMakanSubMenu.ResumeLayout(false);
            panelChildForm.ResumeLayout(false);
            panelChildForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Button btnDataTempatMakan;
        private Panel panelLogo;
        private Panel panelDataTempatMakanSubMenu;
        private Button buttonDTM;
        private Button buttonUTM;
        private Button buttonRTM;
        private Button buttonCTM;
        private Panel panel1;
        private Panel panel2;
        private Label label12;
        private Label label11;
        private Panel panelChildForm;
    }
}