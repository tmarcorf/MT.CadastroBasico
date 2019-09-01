using MT.CadastroBasico.UI.Controllers;
using MT.CadastroBasico.UI.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT.CadastroBasico.UI.Views.Endereco
{
    public partial class TelaInicialEnderecoView : FormularioBase
    {
        /// <summary>
        /// Controller da tela.
        /// </summary>
        private TelaInicialEnderecoController _controller;

        /// <summary>
        /// Construtor da classe.
        /// </summary>
        public TelaInicialEnderecoView()
        {
            InitializeComponent();

            _controller = new TelaInicialEnderecoController(this);

        }

        /// <summary>
        /// Obtém a grid da lista de endereços.
        /// </summary>
        /// <returns>A grid da lista de endereços.</returns>
        public DataGridView ObtenhaGridListaDeEnderecos()
        {
            return gridListaDeEnderecos;
        }

        #region EVENTOS DA TELA

        private void EventoFormularioEnderecoCarregado(object sender, EventArgs e)
        {
            InicalizeTela();
        }

        private void EventoClickBotaoNovo(object sender, EventArgs e)
        {
            var telaCadastroEndereco = new TelaCadastroEnderecoView();

            this.ExibaFormulario(telaCadastroEndereco);
        }

        /// <summary>
        /// Fecha o formulário.
        /// </summary>
        /// <param name="sender">O disparador do evento.</param>
        /// <param name="e">Os argumentos.</param>
        private void EventoClickBotaoFechar(object sender, EventArgs e)
        {
            _controller.FecheFormulario();
        }

        #endregion

        private void InicalizeTela()
        {
            _controller.ConfigureGridListaDeEnderecos();
        }
    }
}
