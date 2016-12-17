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
    public partial class AddForm : Form
    {
        private const string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aušrė\\documents\\visual studio 2015\\Projects\\Embassy\\Embassy\\Embassy.mdf;Integrated Security=True";
        public AddForm()
        {
            InitializeComponent();

            monthCalendar.MinDate = System.DateTime.Today;
            //providerBox.DataSource = 
                
            //add possible provider list
        }
    

        private void addButton_Click(object sender, EventArgs e)
        {
            using (var db = new EmbassyEntitiesFramework())
            {
                db.Database.Connection.ConnectionString = connectionString;
                Visa v = new Visa();
                v.Type = typeComboBox.Text;
                v.Received_by = receiverBox.Text;
                v.Expiration = monthCalendar.SelectionRange.Start;
                v.Granted_by = Int32.Parse(providerBox.Text);
                    //from employee in db.Employee
                    //           where employee.Surname == providerBox.Text
                    //           select employee.Id;

                db.Entry(v).State = System.Data.Entity.EntityState.Added;




            }
            
                //do adding to database stuff here
                //using (var db = new )
            //    Visa visa = new Embassy.Visa();
            //Employee employee = new Employee();
            //visa.Type = typeComboBox.Text;
            //visa.Granted_by = 
        }
    }
}
