using MT.CadastroBasico.Negocio.Objetos;
using MT.CadastroBasico.Persistencia.BancoDeDados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.CadastroBasico.Persistencia.Repositorios
{
    /// <summary>
    /// Classe responsável por obter os dados de endereço.
    /// </summary>
    public class RepositorioDeEndereco
    {
        /// <summary>
        /// Consulta um endereço.
        /// </summary>
        /// <param name="identificador">O identificador do endereço.</param>
        /// <returns>As informações do endereço.</returns>
        public Endereco ConsulteEndereco(int identificador)
        {
            UtilBD.LimpeParametros();
            UtilBD.AdicionarParametro("@IDENDERECO", SqlDbType.Int, identificador);

            var sql = ConstantesBD.SQL_CONSULTE_ENDERECO;

            var dataTable = UtilBD.ExecuteConsulta(sql);
            var endereco = this.ObtenhaObjetoEnderecoMontado(dataTable, 0);

            UtilBD.Dispose();

            return endereco;
        }

        /// <summary>
        /// Consulta a lista de endereços do banco.
        /// </summary>
        /// <returns>Lista com as informações de endereço.</returns>
        public List<Endereco> ConsulteListaDeEnderecos()
        {
            UtilBD.LimpeParametros();

            var sql = ConstantesBD.SQL_CONSULTE_LISTA_DE_ENDERECO;
            var dataTable = UtilBD.ExecuteConsulta(sql);

            UtilBD.Dispose();

            var listaDeEnderecos = this.ObtenhaListaDeObjetosMontados(dataTable);

            return listaDeEnderecos;
        }

        /// <summary>
        /// Cadastra um endereço no banco.
        /// </summary>
        /// <param name="endereco">O endereço.</param>
        /// <returns>Indicador de sucesso na inserção.</returns>
        public bool CadastreEndereco(Endereco endereco)
        {
            UtilBD.LimpeParametros();
            UtilBD.AdicionarParametro("@DESCRICAO", SqlDbType.VarChar, endereco.Descricao);
            UtilBD.AdicionarParametro("@LOGRADOURO", SqlDbType.VarChar, endereco.Logradouro);
            UtilBD.AdicionarParametro("@BAIRRO", SqlDbType.VarChar, endereco.Bairro);
            UtilBD.AdicionarParametro("@CIDADE", SqlDbType.VarChar, endereco.Cidade);

            var sql = ConstantesBD.SQL_INSIRA_ENDERECO;

            return UtilBD.ExecutaAtualizacao(sql) > 0;
        }

        #region MÉTODOS PRIVADOS

        private List<Endereco> ObtenhaListaDeObjetosMontados(DataTable dataTable)
        {
            var listaDeEnderecos = new List<Endereco>();

            for (int contador = 0; contador < dataTable.Rows.Count; contador++)
            {
                var endereco = this.ObtenhaObjetoEnderecoMontado(dataTable, contador);

                listaDeEnderecos.Add(endereco);
            }

            return listaDeEnderecos;
        }

        private Endereco ObtenhaObjetoEnderecoMontado(DataTable dataTable, int numeroDaLinha)
        {
            var endereco = new Endereco
            {
                Identificador = Convert.ToInt32(dataTable.Rows[numeroDaLinha]["IDENDERECO"].ToString()),
                Descricao = dataTable.Rows[numeroDaLinha]["DESCRICAO"].ToString(),
                Logradouro = dataTable.Rows[numeroDaLinha]["LOGRADOURO"].ToString(),
                Bairro = dataTable.Rows[numeroDaLinha]["BAIRRO"].ToString(),
                Cidade = dataTable.Rows[numeroDaLinha]["CIDADE"].ToString()
            };

            return endereco;
        }

        #endregion
    }
}
