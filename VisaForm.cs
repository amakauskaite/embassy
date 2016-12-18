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

        public VisaForm()
        {
            InitializeComponent();
        }

        private void comfirmationButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(passportNoBox.Text))
            {
                AddForm a = new AddForm(passportNoBox.Text);
                a.Show();
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
                //passport = new Bitmap(openFileDialog.FileName);
                // MessageBox.Show(openFileDialog.FileName);
            }
        }

        private void numberRecognition()
        {
            //figure our the rect thingy            
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
    }
}
