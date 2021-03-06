﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Embassy
{
    public partial class AddForm : Form
    {
        private int ID;
        private const string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aušrė\\documents\\visual studio 2015\\Projects\\Embassy\\Embassy\\Embassy.mdf;Integrated Security=True";
        public AddForm()
        {
            InitializeComponent();

            monthCalendar.MinDate = System.DateTime.Today;

            ShowAdd();
            FillComboBox();

        }

        public AddForm (String passport)
        {
            InitializeComponent();

            monthCalendar.MinDate = System.DateTime.Today;

            ShowUpdateDelete();
            ShowContent(passport);

        }
    

        private void addButton_Click(object sender, EventArgs e)
        {
            if (addButton.Text == "Add")
            {
                if(!String.IsNullOrWhiteSpace(typeComboBox.Text)||!String.IsNullOrWhiteSpace(receiverBox.Text)
                    || !String.IsNullOrWhiteSpace(providerBox.Text))
                {
                    using (var db = new EmbassyEntitiesFramework())
                    {
                        db.Database.Connection.ConnectionString = connectionString;
                        Visa v = new Visa();
                        v.Type = typeComboBox.Text;
                        v.Received_by = receiverBox.Text;
                        v.Expiration = monthCalendar.SelectionRange.Start;
                        v.Granted_by = Int32.Parse(providerBox.Text);

                        //db.Visa.Add(v);
                        db.Entry(v).State = System.Data.Entity.EntityState.Added;
                        db.SaveChanges();

                    }
                    addButton.Visible = false;

                }
                else
                {
                    MessageBox.Show("Fill all fields, please!");
                }
            
            }
            else if (addButton.Text == "Update")
            {
                using (var db = new EmbassyEntitiesFramework())
                {
                    db.Database.Connection.ConnectionString = connectionString;

                    Visa v = db.Visa.Where(visa => visa.Id == ID).FirstOrDefault<Visa>();
                    v.Type = typeComboBox.Text;
                    v.Received_by = receiverBox.Text;
                    v.Expiration = monthCalendar.SelectionRange.Start;
                    v.Granted_by = Int32.Parse(providerBox.Text);

                    db.Entry(v).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                }
                addButton.Visible = false;

            }
            
            
        }

        private void ShowUpdateDelete()
        {

            addButton.Text = "Update";
            deleteButton.Visible = true;
        }

        private void ShowAdd()
        {
            deleteButton.Visible = false; 
            addButton.Text = "Add";
        }

        private void ShowContent(string passport)
        {
            
            using (var db = new EmbassyEntitiesFramework())
            {
                db.Database.Connection.ConnectionString = connectionString;
                Visa v = db.Visa.Where(visa => visa.Received_by == passport).FirstOrDefault<Visa>();
                if (v!=null)
                {
                    FillComboBox();
                    providerBox.Text = v.Granted_by.ToString();
                    receiverBox.Text = v.Received_by.ToString();
                    typeComboBox.Text = v.Type.ToString();
                    monthCalendar.SetDate(v.Expiration);
                    ID = v.Id;
                }
                else
                {
                    MessageBox.Show("Such visa doesn't exist. Try adding it.");
                }
                

            }

        }


        private void FillComboBox()
        {
            using (var db = new EmbassyEntitiesFramework())
            {
                db.Database.Connection.ConnectionString = connectionString;

                foreach(var p in db.Visa)
                {
                    providerBox.Items.Add(p.Id.ToString());
                }
                
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            
            using (var db = new EmbassyEntitiesFramework())
            {
                db.Database.Connection.ConnectionString = connectionString;

                Visa v = db.Visa.Where(visa => visa.Id == ID).FirstOrDefault<Visa>();

                db.Entry(v).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();

            }
            deleteButton.Visible = false;
            addButton.Visible = false;

        }

        private void receiverBox_Validating(object sender, CancelEventArgs e)
        {
            string pattern = @"^(\d+)$";
            if (!Regex.IsMatch(receiverBox.Text, pattern))
            {
                e.Cancel = true;
                receiverBox.BackColor = Color.Tomato;
            }
            else
            {
                receiverBox.BackColor = Color.White;
            }
        }
    }
}
