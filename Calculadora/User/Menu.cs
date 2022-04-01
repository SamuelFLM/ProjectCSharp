using System;
using static System.Console;

namespace Calculadora
{
    public class Menu
    {
        public void MenuCalculadora()
        {
            Interacao interacao = new Interacao();
            interacao.MeCalculadora();
            interacao.MeOpcaoCalculadora();
        }

        public void MenuTabuada()
        {
            var interacao = new Interacao();
            interacao.MeTabuada();
            interacao.MeOpcaoTabuada();
        }

        public static float TrataExceptionNumeroInteiro(string message)
        {
            float retornoMetodo;
            while (true)
            {
                Write(message);
                string recebeNumeroInteiro = ReadLine();
                float tenteConverteInteiro;
                bool verificadorInteiro = float.TryParse(recebeNumeroInteiro, out tenteConverteInteiro);

                if (verificadorInteiro)
                {
                    retornoMetodo = tenteConverteInteiro;
                    break;
                }
                else
                    WriteLine("     Erro, Digite Novamente!");
            }
            return retornoMetodo;
        }

    }
}



