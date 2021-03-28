using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemplateWriter.Repositories;
using TemplateWriter.Services;

namespace TemplateWriter
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(GetMainFormDI()));
        }

        private static IApplicationService GetMainFormDI()
        {
            var repo = new ApplicationStateRepository();
            return new ApplicationService(repo);
        }
    }
}
