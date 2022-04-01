using System;
using System.IO;
using static System.Console;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }


        static void Menu()
        {
            Clear();
            WriteLine("O que voce deseja fazer?");
            WriteLine("1 - Abrir o arquivo");
            WriteLine("2 - Criar novo arquivo");
            WriteLine("0 - Sair");
            short option = short.Parse(ReadLine());

            switch (option)
            {
                case 1: Abrir(); break;
                case 2: Editar(); break;
                case 0: Environment.Exit(0); break;
                default: break;
            }
        }

        static void Abrir()
        {
            Clear();

            WriteLine("Qual caminho do arquivo?");
            string path = ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                WriteLine(text);
            }

            WriteLine("");
            ReadLine();
            Menu();
        }

        static void Editar()
        {
            Clear();

            WriteLine("Digite seu texto abaixo (ESC para sair)");
            WriteLine("------------------------");

            string text = "";

            do
            {
                text += ReadLine();
                text += Environment.NewLine;

            } while (ReadKey().Key != ConsoleKey.Escape);

            Salvar(text);



        }

        static void Salvar(string text)
        {
            Clear();

            WriteLine("Qual caminho para salvar o arquivo?");

            var path = ReadLine();

            // using serve para abrir/fechar o objeto automatico
            using (var file = new StreamWriter(path))
            {

                file.Write(text);

            }
            WriteLine($"Arquivo {path} salvo com sucesso!");
            ReadLine();
            Menu();
        }

    }
}
