using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateWriter
{
    public partial class MainForm : Form
    {
        private Point _choosedLocation;
        private string _stringToWrite;

        public MainForm()
        {
            InitializeComponent();
        }

        private void upload_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Image";
            openFileDialog.Filter = "Image File (*.jpg; *.jpeg;)|*.jpg; *.jpeg;";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                templateBox.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void download_Click(object sender, EventArgs e)
        {
            //TODO: Set dock in the view of the app and set there the info about errors (F.E. when we don't have uploaded image)=)
            var image = templateBox.Image;
            if (image != null)
            {
                var graphix = Graphics.FromImage(image);
                graphix.DrawString("test string", new Font("TimesNewRoman", 30, FontStyle.Italic, GraphicsUnit.Pixel), Brushes.Black, _choosedLocation);
                 
                //TODO: to remove
                templateBox.Image = image;

                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Save Image";
                saveFileDialog.Filter = "Image File (*.jpg; *.jpeg;)|*.jpg; *.jpeg;";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    image.Save(saveFileDialog.FileName + ".jpeg", ImageFormat.Jpeg);
                }

            }
        }

        private void templateBox_Click(object sender, EventArgs e)
        {
            var mouseEvent = e as MouseEventArgs;

            if (mouseEvent != null && !String.IsNullOrEmpty(_stringToWrite))
            {
                _choosedLocation = mouseEvent.Location;
                var image = templateBox.Image;

                Console.WriteLine($"mouse location {mouseEvent.Location}");
                Console.WriteLine($"template box size {templateBox.Size}");
                Console.WriteLine($"Image size {image.Size}"); 

                var graphix = Graphics.FromImage(image);
                var font = new Font("TimesNewRoman", 30, FontStyle.Italic, GraphicsUnit.Pixel);
                graphix.DrawString(_stringToWrite, font, Brushes.Black, _choosedLocation);

                templateBox.Image = image;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _stringToWrite = textBox1.Text;
        }
    }
}
