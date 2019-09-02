using MT.CadastroBasico.UI.Base;
using MT.CadastroBasico.UI.Controllers;
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
    public partial class TelaCadastroEnderecoView : FormularioBase
    {
        private TelaCadastroEnderecoController _controller;

        /// <summary>
        /// O construtor da classe.
        /// </summary>
        public TelaCadastroEnderecoView()
        {
            InitializeComponent();

            _controller = new TelaCadastroEnderecoController(this);
        }

        /// <summary>
        /// Obtém a descrição do endereço.
        /// </summary>
        /// <returns>A descrição.</returns>
        public string ObtenhaDescricao()
        {
            return txbDescricao.Text;
        }

        /// <summary>
        /// Obtém o logradouro do endereço.
        /// </summary>
        /// <returns>o logradouro.</returns>
        public string ObtenhaLogradouro()
        {
            return txbLogradouro.Text;
        }

        /// <summary>
        /// Obtém o bairro do endereço.
        /// </summary>
        /// <returns>O bairro.</returns>
        public string ObtenhaBairro()
        {
            return txbBairro.Text;
        }

        /// <summary>
        /// Obtém a cidade do endereço.
        /// </summary>
        /// <returns>A cidade.</returns>
        public string ObtenhaCidade()
        {
            return txbCidade.Text;
        }

        /// <summary>
        /// Evento de click do botão salvar.
        /// </summary>
        /// <param name="sender">O disparador.</param>
        /// <param name="e">Os argumentos</param>
        private void EventoCliqueBotaoSalvar(object sender, EventArgs e)
        {
            _controller.CadastreEndereco();
        }

        /// <summary>
        /// Evento de click do botão cancelar.
        /// </summary>
        /// <param name="sender">O disparador.</param>
        /// <param name="e">Os argumentos.</param>
        private void EventoClickBotaoCancelar(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
