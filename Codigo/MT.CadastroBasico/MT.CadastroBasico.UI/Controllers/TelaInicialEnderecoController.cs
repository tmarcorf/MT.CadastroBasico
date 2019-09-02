using MT.CadastroBasico.Servicos;
using MT.CadastroBasico.UI.Base;
using MT.CadastroBasico.UI.Views.Endereco;
using System.Windows.Forms;

namespace MT.CadastroBasico.UI.Controllers
{
    public class TelaInicialEnderecoController : ControllerBase
    {
        private const string COLUNA_CHECK = "Selecionar";
        private const string COLUNA_ID = "ID";
        private const string COLUNA_DESCRICAO = "Descricao";
        private const string COLUNA_LOGRADOURO = "Logradouro";
        private const string COLUNA_BAIRRO = "Bairro";
        private const string COLUNA_CIDADE = "Cidade";

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
            gridDeEnderecos.Columns.Clear();

            AdicioneColunaTexto(COLUNA_ID, COLUNA_ID, gridDeEnderecos);
            AdicioneColunaTexto(COLUNA_DESCRICAO, "Descrição", gridDeEnderecos);
            AdicioneColunaTexto(COLUNA_LOGRADOURO, COLUNA_LOGRADOURO, gridDeEnderecos);
            AdicioneColunaTexto(COLUNA_BAIRRO, COLUNA_BAIRRO, gridDeEnderecos);
            AdicioneColunaTexto(COLUNA_CIDADE, COLUNA_CIDADE, gridDeEnderecos);

            gridDeEnderecos.Columns[COLUNA_ID].Width = 50;
            gridDeEnderecos.Columns[COLUNA_DESCRICAO].Width = 100;
            gridDeEnderecos.Columns[COLUNA_LOGRADOURO].Width = 70;
            gridDeEnderecos.Columns[COLUNA_BAIRRO].Width = 70;
            gridDeEnderecos.Columns[COLUNA_CIDADE].Width = 70;

            gridDeEnderecos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridDeEnderecos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            AtualizeGridListaDeEnderecos(gridDeEnderecos);
        }

        public void AtualizeGridListaDeEnderecos(DataGridView gridDeEnderecos)
        {
            gridDeEnderecos.Rows.Clear();
            var listaDeEnderecos = _servicoDeEndereco.ConsultarLista();

            for (int contador = 0; contador < listaDeEnderecos.Count; contador++)
            {
                gridDeEnderecos.Rows.Add();

                gridDeEnderecos[COLUNA_ID, contador].Value = listaDeEnderecos[contador].Identificador;
                gridDeEnderecos[COLUNA_DESCRICAO, contador].Value = listaDeEnderecos[contador].Descricao;
                gridDeEnderecos[COLUNA_LOGRADOURO, contador].Value = listaDeEnderecos[contador].Logradouro;
                gridDeEnderecos[COLUNA_BAIRRO, contador].Value = listaDeEnderecos[contador].Bairro;
                gridDeEnderecos[COLUNA_CIDADE, contador].Value = listaDeEnderecos[contador].Cidade;
            }
        }
    }
}
