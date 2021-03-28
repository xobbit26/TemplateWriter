using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using TemplateWriter.Services;

namespace TemplateWriter
{
    public partial class MainForm : Form
    {
        private Point _choosedLocation;

        private IApplicationService _appService;

        public MainForm(IApplicationService appService)
        {
            InitializeComponent();
            _appService = appService;
        }

        private void uploadImage_Click(object sender, EventArgs e)
        {
            _appService.SetImageToPictureBox(templateBox);
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

            var currentText = _appService.GetTextTemplate();
            if (mouseEvent != null && !string.IsNullOrEmpty(currentText))
            {
                _choosedLocation = mouseEvent.Location;
                var image = templateBox.Image;

                var graphix = Graphics.FromImage(image);
                var font = new Font("TimesNewRoman", 30, FontStyle.Italic, GraphicsUnit.Pixel);
                graphix.DrawString(currentText, font, Brushes.Black, _choosedLocation);

                templateBox.Image = image;
            }

        }

        private void templateTextBox_TextChanged(object sender, EventArgs e)
        {
            _appService.SetTextTemplate(templateTextBox.Text);
        }
    }
}
