using MT.CadastroBasico.Servicos;
using MT.CadastroBasico.UI.Views.Endereco;
using System.Windows.Forms;

namespace MT.CadastroBasico.UI.Controllers
{
    public class TelaInicialEnderecoController : ControllerBase
    {
        private TelaInicialEnderecoView _tela;
        private ServicoDeEndereco _servicoDeEndereco;

        /// <summary>
        /// O construtor da classe.
        /// </summary>
        /// <param name="telaInicialEndereco">A tela inicial de endereço.</param>
        public TelaInicialEnderecoController(TelaInicialEnderecoView telaInicialEndereco)
        {
            _tela = telaInicialEndereco;
            _servicoDeEndereco = new ServicoDeEndereco();
        }

        /// <summary>
        /// Fecha o formulário.
        /// </summary>
        public void FecheFormulario()
        {
            _tela.Close();
        }

        public void ConfigureGridListaDeEnderecos()
        {
            var gridDeEnderecos = _tela.ObtenhaGridListaDeEnderecos();

            AdicioneColunaCheckBox(gridDeEnderecos);

            AdicioneColunaTexto("Descricao", "Descrição", gridDeEnderecos);
            AdicioneColunaTexto("Logradouro", "Logradouro", gridDeEnderecos);
            AdicioneColunaTexto("Bairro", "Bairro", gridDeEnderecos);
            AdicioneColunaTexto("Cidade", "Cidade", gridDeEnderecos);

            gridDeEnderecos.Columns["Descricao"].Width = 100;
            gridDeEnderecos.Columns["Logradouro"].Width = 70;
            gridDeEnderecos.Columns["Bairro"].Width = 70;
            gridDeEnderecos.Columns["Cidade"].Width = 70;

            gridDeEnderecos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.PreenchaGridDeListaDeEnderecos(gridDeEnderecos);
        }

        private void PreenchaGridDeListaDeEnderecos(DataGridView gridDeEnderecos)
        {
            var listaDeEnderecos = _servicoDeEndereco.ConsultarLista();

            for (int contador = 0; contador < listaDeEnderecos.Count; contador++)
            {
                gridDeEnderecos.Rows.Add();

                gridDeEnderecos["Descricao", contador].Value = listaDeEnderecos[contador].Descricao;
                gridDeEnderecos["Logradouro", contador].Value = listaDeEnderecos[contador].Logradouro;
                gridDeEnderecos["Bairro", contador].Value = listaDeEnderecos[contador].Bairro;
                gridDeEnderecos["Cidade", contador].Value = listaDeEnderecos[contador].Cidade;
            }
        }
    }
}
