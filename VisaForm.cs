using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;

namespace Embassy
{
    public partial class VisaForm : Form
    {
        //Bitmap passport;
        private string imagePath;
        private const string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aušrė\\documents\\visual studio 2015\\Projects\\Embassy\\Embassy\\Embassy.mdf;Integrated Security=True";

        public VisaForm()
        {
            InitializeComponent();
        }

        private void comfirmationButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(passportNoBox.Text))
            {
                using (var db = new EmbassyEntitiesFramework())
                {
                    db.Database.Connection.ConnectionString = connectionString;
                    Visa v = db.Visa.Where(visa => visa.Received_by == passportNoBox.Text).FirstOrDefault<Visa>();
                    if (v != null)
                    {
                        AddForm a = new AddForm(passportNoBox.Text);
                        a.Show();
                    }
                    else
                    {
                        MessageBox.Show("Such visa doesn't exist. Try adding it.");
                    }


                }

            }

        }


        private void uploadButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;
                passportBox.ImageLocation = imagePath;
                passportBox.SizeMode = PictureBoxSizeMode.StretchImage;
                numberRecognition();
            }
        }

        private void numberRecognition()
        {           
            try
            {
                using (var engine = new TesseractEngine(@"C:\Users\Aušrė\Documents\Visual Studio 2015\Projects\Embassy\tessdata", "eng", EngineMode.Default))
                {
                    using (var image = Pix.LoadFromFile(imagePath))
                    {
                        using (var page = engine.Process(image, new Rect(300, 10, 200, 100))) //
                        {
                            passportNoBox.Text = String.Join("", page.GetText().Where(char.IsDigit));
                        }
                    }

                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Unexpected Error: " + er.Message);
            }

        }

        private void VisaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            ControlForm cForm = new ControlForm();
            cForm.Show();
        }

        private void passportNoBox_Validating(object sender, CancelEventArgs e)
        {
            string pattern = @"^(\d{6,11})$";
            if (!Regex.IsMatch(passportNoBox.Text, pattern)&&!String.IsNullOrWhiteSpace(passportNoBox.Text))
            {
                e.Cancel = true;
                passportNoBox.BackColor = Color.Tomato;
            }
            else
            {
                passportNoBox.BackColor = Color.White;
            }
        }
        
    }
}
