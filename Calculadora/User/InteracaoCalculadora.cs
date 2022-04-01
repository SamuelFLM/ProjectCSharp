using System;
using static System.Console;

namespace Calculadora
{
    public class Interacao : Estrutura
    {
        // Me = Menu
        // De = Dentro

        public void MeCalculadora()
        {
            EstruturaMenuCalculadora();
        }





        public void MeOpcaoCalculadora()
        {
            OperacoesAritmeticas operadoresAritmeticos = new OperacoesAritmeticas();
            short escolhaOpcao = TrataExceptionNumeroShort();

            switch (escolhaOpcao)
            {
                case 1: operadoresAritmeticos.Soma(); break;
                case 2: operadoresAritmeticos.Subtracao(); break;
                case 3: operadoresAritmeticos.Divisao(); break;
                case 4: operadoresAritmeticos.Multiplicacao(); break;
                case 5: MenuTabuada(); break;
                case 6: Environment.Exit(0); break;
                default: WriteLine("Tecla não reconhecida, Digite Novamente!"); break;
            }
        }

        public void MenuCalculadora()
        {
            Interacao interacao = new Interacao();
            interacao.MeCalculadora();
            interacao.MeOpcaoCalculadora();
        }
        public void MeTabuada()
        {
            EstruturaMenuTabuada();
        }
        public void MenuTabuada()
        {
            var interacao = new Interacao();
            interacao.MeTabuada();
            interacao.MeOpcaoTabuada();
        }
        public void MeOpcaoTabuada()
        {
            var operadores = new OperacoesTabuadas();
            short escolhaOpcao = TrataExceptionNumeroShort();

            switch (escolhaOpcao)
            {
                case 1: operadores.TabuadaSoma(); break;
                case 2: operadores.TabuadaSubtracao(); break;
                case 3: operadores.TabuadaDivisao(); break;
                case 4: operadores.TabuadaMultiplicacao(); break;
                case 5: MenuCalculadora(); break;
                case 6: Environment.Exit(0); break;
                default: WriteLine("Tecla não reconhecida, Digite Novamente!"); break;
            }
        }

        public void ClearETitle(string txt)
        {
            Clear();
            WriteLine($"{txt}");
            WriteLine("------------------");
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
        public void NumeroEscolhaTabuadaESinalOperacao(string sinalOperacao)
        {
            float numeroEscolhido = TrataExceptionNumeroInteiro("\nInforme um número: ");
            float qtdVezesNumero = (int)TrataExceptionNumeroInteiro($"\nQuantas Vezes o número {numeroEscolhido} deve ser repetido: ");

            switch (sinalOperacao)
            {
                case "+":
                    {
                        for (int i = 1; i <= qtdVezesNumero; i++)
                        {
                            float result = i + numeroEscolhido;
                            WriteLine($"{numeroEscolhido} + {i} = {result}");
                        }
                    }
                    break;
                case "-":
                    {
                        for (int i = 1; i <= qtdVezesNumero; i++)
                        {
                            float result = numeroEscolhido - i;
                            WriteLine($"{numeroEscolhido} - {i} = {result}");
                        }
                    }
                    break;
                case "/":
                    {
                        for (int i = 1; i <= qtdVezesNumero; i++)
                        {
                            float result = numeroEscolhido / i;
                            WriteLine($"{numeroEscolhido} / {i} = {result}");
                            if (result == 0)
                                break;
                        }
                    }
                    break;
                case "*":
                    {
                        for (int i = 1; i <= qtdVezesNumero; i++)
                        {
                            float result = numeroEscolhido * i;
                            WriteLine($"{numeroEscolhido} * {i} = {result}");

                            if (result == 0)
                                break;
                        }
                    }
                    break;
            }
        }

        public void NumeroEscolhaMetodoESinalOperacao(string sinalOperacao)
        {
            switch (sinalOperacao)
            {
                case "+":
                    {
                        float numOpcoes = TrataExceptionNumeroInteiro("\nQuantos Números a ser Somados: ");
                        float totalNumerosSomados = 0;
                        for (int i = 1; i <= numOpcoes; i++)
                        {
                            float amarzenaNumeros = TrataExceptionNumeroInteiro($"{i} - Informe um valor: ");
                            totalNumerosSomados += amarzenaNumeros;
                        }
                        WriteLine($"Result: {totalNumerosSomados}");
                    }
                    break;
                case "-":
                    {
                        float maiorNum = TrataExceptionNumeroInteiro("\nInforme um número: ");
                        float numOpcoes = TrataExceptionNumeroInteiro("\nQuantos vezes a ser Subtraido: ");
                        for (int i = 1; i <= numOpcoes; i++)
                        {
                            float amarzenaNumeros = TrataExceptionNumeroInteiro($"{i} - Informe um valor: ");
                            maiorNum -= amarzenaNumeros;
                            WriteLine($"Prévia Calculo: {maiorNum}");
                        }
                        WriteLine($"\nResult : {maiorNum}");
                    }
                    break;
                case "/":
                    {
                        float maiorNum = TrataExceptionNumeroInteiro("\nInforme o Dividendo: ");
                        float numOpcoes = TrataExceptionNumeroInteiro("\nQuantos vezes a ser Dividido: ");
                        for (int i = 1; i <= numOpcoes; i++)
                        {
                            float amarzenaNumeros = TrataExceptionNumeroInteiro($"\n{i} - Informe o divisor: ");
                            maiorNum /= amarzenaNumeros;
                            WriteLine($"\nPrévia Calculo Resto: {maiorNum}");
                        }
                        WriteLine($"\nResult : {maiorNum}");
                    }
                    break;
                case "*":
                    {
                        float numeroEscolhido = TrataExceptionNumeroInteiro("\nInforme um número: ");
                        float qtdVezesNumero = (int)TrataExceptionNumeroInteiro($"\nInforme o multiplicador: ");
                        float result = numeroEscolhido * qtdVezesNumero;
                        WriteLine($"\nCalculo Produto: {result}");
                    }
                    break;
            }
        }
        public void InteracaoOpcaoSwitch(string txt)
        {
            WriteLine("\nopções: ");
            WriteLine($"[1] - {txt}");
            WriteLine("[2] - Voltar Menu Calculadora");
            WriteLine("[3] - Voltar Menu Tabuada");
            WriteLine("[4] - Exit");
        }

        public void RetornaMetodoUtilizado(RetornaMetodoEventhandler metodo)
        {
            float op = (int)TrataExceptionNumeroInteiro("\nDigite: ");
            switch (op)
            {
                case 1: metodo.Invoke(); break;
                case 2: MenuCalculadora(); break;
                case 3: MenuTabuada(); break;
                case 4: Environment.Exit(0); break;
                default: WriteLine("Tecla não reconhecida, Digite Novamente!"); break;
            }
        }
    }

    public delegate void RetornaMetodoEventhandler();


}
