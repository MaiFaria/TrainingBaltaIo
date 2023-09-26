namespace Training.BaltaIo.Cronometro
{
    public abstract class Stopwatch
    {
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Quanto tempo deseja contar?");
            Console.WriteLine("Digite o valor + S para Segundo");
            Console.WriteLine("Digite o valor + M para Minuto");
            Console.WriteLine("Digite 0 para Sair");
            Console.WriteLine("---------------------------------------");

            var data = Console.ReadLine().ToLower();

            DataValidations(data);
        }

        private static void DataValidations(string data)
        {
            if (data.Equals(null) || data.Length.Equals(0) || data.Length.Equals(1))
            {
                Console.WriteLine("Valor não encontrado - Digite o valor desejado para realizar a operação!");
                Console.WriteLine("Tente novamente por favor.");
                Thread.Sleep(3000);
                Menu();
            }

            var type = char.MinValue;
            var time = 0;

            if (data.Length > 1)
            {
                type = char.Parse(data.Substring(data.Length - 1, 1));
                time = int.Parse(data.Substring(0, data.Length - 1));
            }

            if (time.Equals(0))
            {
                Console.WriteLine("Até mais!");
                Environment.Exit(0);
            }

            MultiplierValidations(type, time);
        }

        private static void MultiplierValidations(char type, int time)
        {
            var multiplier = 1;

            if (type.Equals('m'))
                multiplier = 60;

            PreStart(time * multiplier);
        }

        private static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go!");
            Thread.Sleep(1500);

            Start(time);
        }

        private static void Start(int time)
        {
            var currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finished!");
            Menu();
        }
    }
}
