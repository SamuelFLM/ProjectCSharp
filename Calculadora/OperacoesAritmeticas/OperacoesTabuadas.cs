using System;
using static System.Console;


namespace Calculadora
{
    public class OperacoesTabuadas : Menu
    {

        Interacao interacao = new Interacao();
        public void TabuadaSoma()
        {
            interacao.ClearETitle("Tabuada Adição");
            interacao.NumeroEscolhaTabuadaESinalOperacao("+");
            interacao.InteracaoOpcaoSwitch("Utilizar Tabuada Adição Novamente");
            interacao.RetornaMetodoUtilizado(TabuadaSoma);
        }
        public void TabuadaSubtracao()
        {
            interacao.ClearETitle("Tabuada Subtração");
            interacao.NumeroEscolhaTabuadaESinalOperacao("-");
            interacao.InteracaoOpcaoSwitch("Utilizar Tabuada Subtração Novamente");
            interacao.RetornaMetodoUtilizado(TabuadaSubtracao);
        }
        public void TabuadaDivisao()
        {
            interacao.ClearETitle("Tabuada Divisão");
            interacao.NumeroEscolhaTabuadaESinalOperacao("/");
            interacao.InteracaoOpcaoSwitch("Utilizar Tabuada Divisão Novamente");
            interacao.RetornaMetodoUtilizado(TabuadaDivisao);
        }
        public void TabuadaMultiplicacao()
        {
            interacao.ClearETitle("Tabuada Multiplicação");
            interacao.NumeroEscolhaTabuadaESinalOperacao("*");
            interacao.InteracaoOpcaoSwitch("Utilizar Tabuada Multiplicação Novamente");
            interacao.RetornaMetodoUtilizado(TabuadaMultiplicacao);
        }
    }
}