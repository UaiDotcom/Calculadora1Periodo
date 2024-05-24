using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            int opcao = 0;

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

            opcao = Convert.ToInt32(Console.ReadLine());


            //back

            //      Variáveis para escrever o Título da Operação
            //      Essas Variáveis e Array  usam o Procedimento "titulo", para definir o titulo 
            //      de qual tipo de operação está sendo feita.

            string ParaConverter, SeraConvertido;
            string[] tipos = { "Decimal", "Binário", "Octal", "Hexadecimal" };


            switch (opcao)
            {
                case 0:

                    break;

                case 1:
                    ParaConverter = tipos[0];
                    SeraConvertido = tipos[1];
                    titulo(ParaConverter, SeraConvertido);
                    DecimaltoBinario();
                    break;

                case 2:
                    ParaConverter = tipos[1];
                    SeraConvertido = tipos[0];
                    titulo(ParaConverter, SeraConvertido);
                    BinarioToDecimal();
                    break;

                case 3:
                    ParaConverter = tipos[0]; ;
                    SeraConvertido = tipos[2];
                    titulo(ParaConverter, SeraConvertido);
                    DecimaltoOctal();

                    break;

                case 4:
                    ParaConverter = tipos[2];
                    SeraConvertido = tipos[0];
                    titulo(ParaConverter, SeraConvertido);
                    OctaltoDecimal();

                    break;

                case 5:
                    ParaConverter = tipos[0];
                    SeraConvertido = tipos[3];
                    titulo(ParaConverter, SeraConvertido);
                    DecimaltoHexa();

                    break;

                case 6:
                    ParaConverter = tipos[3];
                    SeraConvertido = tipos[0];
                    titulo(ParaConverter, SeraConvertido);

                    break;

                case 7:
                    ParaConverter = tipos[1];
                    SeraConvertido = tipos[2];
                    titulo(ParaConverter, SeraConvertido);
                    BinarioToOctal();

                    break;

                case 8:
                    ParaConverter = tipos[2];
                    SeraConvertido = tipos[1];
                    titulo(ParaConverter, SeraConvertido);

                    break;

                case 9:
                    ParaConverter = tipos[1];
                    SeraConvertido = tipos[3];
                    titulo(ParaConverter, SeraConvertido);

                    break;

                case 10:
                    ParaConverter = tipos[3];
                    SeraConvertido = tipos[1];
                    titulo(ParaConverter, SeraConvertido);

                    break;

                case 11:
                    ParaConverter = tipos[2];
                    SeraConvertido = tipos[3];
                    titulo(ParaConverter, SeraConvertido);

                    break;

                case 12:
                    ParaConverter = tipos[3];
                    SeraConvertido = tipos[2];
                    titulo(ParaConverter, SeraConvertido);

                    break;
            }


        }
        static void ReturnMainMenu()
        {
            //Retorna ao Menu Principal
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
        static void DecimaltoBinario()
        {
            //          Procedimento para Realizar Decimal Para Binário


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
                int restodentro = ValorUsuario % 2;
                Resto += restodentro;


                //          A Solução que encontrei foi salvar a Resposta como uma Variável para que o Possa Contar
                //          a quantidade  de Caracteres
                string escrita = ($"|{ValorUsuario} / 2 = {(ValorUsuario / 2)} e o Resto da Divisão foi:{restodentro}");

                //          Essa Variável Calcula o Tamanho da String para colocar os espaços e Fechar o Quadro
                //          Junto com a Função calculaEspaço.
                int tamanhoescrita = (escrita.Length);

                //          escreve a Resposta,Calcula os Espaços e Fecha o Quadro
                Console.Write(escrita);
                calculaEspaço(tamanhoescrita);
                Console.Write("|\n");
                //          Divide o Valor do Usuário por 2 
                ValorUsuario = ValorUsuario / 2;
            }

            //          Resposta Final:


            Console.WriteLine("|------------------------------------------------------------------|");

            // Inverte os Valores dos Restos
            string ResultadoInvertido = new string(Resto.Reverse().ToArray());

            // Variável para Calculo de Espaços
            string ResultadoEscrita = ($"|O Resultado em Binário é :{ResultadoInvertido}");
            int tamanhoresultado = (ResultadoEscrita.Length);

            //          escreve a Resposta,Calcula os Espaços e Fecha o Quadro
            Console.Write(ResultadoEscrita);
            calculaEspaço(tamanhoresultado);
            Console.Write("|\n");
            Console.WriteLine("|------------------------------------------------------------------|");

            ReturnMainMenu();

        }
        static void BinarioToDecimal()
        {
            //          Procedimento para Realizar Binario para Decimal


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


            // Método para verificar se a string é um número binário
            static bool EhBinario(string entrada)
            {
                foreach (char caractere in entrada)
                {
                    if (caractere != '0' && caractere != '1')
                    {
                        return false;
                    }
                }
                return true;
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

            // Método para mostrar os passos da conversão
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


                //          A Solução que encontrei foi salvar a Resposta como uma Variável para que o Possa Contar
                //          a quantidade  de Caracteres
                string escrita = ($"|{ValorUsuario} / 8 = {(ValorUsuario / 8)} e o Resto da Divisão foi:{restodentro}");

                //          Essa Variável Calcula o Tamanho da String para colocar os espaços e Fechar o Quadro
                //          Junto com a Função calculaEspaço.
                int tamanhoescrita = (escrita.Length);

                //          escreve a Resposta,Calcula os Espaços e Fecha o Quadro
                Console.Write(escrita);
                calculaEspaço(tamanhoescrita);
                Console.Write("|\n");
                //          Divide o Valor do Usuário por 2 
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
                if(restodentro > 9 && restodentro < 16)
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

                  


                //          A Solução que encontrei foi salvar a Resposta como uma Variável para que o Possa Contar
                //          a quantidade  de Caracteres
                string escrita = ($"|{ValorUsuario} / 16 = {(ValorUsuario / 16)} e o Resto da Divisão foi:{restodentro}");

                //          Essa Variável Calcula o Tamanho da String para colocar os espaços e Fechar o Quadro
                //          Junto com a Função calculaEspaço.
                int tamanhoescrita = (escrita.Length);

                //          escreve a Resposta,Calcula os Espaços e Fecha o Quadro
                Console.Write(escrita);
                calculaEspaço(tamanhoescrita);
                Console.Write("|\n");
                //          Divide o Valor do Usuário por 2 
                ValorUsuario = ValorUsuario / 16;
            }

            //          Resposta Final:


            Console.WriteLine("|------------------------------------------------------------------|");

            // Inverte os Valores dos Restos
            string ResultadoInvertido = new string(Resto.Reverse().ToArray());

            // Variável para Calculo de Espaços
            string ResultadoEscrita = ($"|O Resultado em HexaDecimal é :{ResultadoInvertido}");
            int tamanhoresultado = (ResultadoEscrita.Length);

            //          escreve a Resposta,Calcula os Espaços e Fecha o Quadro
            Console.Write(ResultadoEscrita);
            calculaEspaço(tamanhoresultado);
            Console.Write("|\n");
            Console.WriteLine("|------------------------------------------------------------------|");

            ReturnMainMenu();
        }

            //Hexadecimal para Decimal (Lucas)

        static void HexaTodecimal()
        {
            int NumUsuario = 0, posicao = 0, resultado = 0;
            

            Console.WriteLine("|Escreva um Número Para Ser Convertido:                            |");
            Console.WriteLine("|------------------------------------------------------------------|");
            NumUsuario = Convert.ToInt32(Console.ReadLine());


            int[] hexaTodecimal = new int[4];
            for(int i = 0; i > 0; i++)
            {
                resultado = (NumUsuario * i) ^ posicao;

            }
                Console.WriteLine(resultado);

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

            // Método para verificar se a string é um número binário
            static bool EhBinario(string entrada)
            {
                foreach (char caractere in entrada)
                {
                    if (caractere != '0' && caractere != '1')
                    {
                        return false;
                    }
                }
                return true;
            }

            // Validar se a entrada é um número binário
            if (!EhBinario(entradaBinaria))

            {
                Console.WriteLine("\nEntrada inválida. Por favor, digite apenas 0 ou 1.");
                ReturnMainMenu();
                return;
            }




            int tamanhoEntrada = entradaBinaria.Length;
            int contadordeCasas = tamanhoEntrada / 3;

            int casainicial = 0;
            int casaFinal = 3;



            string[] EntradaSeparada = new string[contadordeCasas];

            for(int i = 0; i < contadordeCasas; i++)
            {
               
                EntradaSeparada[i] = entradaBinaria.Substring(casainicial, casaFinal);
                casaFinal = casaFinal + 3;
                casainicial = casainicial + 3;
            }

           /* for(int i = 0; i<= contadordeCasas; i++)
            {
                Console.WriteLine(EntradaSeparada[i]);
            }
            */

           
        }

    }
}






