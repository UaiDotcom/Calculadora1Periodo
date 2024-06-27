using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    { 
        
        static void Main(string[] args)
        {
            Cabecalhopadrao();
            Menu();
        }

        //Procedimentos Base do Programa e Validações
        static void Cabecalhopadrao()
        {
            //Cabeçalho Que Aparece em Todas As Telas

            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine("|Calculadora Didática                                              |");
            Console.WriteLine("|------------------------------------------------------------------|");
        }
        static void titulo(string x, string y)
        {
            //          Esse Procedimento mostra o título referente a qual operação está sera feita
            Console.Clear();
            Cabecalhopadrao();
            string titulo = $"|A Conversão de Bases Será de {x} para {y} ";
            int TamanhoTitulo = titulo.Length;

            Console.Write(titulo);
            calculaEspaço(TamanhoTitulo);
            Console.Write("|\n");
            Console.WriteLine("|------------------------------------------------------------------|");
        }
        static void Menu()
        {
            //Menu de Seleção de Qual Operação Será Feita
            string opcao = "";

            //Front

            Console.WriteLine("|Menu de Conversão de Base:                                        |");
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine("|1.  Decimal -> Binario                                            |");
            Console.WriteLine("|2.  Binário -> Decimal                                            |");
            Console.WriteLine("|3.  Decimal -> Octal                                              |");
            Console.WriteLine("|4.  Octal -> Decimal                                              |");
            Console.WriteLine("|5.  Decimal -> Hexadecimal                                        |");
            Console.WriteLine("|6.  Hexadecimal -> Decimal                                        |");
            Console.WriteLine("|7.  Binario -> Octal                                              |");
            Console.WriteLine("|8.  Octal -> Binario                                              |");
            Console.WriteLine("|9.  Binario -> Hexadecimal                                        |");
            Console.WriteLine("|10. Hexadecimal -> Binario                                        |");
            Console.WriteLine("|11. Octal -> Hexadecimal                                          |");
            Console.WriteLine("|12. Hexadecimal -> Octal                                          |");
            Console.WriteLine("|0. Sair                                                           |");
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine("|Qual sua Opção?:                                                  |");
            Console.WriteLine("|------------------------------------------------------------------|");

            Console.SetCursorPosition(17, 19);

            opcao = (Console.ReadLine());

            while (opcao == "")
            {
                Console.WriteLine("|------------------------------------------------------------------|");
                Console.WriteLine("|Digite um Valor!                                                  |");
                Console.WriteLine("|------------------------------------------------------------------|");
                Console.WriteLine("|Qual sua Opção?:                                                  |");
                Console.WriteLine("|------------------------------------------------------------------|");
                opcao = Console.ReadLine();
            }
            


                //back

                //      Variáveis para escrever o Título da Operação
                //      Essas Variáveis e Array  usam o Procedimento "titulo", para definir o titulo 
                //      de qual tipo de operação está sendo feita.

                string ParaConverter, SeraConvertido;
                string[] tipos = { "Decimal", "Binário", "Octal", "Hexadecimal" };


                switch (opcao)
                {
                    case "0":
                        Console.Clear();
                        Console.WriteLine("Encerrando o Programa...");
                        break;

                    case "1":
                        ParaConverter = tipos[0];
                        SeraConvertido = tipos[1];
                        titulo(ParaConverter, SeraConvertido);
                        DecimaltoBinario();
                        break;

                    case "2":
                        ParaConverter = tipos[1];
                        SeraConvertido = tipos[0];
                        titulo(ParaConverter, SeraConvertido);
                        BinarioToDecimal();
                        break;

                    case "3":
                        ParaConverter = tipos[0]; ;
                        SeraConvertido = tipos[2];
                        titulo(ParaConverter, SeraConvertido);
                        DecimaltoOctal();

                        break;

                    case "4":
                        ParaConverter = tipos[2];
                        SeraConvertido = tipos[0];
                        titulo(ParaConverter, SeraConvertido);
                        OctaltoDecimal();

                        break;

                    case "5":
                        ParaConverter = tipos[0];
                        SeraConvertido = tipos[3];
                        titulo(ParaConverter, SeraConvertido);
                        DecimaltoHexa();

                        break;

                    case "6":
                        ParaConverter = tipos[3];
                        SeraConvertido = tipos[0];
                        titulo(ParaConverter, SeraConvertido);
                        HexadecimalParaDecimal();

                        break;

                    case "7":
                        ParaConverter = tipos[1];
                        SeraConvertido = tipos[2];
                        titulo(ParaConverter, SeraConvertido);
                        BinarioToOctal();

                        break;

                    case "8":
                        ParaConverter = tipos[2];
                        SeraConvertido = tipos[1];
                        titulo(ParaConverter, SeraConvertido);
                        OctalToBinario();
                        break;

                    case "9":
                        ParaConverter = tipos[1];
                        SeraConvertido = tipos[3];
                        titulo(ParaConverter, SeraConvertido);
                        BinarioToHexa();

                        break;

                    case "10":
                        ParaConverter = tipos[3];
                        SeraConvertido = tipos[1];
                        titulo(ParaConverter, SeraConvertido);
                        HexaToBinario();
                        break;

                    case "11":
                        ParaConverter = tipos[2];
                        SeraConvertido = tipos[3];
                        titulo(ParaConverter, SeraConvertido);
                        OctalToHexa();


                        break;

                    case "12":
                        ParaConverter = tipos[3];
                        SeraConvertido = tipos[2];
                        titulo(ParaConverter, SeraConvertido);
                        HexaToOctal();

                        break;
                }
            

        }
        static void ReturnMainMenu()
        {
            //Procedimento para Retornar ao Menu Principal
            Console.WriteLine("Clique em Qualquer Tecla para Retornar ao Menu Principal...");
            Console.ReadKey();

            Console.Clear();
            Cabecalhopadrao();
            Menu();
        }
        static void calculaEspaço(int x)
        {
            // Esse Procedimento Calcula a Quantidade de espaços Necessários para Fechar o Quadro
            for (int espaçolinha = 66; x <= espaçolinha; x++)
            {
                Console.Write(" ");
            }

        }
        static bool EhBinario(string entrada)
        {
            // Método para verificar se a string é um número binário
            foreach (char caractere in entrada)
            {
                if (caractere != '0' && caractere != '1')
                {
                    return false;
                }
            }
            return true;
        }
        static bool ValidaDecimalEHexa(string hexa)
        {
            // Verifica se os caracteres da string é um dígito hexadecimal valido
            foreach (char c in hexa)
            {
                bool Validarcaracter = (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f') || (c >= '0' && c <= '9');
                if (!Validarcaracter)
                    return false;
            }
            return true;
        }
        static int PassosHexatoDecimal(string hexa)
        {
            int NumeroDecimal = 0;
            int ValordaBase = 1;
            int passos = 1;

            Console.WriteLine("|------------------------------------------------------------------|");
            for (int i = hexa.Length - 1; i >= 0; i--)
            {
                char Digitohexa = hexa[i];
                int ValorDecimal;

                // for que converte hexa em decimal
                if (Digitohexa >= '0' && Digitohexa <= '9')
                {
                    ValorDecimal = Digitohexa - '0';
                }
                else
                {
                    ValorDecimal = Digitohexa - 'A' + 10;
                }


                NumeroDecimal += ValorDecimal * ValordaBase;




                string respostaParcial = $"| Passo {passos}: {ValorDecimal} * {ValordaBase} = {ValorDecimal * ValordaBase} (Soma parcial: {NumeroDecimal}) ";
                Console.Write(respostaParcial);
                calculaEspaço(respostaParcial.Length);
                Console.Write("|\n");

                // faz o número elevado ao indice
                ValordaBase *= 16;
                passos++;
            }
            Console.WriteLine("|------------------------------------------------------------------|");

            return NumeroDecimal;
        }
        static void MostrarPassosDaConversao(string entradaBinaria)
        {
            int potencia = 0;

            Console.WriteLine("\n|Passos da conversão:                                              |");


            // Percorrer a string de trás para frente
            for (int i = entradaBinaria.Length - 1; i >= 0; i--)
            {
                int valorDoBit = entradaBinaria[i] - '0'; // Convertendo char '0' ou '1' para int 0 ou 1
                int contribuicao = valorDoBit * (int)Math.Pow(2, potencia);

                string EscritaDaExplicacao = ($"|Posição {i}: bit {valorDoBit} contribui com {valorDoBit} * 2^{potencia} = {contribuicao}");
                int TamanhoEscritaExplicacao = EscritaDaExplicacao.Length;

                //          escreve a Resposta,Calcula os Espaços e Fecha o Quadro
                Console.Write(EscritaDaExplicacao);
                calculaEspaço(TamanhoEscritaExplicacao);
                Console.Write("|\n");


                potencia++;
            }
        }
        static int ConverterBinarioParaDecimal(string entradaBinaria)
        {
            // Método para converter binário para decimal
            int valorDecimal = 0;
            int potencia = 0;

            // Percorrer a string de trás para frente
            for (int i = entradaBinaria.Length - 1; i >= 0; i--)
            {
                if (entradaBinaria[i] == '1')
                {
                    valorDecimal += (int)Math.Pow(2, potencia);
                }
                potencia++;
            }

            return valorDecimal;
        }

        //Procedimentos Para Realizar os Cálculos
        static void DecimaltoBinario()
        {
            //Procedimento para Realizar Decimal Para Binário


            Console.WriteLine("|Escreva um Número Para Ser Convertido:                            |");
            Console.WriteLine("|------------------------------------------------------------------|");

            //Coloca a Posição do Cursor dentro do Quadro
            Console.SetCursorPosition(39, 5);

            //Recebe o Numero que Será Convertido pelo usuário
            int ValorUsuario = Convert.ToInt32(Console.ReadLine());

            //Essa Variável Recebe todos os Valores do Resto Obtido das Operações
            string Resto = "";

            //Faz as Operações:
            while (ValorUsuario > 0)
            {
                int restodentro = ValorUsuario % 2;
                Resto += restodentro;



                string escrita = ($"|{ValorUsuario} / 2 = {(ValorUsuario / 2)} e o Resto da Divisão foi:{restodentro}");



                //Escreve a Resposta,Calcula os Espaços e Fecha o Quadro
                Console.Write(escrita);
                calculaEspaço(escrita.Length);
                Console.Write("|\n");

                //Divide o Valor do Usuário por 2 
                ValorUsuario = ValorUsuario / 2;
            }

            //Resposta Final:


            Console.WriteLine("|------------------------------------------------------------------|");

            // Inverte os Valores dos Restos
            string ResultadoInvertido = new string(Resto.Reverse().ToArray());

            // Variável para Calculo de Espaços
            string ResultadoEscrita = ($"|O Resultado em Binário é :{ResultadoInvertido}");


            //Escreve a Resposta,Calcula os Espaços e Fecha o Quadro
            Console.Write(ResultadoEscrita);
            calculaEspaço(ResultadoEscrita.Length);
            Console.Write("|\n");
            Console.WriteLine("|------------------------------------------------------------------|");

            ReturnMainMenu();

        }
        static void BinarioToDecimal()
        {
            //Procedimento para Realizar Binario para Decimal


            Console.WriteLine("|Escreva um Número Binário Para Ser Convertido:                    |");
            Console.WriteLine("|------------------------------------------------------------------|");

            //Coloca a Posição do Cursor dentro da caixa
            Console.SetCursorPosition(47, 5);



            // recebe o binário do Usuário
            string entradaBinaria = Console.ReadLine();

            // Validar se a entrada é um número binário
            if (!EhBinario(entradaBinaria))
            {
                Console.WriteLine("\nEntrada inválida. Por favor, digite apenas 0 ou 1.");
                ReturnMainMenu();
                return;
            }

            // Converter binário para decimal
            int valorDecimal = ConverterBinarioParaDecimal(entradaBinaria);

            // Mostrar os passos detalhados
            MostrarPassosDaConversao(entradaBinaria);

            // Mostrar o resultado final
            Console.WriteLine("|------------------------------------------------------------------|");

            string EscritaResultadoFinal = ($"|O valor decimal de {entradaBinaria} é: {valorDecimal}");
            int TamanhoEscritaResultadoFinal = EscritaResultadoFinal.Length;

            //          escreve a Resposta,Calcula os Espaços e Fecha o Quadro
            Console.Write(EscritaResultadoFinal);
            calculaEspaço(TamanhoEscritaResultadoFinal);
            Console.Write("|\n");
            Console.WriteLine("|------------------------------------------------------------------|");




            ReturnMainMenu();
        }
        static void DecimaltoOctal()
        {
            //          Procedimento para Realizar Decimal Para Octal


            Console.WriteLine("|Escreva um Número Para Ser Convertido:                            |");
            Console.WriteLine("|------------------------------------------------------------------|");

            //          Coloca a Posição do Cursor dentro da caixa
            Console.SetCursorPosition(39, 5);

            //          Recebe o Numero que Será Convertido pelo usuário
            int ValorUsuario = Convert.ToInt32(Console.ReadLine());

            //          Essa Variável Recebe todos os Valores do Resto Obtido das Operações
            string Resto = "";

            //          Faz as Operações:
            while (ValorUsuario > 0)
            {
                int restodentro = ValorUsuario % 8;
                Resto += restodentro;



                string escrita = ($"|{ValorUsuario} / 8 = {(ValorUsuario / 8)} e o Resto da Divisão foi:{restodentro}");

                //          escreve a Resposta,Calcula os Espaços e Fecha o Quadro
                Console.Write(escrita);
                calculaEspaço(escrita.Length);
                Console.Write("|\n");
                //          Divide o Valor do Usuário por 8 
                ValorUsuario = ValorUsuario / 8;
            }

            //          Resposta Final:


            Console.WriteLine("|------------------------------------------------------------------|");

            // Inverte os Valores dos Restos
            string ResultadoInvertido = new string(Resto.Reverse().ToArray());

            // Variável para Calculo de Espaços
            string ResultadoEscrita = ($"|O Resultado em Octal é :{ResultadoInvertido}");
            int tamanhoresultado = (ResultadoEscrita.Length);

            //          escreve a Resposta,Calcula os Espaços e Fecha o Quadro
            Console.Write(ResultadoEscrita);
            calculaEspaço(tamanhoresultado);
            Console.Write("|\n");
            Console.WriteLine("|------------------------------------------------------------------|");

            ReturnMainMenu();

        }
        static void OctaltoDecimal()
        {
            //          Procedimento para Realizar Octal para Decimal


            Console.WriteLine("|Escreva um Número Octal Para Ser Convertido:                      |");
            Console.WriteLine("|------------------------------------------------------------------|");

            //          Coloca a Posição do Cursor dentro da caixa
            Console.SetCursorPosition(45, 5);

            string valorRecebido = Console.ReadLine();
            int valorDecimal = 0;
            int potencia = valorRecebido.Length - 1;

            Console.WriteLine("\n|Passos da conversão:                                              |");

            for (int i = 0; i < valorRecebido.Length; i++)
            {
                int valorDoBit = valorRecebido[i] - '0'; // Convertendo char para int
                int contribuicao = valorDoBit * (int)Math.Pow(8, potencia - i);

                string escritaDaExplicacao = $"|Posição {i}: bit {valorDoBit} contribui com {valorDoBit} * 8^{potencia - i} = {contribuicao}";
                int tamanhoEscritaExplicacao = escritaDaExplicacao.Length;

                // Escreve a resposta, calcula os espaços e fecha o quadro
                Console.Write(escritaDaExplicacao);
                calculaEspaço(tamanhoEscritaExplicacao);
                Console.Write("|\n");

                valorDecimal += contribuicao;
            }
            Console.WriteLine("|------------------------------------------------------------------|");
            string ValorResultado = ($"|O valor decimal de {valorRecebido} é: {valorDecimal}");
            int TamanhoResultado = ValorResultado.Length;
            // Escreve a resposta, calcula os espaços e fecha o quadro
            Console.Write(ValorResultado);
            calculaEspaço(TamanhoResultado);
            Console.Write("|\n");
            Console.WriteLine("|------------------------------------------------------------------|");
            ReturnMainMenu();
        }
        static void DecimaltoHexa()
        {
            //          Procedimento para Realizar Decimal Para HexaDecimal


            Console.WriteLine("|Escreva um Número Para Ser Convertido:                            |");
            Console.WriteLine("|------------------------------------------------------------------|");

            //          Coloca a Posição do Cursor dentro da caixa
            Console.SetCursorPosition(39, 5);

            //          Recebe o Numero que Será Convertido pelo usuário
            int ValorUsuario = Convert.ToInt32(Console.ReadLine());

            //          Essa Variável Recebe todos os Valores do Resto Obtido das Operações
            string Resto = "";

            //          Faz as Operações:
            while (ValorUsuario > 0)
            {
                int restodentro = ValorUsuario % 16;

                // Verificação se é Letra Hexadecimal
                if (restodentro > 9 && restodentro < 16)
                {
                    switch (restodentro)
                    {
                        case 10:
                            Resto += "A";
                            break;

                        case 11:
                            Resto += "B";
                            break;

                        case 12:
                            Resto += "C";
                            break;

                        case 13:
                            Resto += "D";
                            break;

                        case 14:
                            Resto += "E";
                            break;

                        case 15:
                            Resto += "F";
                            break;
                    }
                }
                else

                {
                    Resto += restodentro;
                }

                string escrita = ($"|{ValorUsuario} / 16 = {(ValorUsuario / 16)} e o Resto da Divisão foi:{restodentro}");



                //          escreve a Resposta,Calcula os Espaços e Fecha o Quadro
                Console.Write(escrita);
                calculaEspaço(escrita.Length);
                Console.Write("|\n");
                //          Divide o Valor do Usuário por 16 
                ValorUsuario = ValorUsuario / 16;
            }

            //          Resposta Final:


            Console.WriteLine("|------------------------------------------------------------------|");

            // Inverte os Valores dos Restos
            string ResultadoInvertido = new string(Resto.Reverse().ToArray());

            // Variável para Calculo de Espaços
            string ResultadoEscrita = ($"|O Resultado em HexaDecimal é :{ResultadoInvertido}");


            //          escreve a Resposta,Calcula os Espaços e Fecha o Quadro
            Console.Write(ResultadoEscrita);
            calculaEspaço(ResultadoEscrita.Length);
            Console.Write("|\n");
            Console.WriteLine("|------------------------------------------------------------------|");

            ReturnMainMenu();
        }
        static void HexadecimalParaDecimal()
        {
            // Procedimento para Realizar Hexadecimal para Decimal


            Console.WriteLine("|Escreva um Número Hexadecimal Para Ser Convertido:                |");
            Console.WriteLine("|------------------------------------------------------------------|");

            //          Coloca a Posição do Cursor dentro da caixa
            Console.SetCursorPosition(52, 5);

            string EntradaHexadecimal = Console.ReadLine();

            // Para validar se o número digitado pelo usuário é um decimal
            if (!ValidaDecimalEHexa(EntradaHexadecimal))
            {
                Console.WriteLine("\n| Entrada inválida. Por favor, insira um número hexadecimal        |\n| válido (0–9 e A–F ou a– f ).                                     |");
                Console.WriteLine("|------------------------------------------------------------------|");
                ReturnMainMenu();
            }

            // Converte hexa em decimal
            int numDecimal = PassosHexatoDecimal(EntradaHexadecimal.ToUpper());



            //          escreve a Resposta,Calcula os Espaços e Fecha o Quadro
            Console.WriteLine("|------------------------------------------------------------------|");
            string RespostaFinal = ($"|Resultado Decimal: {numDecimal}");
            Console.Write(RespostaFinal);
            calculaEspaço(RespostaFinal.Length);
            Console.Write("|\n");
            Console.WriteLine("|------------------------------------------------------------------|");
            ReturnMainMenu();

        }
        static void BinarioToOctal()
        {
            //          Procedimento para Realizar Binario para Octal


            Console.WriteLine("|Escreva um Número Binário Para Ser Convertido:                    |");
            Console.WriteLine("|------------------------------------------------------------------|");

            //          Coloca a Posição do Cursor dentro da caixa
            Console.SetCursorPosition(47, 5);



            // recebe o binário do Usuário
            string entradaBinaria = Console.ReadLine();






            // Validar se a entrada é um número binário
            if (!EhBinario(entradaBinaria))

            {
                Console.WriteLine("\nEntrada inválida. Por favor, digite apenas 0 ou 1.");
                ReturnMainMenu();
                return;
            }


            // Adiciona zeros à esquerda, se necessário, para completar o último grupo de três dígitos
            while (entradaBinaria.Length % 3 != 0)
            {
                entradaBinaria = "0" + entradaBinaria;
            }

            Console.WriteLine("|------------------------------------------------------------------|");

            // Converte cada grupo de três dígitos em octal e junta os resultados
            string resultadoOctal = "";
            for (int i = 0; i < entradaBinaria.Length; i += 3)
            {
                string grupo = entradaBinaria.Substring(i, 3);
                int decimalDoGrupo = Convert.ToInt32(grupo, 2); // Converte o grupo binário em decimal
                string octalDoGrupo = Convert.ToString(decimalDoGrupo, 8); // Converte o decimal em octal

                string RespostaParcial = ($"|Grupo binário: {grupo} --> Octal: {octalDoGrupo}");
                int TamanhoRespostaPacial = RespostaParcial.Length;


                //          escreve a Resposta,Calcula os Espaços e Fecha o Quadro
                Console.Write(RespostaParcial);
                calculaEspaço(TamanhoRespostaPacial);
                Console.Write("|\n");


                resultadoOctal += octalDoGrupo;
            }

            //          escreve a Resposta,Calcula os Espaços e Fecha o Quadro
            Console.WriteLine("|------------------------------------------------------------------|");
            string respostafinal = ($"|O número binário {entradaBinaria} em octal é: {resultadoOctal}");
            int Tamanhorespostafinal = respostafinal.Length;
            Console.Write(respostafinal);
            calculaEspaço(Tamanhorespostafinal);
            Console.Write("|\n");
            Console.WriteLine("|------------------------------------------------------------------|");

            ReturnMainMenu();
        }
        static void OctalToBinario()
        {
            //          Procedimento para Realizar Octal para Decimal


            Console.WriteLine("|Escreva um Número Octal Para Ser Convertido:                      |");
            Console.WriteLine("|------------------------------------------------------------------|");

            //          Coloca a Posição do Cursor dentro da caixa
            Console.SetCursorPosition(45, 5);

            string valorRecebido = Console.ReadLine();

            Console.WriteLine("|------------------------------------------------------------------|");
            string resultadoBinario = "";
            foreach (char digito in valorRecebido)
            {
                int decimalDoDigito = Convert.ToInt32(digito.ToString(), 8);

                string binarioDoDigito = Convert.ToString(decimalDoDigito, 2).PadLeft(3, '0');
                resultadoBinario += binarioDoDigito;

                string ResultadoParcial = ($"|Convertendo {decimalDoDigito.ToString().PadLeft(3, '0')} para binário: {binarioDoDigito}");


                // escreve a Resposta, Calcula os Espaços e Fecha o Quadro
                Console.Write(ResultadoParcial);
                calculaEspaço(ResultadoParcial.Length);
                Console.Write("|\n");

            }
            Console.WriteLine("|------------------------------------------------------------------|");
            string RespostaFinal = ($"|Resultado Binário: {resultadoBinario}");
            int Tamanhoresposta = RespostaFinal.Length;
            Console.Write(RespostaFinal);
            calculaEspaço(Tamanhoresposta);
            Console.Write("|\n");
            Console.WriteLine("|------------------------------------------------------------------|");

            ReturnMainMenu();
        }
        static void BinarioToHexa()
        {

            Console.WriteLine("|Escreva um Número Binário Para Ser Convertido:                    |");
            Console.WriteLine("|------------------------------------------------------------------|");

            Console.SetCursorPosition(47, 5);
            string entradaBinaria = Console.ReadLine();


            if (!EhBinario(entradaBinaria))
            {
                Console.WriteLine("\nEntrada inválida. Por favor, digite apenas 0 ou 1.");
                return;
            }

            while (entradaBinaria.Length % 4 != 0)
            {
                entradaBinaria = "0" + entradaBinaria;
            }

            Console.WriteLine("|------------------------------------------------------------------|");

            string resto = "";
            for (int i = 0; i < entradaBinaria.Length; i += 4)
            {
                string grupo = entradaBinaria.Substring(i, 4);
                int decimalDoGrupo = Convert.ToInt32(grupo, 2);
                string hexadecimalDoGrupo = decimalDoGrupo.ToString("X");

                string respostaParcial = $"|Grupo binário: {grupo} --> Hexadecimal: {hexadecimalDoGrupo}";
                Console.Write(respostaParcial);
                calculaEspaço(respostaParcial.Length);
                Console.Write("|\n");

                resto += hexadecimalDoGrupo;
            }

            Console.WriteLine("|------------------------------------------------------------------|");
            string respostaFinal = $"|O número binário {entradaBinaria} em Hexadecimal é: {resto}";
            Console.Write(respostaFinal);
            calculaEspaço(respostaFinal.Length);
            Console.Write("|\n");
            Console.WriteLine("|------------------------------------------------------------------|");
            ReturnMainMenu();


        }
        static void HexaToBinario()
        {
            //          Procedimento para Realizar HexaDecimal Para Binário


            Console.WriteLine("|Escreva um Número Hexadecimal Para Ser Convertido:                |");
            Console.WriteLine("|------------------------------------------------------------------|");

            //          Coloca a Posição do Cursor dentro da caixa
            Console.SetCursorPosition(52, 5);

            string valorRecebido = Console.ReadLine();

            Console.WriteLine("|------------------------------------------------------------------|");
            string resultadoBinario = "";

            foreach (char digito in valorRecebido)
            {
                int decimalDoDigito = Convert.ToInt32(digito.ToString(), 16);

                string binarioDoDigito = Convert.ToString(decimalDoDigito, 2).PadLeft(4, '0');
                resultadoBinario += binarioDoDigito;

                string ResultadoParcial = ($"|Convertendo {decimalDoDigito.ToString().PadLeft(4, '0')} para binário: {binarioDoDigito}");
                int tamanhoresultado = ResultadoParcial.Length;

                // escreve a Resposta, Calcula os Espaços e Fecha o Quadro
                Console.Write(ResultadoParcial);
                calculaEspaço(tamanhoresultado);
                Console.Write("|\n");

            }
            Console.WriteLine("|------------------------------------------------------------------|");
            string RespostaFinal = ($"|Resultado Binário: {resultadoBinario}");
            int Tamanhoresposta = RespostaFinal.Length;
            Console.Write(RespostaFinal);
            calculaEspaço(Tamanhoresposta);
            Console.Write("|\n");
            Console.WriteLine("|__________________________________________________________________|");

            ReturnMainMenu();
        }
        static void OctalToHexa()
        {
            //          Procedimento para Realizar Octal para Decimal


            Console.WriteLine("|Escreva um Número Octal Para Ser Convertido:                      |");
            Console.WriteLine("|------------------------------------------------------------------|");

            //          Coloca a Posição do Cursor dentro da caixa
            Console.SetCursorPosition(45, 5);

            string valorRecebido = Console.ReadLine();

            if (valorRecebido.Contains("8")||valorRecebido.Contains("9")){
                Console.WriteLine("|------------------------------------------------------------------|");
                Console.WriteLine("|Valor não Corresponde a um numero Octal!                          |");
                Console.WriteLine("|__________________________________________________________________|");
                ReturnMainMenu();
            }
            else { 

                Console.WriteLine("|------------------------------------------------------------------|");
                string resultadoBinario = "";
                foreach (char digito in valorRecebido)
                {
                    int decimalDoDigito = Convert.ToInt32(digito.ToString(), 8);

                    string binarioDoDigito = Convert.ToString(decimalDoDigito, 2).PadLeft(3, '0');
                    resultadoBinario += binarioDoDigito;

                    string ResultadoParcial = ($"|Convertendo {decimalDoDigito.ToString().PadLeft(3, '0')} para binário: {binarioDoDigito}");


                    // escreve a Resposta, Calcula os Espaços e Fecha o Quadro
                    Console.Write(ResultadoParcial);
                    calculaEspaço(ResultadoParcial.Length);
                    Console.Write("|\n");

                }
                Console.WriteLine("|------------------------------------------------------------------|");
                string RespostaFinal = ($"|Resultado Binário: {resultadoBinario}");
                int Tamanhoresposta = RespostaFinal.Length;
                Console.Write(RespostaFinal);
                calculaEspaço(Tamanhoresposta);
                Console.Write("|\n");
            

            
                string entradaBinaria = resultadoBinario;


                if (!EhBinario(entradaBinaria))
                {
                    Console.WriteLine("\nEntrada inválida. Por favor, digite apenas 0 ou 1.");
                    return;
                }

                while (entradaBinaria.Length % 4 != 0)
                {
                    entradaBinaria = "0" + entradaBinaria;
                }

                Console.WriteLine("|------------------------------------------------------------------|");

                string resto = "";
                for (int i = 0; i < entradaBinaria.Length; i += 4)
                {
                    string grupo = entradaBinaria.Substring(i, 4);
                    int decimalDoGrupo = Convert.ToInt32(grupo, 2);
                    string hexadecimalDoGrupo = decimalDoGrupo.ToString("X");

                    string respostaParcial = $"|Grupo binário: {grupo} --> Hexadecimal: {hexadecimalDoGrupo}";
                    Console.Write(respostaParcial);
                    calculaEspaço(respostaParcial.Length);
                    Console.Write("|\n");

                    resto += hexadecimalDoGrupo;
                }

                Console.WriteLine("|------------------------------------------------------------------|");
                string respostaFinal = $"|O número binário {entradaBinaria} em Hexadecimal é: {resto}";
                Console.Write(respostaFinal);
                calculaEspaço(respostaFinal.Length);
                Console.Write("|\n");
                Console.WriteLine("|------------------------------------------------------------------|");

                string respostaFinalFinal = $"|O número octal {valorRecebido} em Hexadecimal é: {resto}";
                Console.Write(respostaFinalFinal);
                calculaEspaço(respostaFinalFinal.Length);
                Console.Write("|\n");
                Console.WriteLine("|------------------------------------------------------------------|");
                ReturnMainMenu();



                ReturnMainMenu();
            }




        }
        static void HexaToOctal()
        {
            //          Procedimento para Realizar HexaDecimal Para Binário


            Console.WriteLine("|Escreva um Número Hexadecimal Para Ser Convertido:                |");
            Console.WriteLine("|------------------------------------------------------------------|");

            //          Coloca a Posição do Cursor dentro da caixa
            Console.SetCursorPosition(52, 5);

            string valorRecebido = Console.ReadLine();

            Console.WriteLine("|------------------------------------------------------------------|");
            string resultadoBinario = "";

            foreach (char digito in valorRecebido)
            {
                int decimalDoDigito = Convert.ToInt32(digito.ToString(), 16);

                string binarioDoDigito = Convert.ToString(decimalDoDigito, 2).PadLeft(4, '0');
                resultadoBinario += binarioDoDigito;

                string ResultadoParcial = ($"|Convertendo {decimalDoDigito.ToString().PadLeft(4, '0')} para binário: {binarioDoDigito}");
                int tamanhoresultado = ResultadoParcial.Length;

                // escreve a Resposta, Calcula os Espaços e Fecha o Quadro
                Console.Write(ResultadoParcial);
                calculaEspaço(tamanhoresultado);
                Console.Write("|\n");

            }
            Console.WriteLine("|------------------------------------------------------------------|");
            string RespostaFinal = ($"|Resultado Binário: {resultadoBinario}");
            int Tamanhoresposta = RespostaFinal.Length;
            Console.Write(RespostaFinal);
            calculaEspaço(Tamanhoresposta);
            Console.Write("|\n");


            // recebe o binário do Usuário
            string entradaBinaria = resultadoBinario;






            // Validar se a entrada é um número binário
            if (!EhBinario(entradaBinaria))

            {
                Console.WriteLine("\nEntrada inválida. Por favor, digite apenas 0 ou 1.");
                ReturnMainMenu();
                return;
            }


            // Adiciona zeros à esquerda, se necessário, para completar o último grupo de três dígitos
            while (entradaBinaria.Length % 3 != 0)
            {
                entradaBinaria = "0" + entradaBinaria;
            }

            Console.WriteLine("|------------------------------------------------------------------|");

            // Converte cada grupo de três dígitos em octal e junta os resultados
            string resultadoOctal = "";
            for (int i = 0; i < entradaBinaria.Length; i += 3)
            {
                string grupo = entradaBinaria.Substring(i, 3);
                int decimalDoGrupo = Convert.ToInt32(grupo, 2); // Converte o grupo binário em decimal
                string octalDoGrupo = Convert.ToString(decimalDoGrupo, 8); // Converte o decimal em octal

                string RespostaParcial = ($"|Grupo binário: {grupo} --> Octal: {octalDoGrupo}");
                int TamanhoRespostaPacial = RespostaParcial.Length;


                //          escreve a Resposta,Calcula os Espaços e Fecha o Quadro
                Console.Write(RespostaParcial);
                calculaEspaço(TamanhoRespostaPacial);
                Console.Write("|\n");


                resultadoOctal += octalDoGrupo;
            }

            //          escreve a Resposta,Calcula os Espaços e Fecha o Quadro
            Console.WriteLine("|------------------------------------------------------------------|");
            string respostafinal = ($"|O número binário {entradaBinaria} em octal é: {resultadoOctal}");
            int Tamanhorespostafinal = respostafinal.Length;
            Console.Write(respostafinal);
            calculaEspaço(Tamanhorespostafinal);
            Console.Write("|\n");
            Console.WriteLine("|------------------------------------------------------------------|");

            string respostafinalfinal = ($"|O número hexadecimal {valorRecebido} em octal é: {resultadoOctal}");
            int Tamanhorespostafinalfinal = respostafinalfinal.Length;
            Console.Write(respostafinalfinal);
            calculaEspaço(Tamanhorespostafinalfinal);
            Console.Write("|\n");
            Console.WriteLine("|------------------------------------------------------------------|");

            ReturnMainMenu();


           












        }

       


    }
}



