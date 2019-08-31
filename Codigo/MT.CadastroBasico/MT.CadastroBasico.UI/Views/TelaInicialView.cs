using MT.CadastroBasico.Controllers.TelaControllers;
using MT.CadastroBasico.UI.Base;
using MT.CadastroBasico.UI.Views.Endereco;
using MT.CadastroBasico.UI.Views.Pessoa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT.CadastroBasico.UI.Views
{
    public partial class TelaInicialView : FormularioBase
    {
        private TelaInicialController _controller;

        public TelaInicialView()
        {
            InitializeComponent();

            _controller = new TelaInicialController(this);
        }

        private void EventoClickMenuEndereco(object sender, EventArgs e)
        {
            var telaInicialEndereco = new TelaInicialEnderecoView();

            this.ExibaFormulario(telaInicialEndereco);
        }
    }
}
