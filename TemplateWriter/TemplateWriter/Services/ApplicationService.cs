using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemplateWriter.Repositories;

namespace TemplateWriter.Services
{
    class ApplicationService : IApplicationService
    {
        private const string FILE_DIALOG_FILTER = "Image File (*.jpg; *.jpeg;)|*.jpg; *.jpeg;";

        private IApplicationStateRepository _appRepository;

        public ApplicationService(IApplicationStateRepository appRepository)
        {
            _appRepository = appRepository;
        }


        public void SetImageToPictureBox(PictureBox templateBox)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Image";
            openFileDialog.Filter = FILE_DIALOG_FILTER;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                templateBox.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        public string GetTextTemplate()
        {
            return _appRepository.GetTextTemplate();
        }

        public void SetTextTemplate(string textTemplate)
        {
            _appRepository.SetTextTemplate(textTemplate);
        }
    }
}
