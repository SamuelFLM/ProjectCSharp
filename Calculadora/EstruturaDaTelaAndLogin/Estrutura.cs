using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Calculadora
{
    public class Estrutura
    {
        public void EstruturaLoginAndRegister()
        {
            var user = new User();
            ClearAndLineBreak(true, "");
            CorFundoELetra();
            LoopEstrutura();
            IntefaceERP();
            SwitchIntefaceERP();
        }

        public void IntefaceERP()
        {
            TextAndPosition(16, 3, "ERP SYSTEM");
            TextAndPosition(3, 5, "=====================================");
            TextAndPosition(16, 7, "BEM VINDO");
            TextAndPosition(4, 10, "INFORME UMA OPÇÃO");
            TextAndPosition(7, 13, "[1] - LOGIN");
            TextAndPosition(7, 16, "[2] - REGISTRA-SE");
            TextAndPosition(7, 19, "Digite: ");
            TextAndPosition(3, 22, "=====================================");
            SetCursorPosition(15, 19);
        }
        public void SwitchIntefaceERP()
        {
            var user = new User();
            short option = TrataExceptionNumeroShort();

            switch (option)
            {
                case 1: user.TelaLogin(); break;
                case 2: user.TelaRegister(); ReadKey(); EstruturaLoginAndRegister(); break;
                default: ReadKey(); SwitchIntefaceERP(); break;
            }
        }


        public void EstruturaMenuCalculadora()
        {
            var interacao = new Interacao();
            ClearAndLineBreak(true, "");
            CorFundoELetra();
            LoopEstrutura();
            InterfaceMenuCalculadora();
            interacao.MeOpcaoCalculadora();

        }
        public void EstruturaMenuTabuada()
        {
            var interacao = new Interacao();
            ClearAndLineBreak(true, "");
            CorFundoELetra();
            LoopEstrutura();
            InterfaceMenuTabuada();
            interacao.MeOpcaoTabuada();

        }

        public void InterfaceMenuCalculadora()
        {
            TextAndPosition(16, 3, "CALCULADORA");
            TextAndPosition(3, 4, "=====================================");
            TextAndPosition(11, 5, "SELECIONE UMA OPÇÃO ");
            TextAndPosition(6, 7, "[1] - Adição ");
            TextAndPosition(6, 9, "[2] - Subtração ");
            TextAndPosition(6, 11, "[3] - Divisão ");
            TextAndPosition(6, 13, "[4] - Multiplicação ");
            TextAndPosition(6, 15, "[5] - Tabuada ");
            TextAndPosition(6, 17, "[6] - Exit ");
            TextAndPosition(6, 19, "DIGITE:  ");
            TextAndPosition(3, 22, "=====================================");
            SetCursorPosition(14, 19);
        }
        public void InterfaceMenuTabuada()
        {
            TextAndPosition(16, 3, "TABUADA v1.0");
            TextAndPosition(3, 4, "=====================================");
            TextAndPosition(11, 5, "SELECIONE UMA OPÇÃO ");
            TextAndPosition(6, 7, "[1] - Adição ");
            TextAndPosition(6, 9, "[2] - Subtração ");
            TextAndPosition(6, 11, "[3] - Divisão ");
            TextAndPosition(6, 13, "[4] - Multiplicação ");
            TextAndPosition(6, 15, "[5] - Voltar ");
            TextAndPosition(6, 17, "[6] - Exit ");
            TextAndPosition(6, 19, "DIGITE:  ");
            TextAndPosition(3, 22, "=====================================");
            SetCursorPosition(14, 19);
        }


        /// <summary>
        /// Metodos para deixar o code mais "Limpo"
        /// </summary>
        public void TextAndPosition(int distancia, int linha, string text)
        {
            SetCursorPosition(distancia, linha);
            WriteLine(text);
        }
        public void ClearAndLineBreak(bool limpa, string quebra)
        {
            if (limpa)
                Console.Clear();
            Write(quebra);
        }
        public short TrataExceptionNumeroShort()
        {
            short retorno;
            while (true)
            {
                string recebeNumeroShort = ReadLine();
                short tenteConverteShort;
                bool verificadorShort = short.TryParse(recebeNumeroShort, out tenteConverteShort);

                if (verificadorShort)
                {
                    retorno = tenteConverteShort;
                    break;
                }
                else
                    WriteLine("     Erro, Digite Novamente!");
            }
            return retorno;
        }
        public void LoopEstrutura()
        {
            ClearAndLineBreak(true, "\n");
            LoopLineHorizontal();
            LoopLineVertical();
            LoopLineHorizontal();
        }
        public void LoopLineHorizontal()
        {
            Write("+");
            for (int i = 0; i <= 40; i++)
                Write("-");
            Write("+");
            ClearAndLineBreak(false, "\n");
        }
        public void LoopLineVertical()
        {
            for (int lines = 0; lines <= 20; lines++)
            {
                Write("|");
                for (int i = 0; i <= 40; i++)
                    Write(" ");

                Write("|");
                Write("\n");
            }
        }
        public void CorFundoELetra()
        {
            BackgroundColor = ConsoleColor.Black;
            ForegroundColor = ConsoleColor.Green;
        }



    }
}