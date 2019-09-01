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

        public TelaCadastroEnderecoView()
        {
            InitializeComponent();

            _controller = new TelaCadastroEnderecoController(this);
        }

        public string ObtenhaDescricao()
        {
            return txbDescricao.Text;
        }

        public string ObtenhaLogradouro()
        {
            return txbLogradouro.Text;
        }

        public string ObtenhaBairro()
        {
            return txbBairro.Text;
        }

        public string ObtenhaCidade()
        {
            return txbCidade.Text;
        }

        private void EventoCliqueBotaoSalvar(object sender, EventArgs e)
        {
            _controller.CadastreEndereco();
        }
    }
}
