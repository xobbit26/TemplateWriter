using System;
using System.Drawing;
using System.Windows.Forms;
using TemplateWriter.Services;

namespace TemplateWriter
{
    public partial class MainForm : Form
    {
        private IApplicationService _appService;

        public MainForm(IApplicationService appService)
        {
            InitializeComponent();
            _appService = appService;
        }

        private void uploadImage_Click(object sender, EventArgs e)
        {
            _appService.SetImageByFileDialog();
            templateBox.Image = new Bitmap(_appService.GetImagePath());
        }

        private void download_Click(object sender, EventArgs e)
        {
            _appService.SaveImages();
        }

        private void templateBox_Click(object sender, EventArgs e)
        {
            var mouseEvent = e as MouseEventArgs;
            _appService.SetTextLocation(mouseEvent.Location);
        }

        private void templateTextBox_TextChanged(object sender, EventArgs e)
        {
            _appService.SetTextTemplate(templateTextBox.Text);
        }

        private void uploadCSV_Click(object sender, EventArgs e)
        {
            _appService.UploadCSVFilePath();
        }
    }
}
