using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.CadastroBasico.Persistencia.BancoDeDados
{
    public static class ConstantesBD
    {
        /// <summary>
        /// A string de conexão.
        /// </summary>
        public static string STRING_DE_CONEXAO = @"Server=PC-MT\DEVELOPER17;
                                                   Database=CadastroBasico;
                                                   User Id=sa;
                                                   Password=1234";

        #region ENDERECO

        /// <summary>
        /// Obtém todos os endereços do banco.
        /// </summary>
        public static string SQL_LISTA_DE_ENDERECO = @"SELECT IDENDERECO, DESCRICAO, LOGRADOURO, BAIRRO, CIDADE
                                                       FROM CB_ENDERECO";

        #endregion
    }
}
