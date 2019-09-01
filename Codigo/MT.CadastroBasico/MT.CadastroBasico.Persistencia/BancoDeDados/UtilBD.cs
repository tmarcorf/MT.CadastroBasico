using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.CadastroBasico.Persistencia.BancoDeDados
{
    public static class UtilBD
    {
        /// <summary>
        /// A conexão com o banco.
        /// </summary>
        private static SqlConnection Conexao = new SqlConnection();

        /// <summary>
        /// O comando a ser executado.
        /// </summary>
        private static SqlCommand Comando = new SqlCommand();

        /// <summary>
        /// O parâmetro do comando.
        /// </summary>
        private static SqlParameter Parametro = new SqlParameter();

        /// <summary>
        /// Obtém a conexão com o banco.
        /// </summary>
        /// <returns>A conexão com o banco.</returns>
        private static SqlConnection ObtenhaSqlConnection()
        {
            try
            {
                string stringDeConexao = ConfigurationManager
                .ConnectionStrings[ConstantesBD.STRING_DE_CONEXAO].ConnectionString;

                Conexao = new SqlConnection(stringDeConexao);
                
                if (Conexao.State == ConnectionState.Closed)
                {
                    Conexao.Open();
                }
                             
                return Conexao;
            }
            catch (SqlException excecao)
            {
                throw excecao;
            }
        }

        /// <summary>
        /// Abre a conexão com o banco.
        /// </summary>
        public static void Open()
        {
            Conexao.Open();
        }

        /// <summary>
        /// Fecha a conexão com o banco.
        /// </summary>
        public static void Close()
        {
            Conexao.Close();
        }

        /// <summary>
        /// Adiciona um parâmetro ao comando sql.
        /// </summary>
        /// <param name="nome">Nome da coluna no banco.</param>
        /// <param name="tipo">O tipo do parâmetro.</param>
        /// <param name="tamanho">O tamanho do parâmetro.</param>
        /// <param name="valor">O valor do parâmetro.</param>
        public static void AdicionarParametro(string nome, SqlDbType tipo, int tamanho, object valor)
        {
            Parametro = new SqlParameter();
            Parametro.ParameterName = nome;
            Parametro.SqlDbType = tipo;
            Parametro.Size = tamanho;
            Parametro.Value = valor;

            Comando.Parameters.Add(Parametro);
        }

        /// <summary>
        /// Adiciona um parâmetro ao comando sql.
        /// </summary>
        /// <param name="nome">O nome da coluna no banco.</param>
        /// <param name="tipo">O tipo do parâmetro.</param>
        /// <param name="valor">O valor do parâmetro.</param>
        public static void AdicionarParametro(string nome, SqlDbType tipo, object valor)
        {
            Parametro = new SqlParameter();
            Parametro.ParameterName = nome;
            Parametro.SqlDbType = tipo;
            Parametro.Value = valor;
            
            Comando.Parameters.Add(Parametro);
        }

        /// <summary>
        /// Remove um parâmetro do comando.
        /// </summary>
        /// <param name="pNome">O nome do parâmetro.</param>
        public static void RemoverParametro(string pNome)
        {
            if (Comando.Parameters.Contains(pNome))
            {
                Comando.Parameters.Remove(pNome);
            }
        }

        /// <summary>
        /// Limpa os parâmetros do comando.
        /// </summary>
        public static void LimpeParametros()
        {
            Comando.Parameters.Clear();
        }

        /// <summary>
        /// Executa uma consulta sql.
        /// </summary>
        /// <param name="sql">O texto do comando sql.</param>
        /// <returns>Um DataTable com o resultado da consulta.</returns>
        public static DataTable ExecuteConsulta(string sql)
        {
            try
            {
                Comando.Connection = ObtenhaSqlConnection();

                Comando.CommandText = sql;
                
                Comando.ExecuteScalar();
                
                IDataReader dataReader = Comando.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                
                Conexao.Close();
                
                return dataTable;
            }
            catch (Exception excecao)
            {                     
                throw excecao;
            }
        }

        /// <summary>
        /// Executa uma instrução INSERT, UPDATE OU DELETE.
        /// </summary>
        /// <param name="sql">A string com o texto do comando.</param>
        /// <returns>A quantidade de linhas afetadas.</returns>
        public static int ExecutaAtualizacao(string sql)
        {
            try
            {
                Comando.Connection = ObtenhaSqlConnection();
                Comando.CommandText = sql;
                
                int qtdLinhasAfetadas = Comando.ExecuteNonQuery();

                Conexao.Close();
                
                return qtdLinhasAfetadas;
            }
            catch (Exception excecao)
            {
                throw excecao;
            }
        }

        /// <summary>
        /// Libera os recursos de memória utilizados.
        /// </summary>
        public static void Dispose()
        {
            Conexao.Dispose();
        }
    }
}
