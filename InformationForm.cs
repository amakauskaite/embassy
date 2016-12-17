using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Embassy
{
    public partial class InformationForm : Form
    {
        public InformationForm()
        {
            InitializeComponent();
            //SqlConnection cn = new SqlConnection();
            
            //Visa v = new Visa();
            //var query =
            //    from a in v.GetTable<OrderedEnumerableRowCollection>()
            //    select a;
            //visaGridView.DataSource = query;
        }

        private void InformationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            //ControlForm cForm = new ControlForm();
            //cForm.Show();
        }

        private void InformationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'embassyDataSet.Visa' table. You can move, or remove it, as needed.
            this.visaTableAdapter.Fill(this.embassyDataSet.Visa);

        }
    }
}
