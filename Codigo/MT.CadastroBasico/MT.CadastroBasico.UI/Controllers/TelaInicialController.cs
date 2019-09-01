using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT.CadastroBasico.UI.Controllers
{
    public class TelaInicialController
    {
        private Form _tela;

        /// <summary>
        /// O construtor da classe.
        /// </summary>
        /// <param name="telaInicial"></param>
        public TelaInicialController(Form telaInicial)
        {
            _tela = telaInicial;
        }
    }
}
