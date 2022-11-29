using System.Text;

namespace CRUDFuncionarios
{
    internal class Program
    {
        private const int Listar = 1;
        private const int Encontrar = 2;
        private const int Adicionar = 3;
        private const int Editar = 4;
        private const int Excluir = 5;
        private const int Sair = 0;
        private static int chosenOption;

        private static StringBuilder GetOpcoes()
        {
            var opcoes = new StringBuilder();

            opcoes.AppendLine("\nEscolha uma das opções abaixo:\n");
            opcoes.AppendLine("1 - Listar funcionários");
            opcoes.AppendLine("2 - Encontrar funcionário");
            opcoes.AppendLine("3 - Adicionar funcionário");
            opcoes.AppendLine("4 - Editar funcionário");
            opcoes.AppendLine("5 - Excluir funcionário");
            opcoes.AppendLine("0 - Sair");
            opcoes.Append("OPÇÃO: ");

            return opcoes;
        }

        public static void ListarOpcoes()
        {
            Console.WriteLine(GetOpcoes());
        }

        private static bool UsuarioNaoSair()
        {
            return chosenOption != Sair;
        }



        private static void Main(string[] args)
        {
            Console.WriteLine("\n=============================================");
            Console.WriteLine("Bem-vindo ao Gerenciamento de Funcionários!");
            Console.WriteLine("=============================================");
            
            do
            {
                chosenOption = UserInput.AskForOption();

                switch (chosenOption)
                {
                    case Listar:
                        Console.WriteLine("\n=============================");
                        Console.WriteLine("LISTAGEM DE FUNCIONÁRIOS\n");

                        CrudFuncionarios.ListarFuncionarios();

                        Console.WriteLine("=============================");
                        break;

                    case Encontrar:
                        Console.WriteLine("\n=============================");
                        Console.WriteLine("BUSCA DE FUNCIONÁRIO\n");

                        CrudFuncionarios.EncontrarFuncionario();

                        Console.WriteLine("=============================");
                        break;

                    case Adicionar:
                        Console.WriteLine("\n=============================");
                        Console.WriteLine("NOVO FUNCIONÁRIO\n");

                        CrudFuncionarios.AdicionarFuncionario();

                        Console.WriteLine("=============================");
                        break;

                    case Excluir:
                        Console.WriteLine("\n=============================");
                        Console.WriteLine("EXCLUIR FUNCIONÁRIO\n");

                        CrudFuncionarios.ExcluirFuncionario();

                        Console.WriteLine("=============================");
                        break;

                    case Editar:
                        Console.WriteLine("\n=============================");
                        Console.WriteLine("EDITAR FUNCIONÁRIO\n");

                        CrudFuncionarios.EditarFuncionario();

                        Console.WriteLine("=============================");
                        break;
                }

            } while (UsuarioNaoSair());

            Console.WriteLine("\nPrograma finalizado.");
        }
    }
}