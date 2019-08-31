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
        public Endereco ConsulteEndereco(int identificador)
        {

        }

        /// <summary>
        /// Obtém a lista de endereços do banco.
        /// </summary>
        /// <returns></returns>
        public List<Endereco> ObtenhaListaDeEnderecos()
        {
            var listaDeEnderecos = new List<Endereco>();
            var sql = ConstantesBD.SQL_LISTA_DE_ENDERECO;

            var dataTable = UtilBD.ExecuteConsulta(sql);

            listaDeEnderecos = this.ObtenhaListaDeObjetosMontados(dataTable);

            return listaDeEnderecos;
        }

        private List<Endereco> ObtenhaListaDeObjetosMontados(DataTable dataTable)
        {
            var listaDeEnderecos = new List<Endereco>();

            for (int contador = 0; contador < dataTable.Rows.Count; contador++)
            {
                var endereco = new Endereco();

                endereco.Identificador = Convert.ToInt32(dataTable.Rows[contador]["IDENDERECO"].ToString());
                endereco.Descricao = dataTable.Rows[contador]["DESCRICAO"].ToString();
                endereco.Logradouro = dataTable.Rows[contador]["LOGRADOURO"].ToString();
                endereco.Bairro = dataTable.Rows[contador]["BAIRRO"].ToString();
                endereco.Cidade = dataTable.Rows[contador]["CIDADE"].ToString();

                listaDeEnderecos.Add(endereco);
            }

            return listaDeEnderecos;
        }
    }
}
