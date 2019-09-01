using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT.CadastroBasico.UI.Base
{
    public class FormularioBase : Form
    {
        /// <summary>
        /// Exibe um formulário na tela.
        /// </summary>
        /// <param name="formulario">A instância do formulário.</param>
        public void ExibaFormulario(Form formulario)
        {
            formulario.ShowDialog();
        }
    }
}
