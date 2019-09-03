using MT.CadastroBasico.Negocio.Objetos;
using MT.CadastroBasico.Negocio.Validacoes;
using MT.CadastroBasico.Persistencia.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.CadastroBasico.Servicos
{
    /// <summary>
    /// O serviço de endereço.
    /// </summary>
    public class ServicoDeEndereco
    {
        private readonly RepositorioDeEndereco _repositorioDeEndereco;
        private readonly ValidacoesDeEndereco _validadorEndereco;

        public ServicoDeEndereco()
        {
            _repositorioDeEndereco = new RepositorioDeEndereco();
            _validadorEndereco = new ValidacoesDeEndereco();
        }

        /// <summary>
        /// Consulta um endereço.
        /// </summary>
        /// <param name="identificador">O identificador do endereço.</param>
        /// <returns>As informações do endereço.</returns>
        public Endereco Consultar(int identificador)
        {
            return _repositorioDeEndereco.ConsulteEndereco(identificador);
        }

        /// <summary>
        /// Consulta a lista de endereços.
        /// </summary>
        /// <returns>Lista com as informações de endereço.</returns>
        public List<Endereco> ConsultarLista()
        {
            return _repositorioDeEndereco.ConsulteListaDeEnderecos();
        }

        /// <summary>
        /// Cadastra um endereço.
        /// </summary>
        /// <param name="endereco">O endereço.</param>
        /// <returns>Indicador de sucesso na inserção.</returns>
        public bool Cadastrar(Endereco endereco)
        {
            try
            {
                _validadorEndereco.Valide(endereco);

                return _repositorioDeEndereco.CadastreEndereco(endereco);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
