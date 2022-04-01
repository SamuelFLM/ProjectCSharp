using System;
using static System.Console;


namespace EditorHTML
{

    public static class Menu
    {

        public static void Show()
        {
            Clear();

            BackgroundColor = ConsoleColor.Blue;
            //Letra
            ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();

            var option = short.Parse(ReadLine());
            HandleManuOption(option);

        }

        public static void DrawScreen()
        {
            Write("+");
            for (int i = 0; i <= 30; i++)
                Write("-");

            Write("+");
            Write("\n");

            for (int lines = 0; lines <= 10; lines++)
            {
                Write("|");
                for (int i = 0; i <= 30; i++)
                    Write(" ");

                Write("|");
                Write("\n");
            }

            Write("+");
            for (int i = 0; i <= 30; i++)
                Write("-");

            Write("+");
        }

        public static void WriteOptions()
        {
            SetCursorPosition(3, 2);
            WriteLine("Editor HTML");
            SetCursorPosition(3, 3);
            WriteLine("==================");
            SetCursorPosition(3, 4);
            WriteLine("Selecione uma opcao abaixo");
            SetCursorPosition(3, 6);
            WriteLine("1- Novo arquivo");
            SetCursorPosition(3, 7);
            WriteLine("2- Abrir");
            SetCursorPosition(3, 9);
            WriteLine("0- Sair");
            SetCursorPosition(3, 10);
            Write("Opção: ");
        }

        public static void HandleManuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: WriteLine("View"); break;
                case 0:
                    {
                        Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }

        }


    }
}