using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT.CadastroBasico.UI.Controllers
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
            var checkBox = new CheckBox();
            gridDeEnderecos.Controls.Add(checkBox);

            var colunaCheck = new DataGridViewCheckBoxColumn();

            colunaCheck.Resizable = DataGridViewTriState.False;
            colunaCheck.FillWeight = 30.0f;

            gridDeEnderecos.Columns.Insert(0, colunaCheck);
        }

        public void AdicioneColunaTexto(string nomeDaColuna, string textoDoCabecalho, DataGridView gridDeEnderecos)
        {
            gridDeEnderecos.Columns.Add(nomeDaColuna, textoDoCabecalho);
        }
    }
}
