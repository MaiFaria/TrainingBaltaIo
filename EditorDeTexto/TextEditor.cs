namespace Training.BaltaIo.EditorDeTexto
{
    public abstract class TextEditor
    {
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Selecione o item desejado");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("---------------------------------------");

            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    OpenFile();
                    break;
                case 2:
                    FileEditor();
                    break;
                default:
                    break;
            }
        }

        private static void OpenFile()
        {
            Console.Clear();
            Console.WriteLine("Informe o caminho do arquivo.");
            var path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                var text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }

        private static void FileEditor()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo.");
            Console.WriteLine("Após conclusão, pressione a tecla ESC para sair.");
            Console.WriteLine("---------------------------------------");

            var text = string.Empty;

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Save(text);
        }

        private static void Save(string text)
        {
            Console.Clear();
            Console.WriteLine("Informe o caminho para salvar o arquivo.");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            Console.ReadLine();
            Menu();
        }
    }
}
