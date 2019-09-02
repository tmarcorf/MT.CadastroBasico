using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT.CadastroBasico.UI.Base
{
    /// <summary>
    /// O controller base.
    /// </summary>
    public class ControllerBase
    {
        /// <summary>
        /// Adiciona uma coluna do tipo texto.
        /// </summary>
        /// <param name="nomeDaColuna">O nome da coluna.</param>
        /// <param name="textoDoCabecalho">O texto do cabeçalho.</param>
        /// <param name="gridDeEnderecos">A grid de endereços.</param>
        public void AdicioneColunaTexto(string nomeDaColuna, string textoDoCabecalho, DataGridView gridDeEnderecos)
        {
            gridDeEnderecos.Columns.Add(nomeDaColuna, textoDoCabecalho);
            gridDeEnderecos.Columns[nomeDaColuna].ReadOnly = true;
            gridDeEnderecos.Columns[nomeDaColuna].Resizable = DataGridViewTriState.False;
        }

        public void ExibaMensagemDeSucesso()
        {
            MessageBox.Show("O registro foi inserido com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Exibe uma mensagem de campos vazios.
        /// </summary>
        /// <param name="mensagem">A mensagem.</param>
        public void ExibaMensagemDeCampoVazio(string mensagem)
        {
            MessageBox.Show(mensagem, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
