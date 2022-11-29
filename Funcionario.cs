using System.ComponentModel.DataAnnotations;

namespace CRUDFuncionarios
{
    internal class Funcionario
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public Funcionario(string nome)
        {
            this.Nome = nome;
            this.Id = System.Guid.NewGuid().ToString();
        }
    }
}
