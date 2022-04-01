using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace Calculadora
{
    public class User : Estrutura
    {
        Construtor user = new Construtor();
        public void TelaLogin()
        {
            CorFundoELetra();
            ClearAndLineBreak(true, "");
            LoopEstrutura();
            InterfaceLogin();
            ReadKey();
        }
        public void TelaRegister()
        {
            CorFundoELetra();
            ClearAndLineBreak(true, "");
            LoopEstrutura();
            InterfaceRegister();
            ReadKey();
            EstruturaLoginAndRegister();
        }

        public void InterfaceLogin()
        {
            TextAndPosition(13, 3, "CADASTRO USUARIO");
            TextAndPosition(3, 5, "=====================================");
            TextAndPosition(11, 7, "CONFIRME SEUS DADOS");

            for (var i = 1; i <= 3; i++)
            {
                Write("\n       USER: ");
                string confirmaLoginUsuario = ReadLine();

                Write("\n       PASSWORD: ");
                string confirmaLoginSenha = ReadLine();

                if (confirmaLoginUsuario == user.Username && confirmaLoginSenha == user.Password)
                {
                    TextAndPosition(6, 15, "LOGIN EFETUADO COM SUCESSO");
                    break;
                }
                else
                    TextAndPosition(6, 15, "USER E SENHA NÃO COMPATIVEL");
                InterfaceLogin();
            }
        }

        public void InterfaceRegister()
        {
            TextAndPosition(13, 3, "CADASTRO USUARIO");
            TextAndPosition(3, 5, "=====================================");
            TextAndPosition(11, 7, "INFORME SEUS DADOS");
            Write("\n       NAME: ");
            user.NomeUser = ReadLine();

            Write("\n       USER: ");
            user.Username = ReadLine();

            Write("\n       PASSWORD: ");
            user.Password = ReadLine();

            for (int i = 3; i >= 0; i--)
            {
                Write("\n       CONFIRM PASSWORD: ");
                string confirmeSenha = ReadLine();

                if (user.Password == confirmeSenha)
                {
                    TextAndPosition(11, 19, "CADASTRO EFETUADO");
                    break;
                }
                else
                    TextAndPosition(6, 15, "SENHA NÃO COMPATIVEL");
            }
        }


    }
}