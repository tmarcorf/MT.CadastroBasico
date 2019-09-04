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
