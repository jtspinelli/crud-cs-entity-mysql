namespace CRUDFuncionarios
{
    internal class UserInput
    {
        private static bool InvalidName(string? nome)
        {
            return nome == null || (nome.Length == 0);
        }

        private static bool ValidOption(string? option)
        {
            return int.TryParse(option, out var optionAsNumber) & optionAsNumber >= 0 & optionAsNumber <= 5;
        }

        private static bool InvalidOption(string? option)
        {
            return !ValidOption(option);
        }

        public static string AskForName(string message)
        {
            string nome;

            do
            {
                Console.Write(message);
                nome = Console.ReadLine();

                if (InvalidName(nome))
                {
                    Console.WriteLine("Nome inválido");
                }
            } while (InvalidName(nome));

            return nome ?? "";
        }

        public static int AskForOption()
        {
            string? userInput;
            int num;

            do
            {
                Program.ListarOpcoes();
                userInput = Console.ReadLine();

                if (InvalidOption(userInput))
                {
                    Console.WriteLine("\n***Opção inválida.");
                }
            }
            while (InvalidOption(userInput));

            return int.TryParse(userInput, out num) ? int.Parse(userInput) : -1;
        }
    }
}
