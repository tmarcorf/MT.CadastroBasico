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
        /// Adiciona uma coluna check box.
        /// </summary>
        public void AdicioneColunaCheckBox(DataGridView gridDeEnderecos)
        {
            var colunaCheck = new DataGridViewCheckBoxColumn();

            colunaCheck.ReadOnly = false;
            colunaCheck.Resizable = DataGridViewTriState.False;
            colunaCheck.FillWeight = 40.0f;

            gridDeEnderecos.Columns.Insert(0, colunaCheck);
        }

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
    }
}
