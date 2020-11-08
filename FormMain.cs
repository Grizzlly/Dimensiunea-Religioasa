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

        private void BtnReligie_Click(object sender, EventArgs e)
        {
            PanelForms.Controls.Clear();
            PanelForms.Controls.Add(new FormReligie() { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill, Size = PanelForms.Size, Visible = true });
        }

        private void BtnSacru_Click(object sender, EventArgs e)
        {
            PanelForms.Controls.Clear();
            PanelForms.Controls.Add(new FormSacru() { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill, Size = PanelForms.Size, Visible = true });
        }

        private void BtnDosoftei_Click(object sender, EventArgs e)
        {
            PanelForms.Controls.Clear();
            PanelForms.Controls.Add(new FormDosoftei() { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill, Size = PanelForms.Size, Visible = true });
        }

        private void BtnMiron_Click(object sender, EventArgs e)
        {
            PanelForms.Controls.Clear();
            PanelForms.Controls.Add(new FormCostin() { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill, Size = PanelForms.Size, Visible = true });
        }

        private void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                if (currentChildForm != null)
                {
                    currentChildForm.Close();
                }

                currentChildForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                //panelDesktop.Controls.Add(childForm);
                //panelDesktop.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
        }
        
    }
}
