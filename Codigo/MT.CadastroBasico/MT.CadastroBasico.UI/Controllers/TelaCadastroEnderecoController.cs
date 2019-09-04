using MT.CadastroBasico.Negocio.Objetos;
using MT.CadastroBasico.Servicos.EnderecoObj;
using MT.CadastroBasico.UI.Base;
using MT.CadastroBasico.UI.Views.Endereco;
using System;

namespace MT.CadastroBasico.UI.Controllers
{
    public class TelaCadastroEnderecoController : ControllerBase
    {
        private TelaCadastroEnderecoView _tela;
        private ServicoDeEndereco _servicoDeEndereco;

        public TelaCadastroEnderecoController(TelaCadastroEnderecoView telaCadastroEndereco)
        {
            _tela = telaCadastroEndereco;
            _servicoDeEndereco = new ServicoDeEndereco();
        }

        public void CadastreEndereco()
        {
            var endereco = ObtenhaEnderecoDaTela();

            try
            {
                _servicoDeEndereco.Cadastrar(endereco);
                ExibaMensagemDeSucesso();
                _tela.Close();
            }
            catch (Exception ex)
            {
                ExibaMensagemDeCampoVazio(ex.Message);
            }
        }

        /// <summary>
        /// Obtém o endereço com as informações da tela.
        /// </summary>
        /// <returns>Uma instância de endereco.</returns>
        private Endereco ObtenhaEnderecoDaTela()
        {
            return new Endereco
            {
                Descricao = _tela.ObtenhaDescricao(),
                Logradouro = _tela.ObtenhaLogradouro(),
                Bairro = _tela.ObtenhaBairro(),
                Cidade = _tela.ObtenhaCidade()
            };
        }
    }
}
