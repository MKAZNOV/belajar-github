namespace DataTempatMakan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelDataTempatMakanSubMenu.Visible = false;
            //..
        }

        private void hideSubMenu()
        {
            if (panelDataTempatMakanSubMenu.Visible == true)
                panelDataTempatMakanSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        #region DataTempatMakan
        private void btnDataTempatMakan_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDataTempatMakanSubMenu);
        }

        private void buttonCTM_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void buttonRTM_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void buttonUTM_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void buttonDTM_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }
        #endregion

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}