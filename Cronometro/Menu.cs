using System;
using static System.Console;

namespace Cronometro
{
    class Menu
    {
        public void MenuInteracaoUser()
        {
            Clear();
            WriteLine("Bem vindo!");

            while (true)
            {
                Write("\nInforme Seu User: ");
                string armazenaNome = ReadLine();

                if (armazenaNome != "")
                {
                    WriteLine("Cadastro Realizado!");
                    break;
                }
                else
                    WriteLine("Erro, Informe um nome!");
            }
        }



    }
}
