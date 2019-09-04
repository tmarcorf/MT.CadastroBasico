namespace MT.CadastroBasico.Persistencia.BancoDeDados
{
    /// <summary>
    /// Classe responsável pelas constantes usadas nas transações com o banco.
    /// </summary>
    public static class ConstantesBD
    {
        /// <summary>
        /// A string de conexão.
        /// </summary>
        public static string STRING_DE_CONEXAO = @"INSIRA AQUI A STRING DE CONEXÃO";

        #region ENDERECO

        /// <summary>
        /// SQL que obtém um endereço conforme o identificador.
        /// </summary>
        public static string SQL_CONSULTE_ENDERECO = @"SELECT IDENDERECO, DESCRICAO, LOGRADOURO, BAIRRO, CIDADE
                                                       FROM CB_ENDERECO
                                                       WHERE IDENDERECO = @IDENDERECO";

        /// <summary>
        /// SQL que obtém todos os endereços do banco.
        /// </summary>
        public static string SQL_CONSULTE_LISTA_DE_ENDERECO = @"SELECT IDENDERECO, DESCRICAO, LOGRADOURO, BAIRRO, CIDADE
                                                                FROM CB_ENDERECO";

        /// <summary>
        /// SQL que insere um endereço.
        /// </summary>
        public static string SQL_INSIRA_ENDERECO = @"INSERT INTO CB_ENDERECO (DESCRICAO, LOGRADOURO, BAIRRO, CIDADE)
                                                     VALUES (@DESCRICAO, @LOGRADOURO, @BAIRRO, @CIDADE)";

        /// <summary>
        /// Deleta uma lista de endereços.
        /// </summary>
        public static string SQL_EXCLUA_LISTA = @"DELETE FROM CB_ENDERECO
                                                  WHERE IDENDERECO IN (@IDENDERECO)";

        #endregion
    }
}
