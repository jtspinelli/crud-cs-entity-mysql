namespace CRUDFuncionarios
{
    internal class CrudFuncionarios
    {
        public static void ListarFuncionarios()
        {
            using var db = new FuncionarioContext();
            foreach (var funcionario in db.Funcionarios)
            {
                Console.WriteLine(funcionario.Nome);
            }
        }

        public static void EncontrarFuncionario()
        {
            var nome = UserInput.AskForName("Digite o nome do funcionário que deseja procurar: ");

            using var db = new FuncionarioContext();
            var funcionario = db.Funcionarios.FirstOrDefault(f => f.Nome == nome);

            Console.WriteLine(funcionario != null
                ? $"\nFuncionário {funcionario.Nome} encontrado!"
                : "\nFuncionário não encontrado.");
        }

        public static void AdicionarFuncionario()
        {
            var nome = UserInput.AskForName("Digite o nome do novo funcionário: ");

            var novoFuncionario = new Funcionario(nome);

            using var db = new FuncionarioContext();
            db.Funcionarios.Add(novoFuncionario);

            Console.WriteLine(db.SaveChanges() > 0
                ? $"\nFuncionário {nome} cadastrado com sucesso!"
                : "\nErro: funcionário não cadastrado."
            );
        }

        public static void ExcluirFuncionario()
        {
            var nome = UserInput.AskForName("Digite o nome do funcionário que deseja excluir: ");

            using var db = new FuncionarioContext();

            if(db.Funcionarios.FirstOrDefault(f => f.Nome == nome) is { } funcionario)
            {
                db.Funcionarios.Remove(funcionario);

                Console.WriteLine(db.SaveChanges() > 0
                    ? $"\nFuncionário {funcionario.Nome} excluído!"
                    : "\nErro: funcionário não excluído."
                );
            }
            else
            {
                Console.WriteLine("\nFuncionário não encontrado.");
            }
        }

        public static void EditarFuncionario()
        {
            var nome = UserInput.AskForName("Digite o nome do funcionário que deseja atualizar: ");

            using var db = new FuncionarioContext();

            if (db.Funcionarios.FirstOrDefault(f => f.Nome == nome) is { } funcionario)
            {
                var novoNome = UserInput.AskForName("Qual o novo nome? ");

                funcionario.Nome = novoNome;

                Console.WriteLine(db.SaveChanges() > 0
                    ? $"\nNome do funcionário {nome} alterado para {novoNome}."
                    : $"\nErro: nome do funcionário {nome} não foi alterado."
                );
            }
            else
            {
                Console.WriteLine("\nFuncionário não encontrado.");
            }
        }
    }
}
