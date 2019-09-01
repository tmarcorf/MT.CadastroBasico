using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT.CadastroBasico.Controllers.TelaControllers
{
    public class TelaInicialEnderecoController
    {
        private Form _tela;

        /// <summary>
        /// O construtor da classe.
        /// </summary>
        /// <param name="telaInicialEndereco">A tela inicial de endereço.</param>
        public TelaInicialEnderecoController(TelaInicialEnderecoView telaInicialEndereco)
        {
            _tela = telaInicialEndereco;
        }

        /// <summary>
        /// Fecha o formulário.
        /// </summary>
        public void FecheFormulario()
        {
            _tela.Close();
        }

        public void ConfigureGridListaDeEnderecos()
        {
            _tela
        }
    }
}
