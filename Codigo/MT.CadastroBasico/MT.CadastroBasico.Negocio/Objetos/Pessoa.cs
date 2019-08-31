using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.CadastroBasico.Negocio.Objetos
{
    /// <summary>
    /// Classe que representa a entidade pessoa.
    /// </summary>
    public class Pessoa
    {
        /// <summary>
        /// O identificador da pessoa.
        /// </summary>
        public int Identificador { get; set; }

        /// <summary>
        /// O nome da pessoa.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// O CPF da pessoa.
        /// </summary>
        public string Cpf { get; set; }

        /// <summary>
        /// O sexo da pessoa.
        /// </summary>
        public char Sexo { get; set; }

        /// <summary>
        /// O endereço da pessoa.
        /// </summary>
        public Endereco Endereco { get; set; }
    }
}
