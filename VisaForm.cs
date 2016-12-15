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
            //figure our the rect thingy            
            try
            {  
            using (var engine = new TesseractEngine(@"C:\Users\Aušrė\Documents\Visual Studio 2015\Projects\Embassy\tessdata", "eng", EngineMode.Default))
            {
                using (var image = Pix.LoadFromFile(imagePath))
                {
                    using (var page = engine.Process(image)) //, new Rect(200, 40, 100, 10)
                        {
                        passportNoBox.Text = page.GetText();
                    }
                }

            }
            }
            catch (Exception er)
            {
                //Trace.TraceError(er.ToString());
                MessageBox.Show("Unexpected Error: " + er.Message);
                MessageBox.Show("Details: ");
                MessageBox.Show(er.ToString());
            }


        }


        private void uploadButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;
                passportBox.ImageLocation = imagePath;
                passportBox.SizeMode = PictureBoxSizeMode.StretchImage;
                //passport = new Bitmap(openFileDialog.FileName);
                // MessageBox.Show(openFileDialog.FileName);
            }
        }
    }
}
