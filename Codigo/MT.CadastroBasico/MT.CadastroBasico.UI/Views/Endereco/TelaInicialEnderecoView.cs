using MT.CadastroBasico.Controllers.TelaControllers;
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

        private void TelaInicialEnderecoView_Load(object sender, EventArgs e)
        {

        }

        private void EventoClickBotaoNovo(object sender, EventArgs e)
        {
            var telaCadastroEndereco = new TelaCadastroEnderecoView();

            this.ExibaFormulario(telaCadastroEndereco);
        }
    }
}
