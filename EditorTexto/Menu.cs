using System;
using System.IO;
using static System.Console;


namespace EditorTexto
{
    class Menu
    {

        public void MenuInteracaoUsuario()
        {
            Clear();
            WriteLine("Bem vindo");
            WriteLine("----------------");

            WriteLine("\n[1] - Criar Arquivo Txt");
            WriteLine("[2] - Abrir Arquivo Txt");
            WriteLine("[3] - Sair");

            short option = TrataExceptionInteiro("\nDigite: ");

            switch (option)
            {
                case 1: CriarArquivoTxt(); break;
                case 2: AbrirArquivoTxt(); break;
                case 3: Environment.Exit(0); break;
                default: break;
            }
        }



        public void CriarArquivoTxt()
        {

            Clear();




        }

        public void AbrirArquivoTxt()
        {

        }

        public void SalvarArquivoTxt(string text)
        {
            Clear();

            WriteLine("Informe nome do arquivo Txt");
            string nomeTxt = ReadLine();

            var path = (@$"C:\pastaTest\");

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            path += $"{nomeTxt}.txt";

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            WriteLine($"Arquivo {path} salvo com sucesso!");
            ReadKey();
            MenuInteracaoUsuario();
        }



        public short TrataExceptionInteiro(string message)
        {
            short retorno;

            while (true)
            {
                Write(message);
                string recebeNumeroInteiro = ReadLine();
                short tentaConverteNumeroInteiro;
                bool verificaConversao = short.TryParse(recebeNumeroInteiro, out tentaConverteNumeroInteiro);

                if (verificaConversao)
                {
                    retorno = tentaConverteNumeroInteiro;
                    break;
                }
                WriteLine("Tecla não reconhecida, Digite Novamente!");
            }
            return retorno;
        }
    }
}
