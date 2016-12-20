using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Embassy
{
    public partial class ControlForm : Form
    {
        public ControlForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            VisaForm vForm = new VisaForm();
            vForm.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddForm aForm = new AddForm();
            aForm.Show();
        }


        private void ControlForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ExitButton_Click(sender, e);
        }


        private void viewButton_Click(object sender, EventArgs e)
        {
            InformationForm iForm = new InformationForm();
            iForm.Show();
        }
    }
}
