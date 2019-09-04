using MT.CadastroBasico.Negocio.Objetos;
using System;

namespace MT.CadastroBasico.Negocio.Validacoes
{
    public class ValidacoesDeEndereco
    {
        /// <summary>
        /// Valida as informações do endereço.
        /// </summary>
        /// <param name="endereco">O endereço.</param>
        public void Valide(Endereco endereco)
        {
            bool enderecoNaoEstaValido =
                string.IsNullOrWhiteSpace(endereco.Descricao) ||
                string.IsNullOrWhiteSpace(endereco.Logradouro) ||
                string.IsNullOrWhiteSpace(endereco.Bairro) ||
                string.IsNullOrWhiteSpace(endereco.Cidade);

            if (enderecoNaoEstaValido)
            {
                throw new Exception(ConstantesDeMensagens.MENSAGEM_PREENCHA_CAMPOS_ENDERECO);
            }
        }
    }
}
