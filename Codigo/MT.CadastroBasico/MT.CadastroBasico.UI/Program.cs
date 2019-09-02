using MT.CadastroBasico.UI.Views;
using MT.CadastroBasico.UI.Views.Endereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT.CadastroBasico.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new TelaInicialView());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro na aplicação: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
