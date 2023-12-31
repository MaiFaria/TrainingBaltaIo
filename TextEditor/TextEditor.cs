﻿namespace Training.BaltaIo.EditorDeTexto;

public abstract class TextEditor
{
    public static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Select the desired item");
        Console.WriteLine("1 - Open file");
        Console.WriteLine("2 - Create new file");
        Console.WriteLine("0 - Exit");
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
        Console.WriteLine("Enter the file path.");
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
        Console.WriteLine("Enter your text below.");
        Console.WriteLine("After completion, press the ESC key to exit.");
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
        Console.WriteLine("Enter the path to save the file.");
        var path = Console.ReadLine();

        using (var file = new StreamWriter(path))
        {
            file.Write(text);
        }

        Console.WriteLine($"File {path} saved successfully!");
        Console.ReadLine();
        Menu();
    }
}
