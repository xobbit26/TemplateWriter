using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemplateWriter.Repositories;

namespace TemplateWriter.Services
{
    class ApplicationService : IApplicationService
    {
        private const string FILE_DIALOG_IMAGE_FILTER = "Image File (*.jpg; *.jpeg;)|*.jpg; *.jpeg;";
        private const string FILE_DIALOG_CSV_FILTER = "CSV File (*.csv; *.xls; *.xlsx;)|*.csv; *.xls; *.xlsx;";

        private IApplicationStateRepository _appRepository;

        public ApplicationService(IApplicationStateRepository appRepository)
        {
            _appRepository = appRepository;
        }


        public void SetImageByFileDialog()
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Image";
            openFileDialog.Filter = FILE_DIALOG_IMAGE_FILTER;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _appRepository.SetImagePath(openFileDialog.FileName);
                Console.WriteLine($"Image has been set with path: {openFileDialog.FileName}");
            }
        }

        public string GetImagePath()
        {
            return _appRepository.GetImagePath();
        }


        public void SetTextTemplate(string textTemplate)
        {
            _appRepository.SetTextTemplate(textTemplate);
            Console.WriteLine($"Text Template has been set with path: {textTemplate}");
        }


        public void UploadCSVFilePath()
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select CSV File";
            openFileDialog.Filter = FILE_DIALOG_CSV_FILTER;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _appRepository.SetCSVFilePath(openFileDialog.FileName);
                Console.WriteLine($"CSV FILE has been set with path: {openFileDialog.FileName}");
            }
        }

        public void SetTextLocation(Point location)
        {
            _appRepository.SetTextLocation(location);
            Console.WriteLine($"chosed location {location}");
        }


        public void SaveImages()
        {
            if (_appRepository.GetTextLocation() == null)
            {
                throw new IOException("Location hasn't been set");
            }

            var csvFilePath = _appRepository.GetCSVFilePath();
            if (string.IsNullOrEmpty(csvFilePath))
            {
                throw new IOException("CSV file hasn't been found");
            }

            string folderToSaveLocaton = GetFolderToSaveLocation();
            if (string.IsNullOrEmpty(folderToSaveLocaton))
            {
                throw new IOException("File Location To Save is null or empty");
            }

            List<string> textValuesFromCSV = GetTextValuesFromCSV(csvFilePath);
            textValuesFromCSV.ForEach(text => WriteTextToImageAndSave(folderToSaveLocaton, text));
        }


        //todo: separate it to two methods
        private void WriteTextToImageAndSave(string folderToSaveLocaton, string text)
        {
            var image = new Bitmap(_appRepository.GetImagePath());
            if (image == null)
            {
                throw new IOException("Image doesn't exist");
            }

            var graphix = Graphics.FromImage(image);
            graphix.DrawString(text, new Font("TimesNewRoman", 30, FontStyle.Italic, GraphicsUnit.Pixel), Brushes.Black, _appRepository.GetTextLocation());

            string filePath = $"{folderToSaveLocaton}/{text}.jpeg";

            if (File.Exists(filePath))
            {
                int index = 1;
                filePath = $"{folderToSaveLocaton}/{text} ({index}).jpeg";

                while (File.Exists(filePath))
                    filePath = $"{folderToSaveLocaton}/{text} ({++index}).jpeg";
            }
            image.Save(filePath, ImageFormat.Jpeg);
        }

        private string GetFolderToSaveLocation()
        {
            using (var fileDialog = new FolderBrowserDialog())
            {
                DialogResult result = fileDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fileDialog.SelectedPath))
                {
                    return fileDialog.SelectedPath;
                }
            }
            return null;
        }

        private List<string> GetTextValuesFromCSV(string csvFilePath)
        {
            var stringList = new List<string>();
            using (StreamReader streamReader = new StreamReader(csvFilePath, Encoding.GetEncoding(1251)))
            {
                while (streamReader.Peek() >= 0)
                {
                    string text = streamReader.ReadLine();

                    stringList.Add(text);
                    Console.WriteLine(text);
                }
            }

            return stringList;
        }
    }
}
