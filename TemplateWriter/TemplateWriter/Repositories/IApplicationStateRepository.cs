using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TemplateWriter.Repositories
{
    interface IApplicationStateRepository
    {
        void SetTextLocation(Point textLocation);

        Point GetTextLocation();

        void SetTextTemplate(string textTemplate);

        string GetTextTemplate();
    }
}
