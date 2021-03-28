using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateWriter.Services
{
    public interface IApplicationService
    {
        void SetImageToPictureBox(PictureBox templateBox);

        void SetTextTemplate(string textTemplate);

        string GetTextTemplate();
    }
}
