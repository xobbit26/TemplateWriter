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
        private string _textTemplate;

               
        public Point GetTextLocation()
        {
            throw new NotImplementedException();
        }

        public void SetTextLocation(Point textLocation)
        {
            throw new NotImplementedException();
        }

        public string GetTextTemplate()
        {
            return _textTemplate;
        }

        public void SetTextTemplate(string textTemplate)
        {
            _textTemplate = textTemplate;
        }
    }
}
