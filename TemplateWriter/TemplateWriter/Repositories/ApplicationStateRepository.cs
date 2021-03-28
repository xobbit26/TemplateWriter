using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateWriter.Repositories
{
    class ApplicationStateRepository : IApplicationStateRepository
    {
        private string _imagePath;
        private Point _textLocation;
        private string _textTemplate;
        private string _csvFilePath;


        public void SetImagePath(string imagePath)
        {
            _imagePath = imagePath;
        }

        public string GetImagePath()
        {
            return _imagePath;
        }


        public Point GetTextLocation()
        {
            return _textLocation;
        }

        public void SetTextLocation(Point textLocation)
        {
            _textLocation = textLocation;
        }

        public string GetTextTemplate()
        {
            return _textTemplate;
        }

        public void SetTextTemplate(string textTemplate)
        {
            _textTemplate = textTemplate;
        }

        public void SetCSVFilePath(string filePath)
        {
            _csvFilePath = filePath;
        }

        public string GetCSVFilePath()
        {
            return _csvFilePath;
        }

    }
}
