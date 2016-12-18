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
            addButton.Visible = true;

            monthCalendar.MinDate = System.DateTime.Today;
            ShowBoxes();
            FillComboBox();
            //providerBox.DataSource = 
                
            //add possible provider list
        }

        public AddForm (String passport)
        {
            InitializeComponent();

            monthCalendar.MinDate = System.DateTime.Today;

            ShowLabels();
            ShowContent(passport);


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

                db.Visa.Add(v);
                //db.Entry(v).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();

            }
            addButton.Visible = false;
            
        }

        private void ShowLabels()
        {
            userProviderLabel.Visible = true;
            userReceiverLabel.Visible = true;
            userTypeLabel.Visible = true;
            providerBox.Visible = false;
            receiverBox.Visible = false;
            typeComboBox.Visible = false;
            addButton.Visible = false;
        }

        private void ShowBoxes()
        {
            userProviderLabel.Visible = false;
            userReceiverLabel.Visible = false;
            userTypeLabel.Visible = false;
            providerBox.Visible = true;
            receiverBox.Visible = true;
            typeComboBox.Visible = true;
            addButton.Visible = true;
        }

        private void ShowContent(string passport)
        {
            using (var db = new EmbassyEntitiesFramework())
            {
                db.Database.Connection.ConnectionString = connectionString;
                var person = from p in db.Visa
                             where p.Received_by == passport
                             select p;
                foreach (var p in person)
                {
                    userProviderLabel.Text = p.Granted_by.ToString();
                    userReceiverLabel.Text = p.Received_by.ToString();
                    userTypeLabel.Text = p.Type.ToString();
                    //monthCalendar.TodayDate = p.Expiration;
                    monthCalendar.SetDate(p.Expiration);
                }
                
                //from employee in db.Employee
                //           where employee.Surname == providerBox.Text
                //           select employee.Id;

            }

        }

        private void FillComboBox()
        {
            using (var db = new EmbassyEntitiesFramework())
            {
                db.Database.Connection.ConnectionString = connectionString;
                //var person = from p in db.Visa
                //             select p;

                foreach(var p in db.Visa)
                {
                    providerBox.Items.Add(p.Id.ToString());
                }
                
            }
        }
    }
}
