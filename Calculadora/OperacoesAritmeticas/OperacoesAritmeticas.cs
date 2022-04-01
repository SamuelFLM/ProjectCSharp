using System;
using static System.Console;


namespace Calculadora
{
    public class OperacoesAritmeticas : Menu
    {
        Interacao interacao = new Interacao();

        public void Soma()
        {
            interacao.ClearETitle("Método Adição");
            interacao.NumeroEscolhaMetodoESinalOperacao("+");
            interacao.InteracaoOpcaoSwitch("Utilizar Adição Novamente");
            interacao.RetornaMetodoUtilizado(Soma);
        }

        public void Subtracao()
        {
            interacao.ClearETitle("Método Subtração");
            interacao.NumeroEscolhaMetodoESinalOperacao("-");
            interacao.InteracaoOpcaoSwitch("Utilizar Subtração Novamente");
            interacao.RetornaMetodoUtilizado(Subtracao);
        }

        public void Divisao()
        {
            interacao.ClearETitle("Método Divisão");
            interacao.NumeroEscolhaMetodoESinalOperacao("/");
            interacao.InteracaoOpcaoSwitch("Utilizar Divisão Novamente");
            interacao.RetornaMetodoUtilizado(Divisao);
        }

        public void Multiplicacao()
        {
            interacao.ClearETitle("Método Multiplicação");
            interacao.NumeroEscolhaMetodoESinalOperacao("*");
            interacao.InteracaoOpcaoSwitch("Utilizar Multiplicação Novamente");
            interacao.RetornaMetodoUtilizado(Multiplicacao);
        }

    }
}