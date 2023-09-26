namespace Training.BaltaIo.Calculadora
{
    public abstract class Calculadora
    {
        public static void Menu()
        {
            var res = ValidateDesiredMenu();

            if (res == 0)
                Environment.Exit(0);

            ValidateValues(out float v1, out float v2);

            switch (res)
            {
                case 1:
                    Result((v1 + v2), "Soma");
                    break;
                case 2:
                    Result((v1 / v2), "Divisão");
                    break;
                case 3:
                    Result((v1 * v2), "Multiplicação");
                    break;
                case 4:
                    Result((v1 - v2), "Subtração");
                    break;
                default:
                    Menu();
                    break;
            }
        }

        private static short ValidateDesiredMenu()
        {
            Console.Clear();

            Console.WriteLine("Selecione a operação desejada");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Divisão");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Subtração");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("---------------------------------------");

            return short.Parse(Console.ReadLine());
        }

        private static void ValidateValues(out float v1, out float v2)
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor: ");
            v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
        }

        private static void Result(float result, string v)
        {
            Console.WriteLine($"O resultado da {v} é {result}");
            Console.ReadKey();
            Menu();
        }
    }
}
