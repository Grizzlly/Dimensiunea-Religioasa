using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dimensiunea_Religioasa
{
    public partial class FormMain : Form
    {

        Form currentChildForm;

        public FormMain()
        {
            InitializeComponent();
        }

        //asta activeaza double buffering ca sa nu mai flickereasca
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        private void btnSacruSiProfan_Click(object sender, EventArgs e)
        {
            hideSubPanel(subPanel);
            openChildForm(new FormSacru());
        }

        private void btnCostinMiron_Click(object sender, EventArgs e)
        {
            hideSubPanel(subPanel);
            openChildForm(new FormCostin());
        }

        private void btnDosoftei_Click(object sender, EventArgs e)
        {
            hideSubPanel(subPanel);
            openChildForm(new FormDosoftei());
        }

        private void btnRugaciuni_Click(object sender, EventArgs e)
        {
            showSubPanel(subPanel);
        }

        private void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            InfoPanel.Controls.Add(childForm);
            InfoPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void showSubPanel(Panel panel)
        {
            panel.Visible = !panel.Visible;
        }

        private void hideSubPanel(Panel panel)
        {
            panel.Visible = false;
        }
    }
}
