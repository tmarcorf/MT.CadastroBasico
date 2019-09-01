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
        private const int COLUNA_CHECK = 1;

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
            _controller.AtualizeGridListaDeEnderecos(gridListaDeEnderecos);
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
            btnRemover.Enabled = false;
        }

        private void EventoClickCelulaDaGridDeEnderecos(object sender, DataGridViewCellEventArgs e)
        {
            
            var index = e.RowIndex;

            if (e.ColumnIndex == COLUNA_CHECK)
            {
                if ((bool)gridListaDeEnderecos[e.ColumnIndex, e.RowIndex].Value == false)
                {
                    gridListaDeEnderecos[e.ColumnIndex, e.RowIndex].Value = true;
                }
            }

            var colunaCheckEstaMarcada = AlgumItemColunaCheckEstaMarcado();
        }

        /// <summary>
        /// Verifica se algum item da coluna check está marcado.
        /// </summary>
        /// <returns>Verdadeiro ou falso.</returns>
        private List<int> AlgumItemColunaCheckEstaMarcado()
        {
            foreach (DataGridViewRow linha in gridListaDeEnderecos.Rows)
            {
                if (Convert.ToBoolean(linha.Cells[0].Value) == true)
                {
                    return new List<int>();
                }
            }

            return new List<int>();
        }

        private void EventoClickBotaoRemover(object sender, EventArgs e)
        {

        }
    }
}
