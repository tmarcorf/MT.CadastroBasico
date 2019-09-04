namespace MT.CadastroBasico.Negocio.Objetos
{
    /// <summary>
    /// Classe que representa a entidade endereço.
    /// </summary>
    public class Endereco
    {
        /// <summary>
        /// O identificador do enderço.
        /// </summary>
        public int Identificador { get; set; }

        /// <summary>
        /// A descrição do endereço.
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// O logradouro do endereço.
        /// </summary>
        public string Logradouro { get; set; }

        /// <summary>
        /// O bairro do endereço.
        /// </summary>
        public string Bairro { get; set; }

        /// <summary>
        /// A cidade do endereço.
        /// </summary>
        public string Cidade { get; set; }

        /// <summary>
        /// O construtor da classe.
        /// </summary>
        public Endereco()
        {
        }

        /// <summary>
        /// O método ToString() sobrescrito.
        /// </summary>
        /// <returns>As informações do endereço.</returns>
        public override string ToString()
        {
            return
                Descricao + " | " +
                Logradouro + " " +
                Bairro + " " +
                Cidade;
        }
    }
}
