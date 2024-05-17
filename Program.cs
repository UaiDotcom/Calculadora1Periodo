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

        static void Menu()
        {
            //Menu de Seleção de Qual Operação Será Feita
           

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
            int opcao = Convert.ToInt32(Console.ReadLine());


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

                    break;

                case 3:
                    ParaConverter = tipos[0]; ;
                    SeraConvertido = tipos[2];
                    titulo(ParaConverter, SeraConvertido);

                    break;

                case 4:
                    ParaConverter = tipos[2]; 
                    SeraConvertido = tipos[0];
                    titulo(ParaConverter, SeraConvertido);

                    break;

                case 5:
                    ParaConverter = tipos[0];
                    SeraConvertido = tipos[3];
                    titulo(ParaConverter, SeraConvertido);

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

        static void titulo(string x, string y)
        {
            //          Esse Procedimento mostra o título referente a qual operação está sera feita
            Console.Clear();
            Cabcalhopadrao();
            Console.WriteLine($"|A Conversão de Bases Será de {x} para {y}                 |");
            Console.WriteLine("|------------------------------------------------------------------|");
        }

        static void DecimaltoBinario()
        {
            //          Procedimento para Realizar Decimal Para Binário

            
            Console.WriteLine("|Escreva um Número Para Ser Convertido:                            |");
            Console.WriteLine("|------------------------------------------------------------------|");

            //          Coloca a Posição do Cursor dentro da caixa
            Console.SetCursorPosition(39,5);

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

            //Retorna ao Menu Principal
            Console.WriteLine("Clique em Qualquer Tecla para Retornar ao Menu Principal...");
            Console.ReadKey();

            Console.Clear();
            Cabecalhopadrao();
            Menu();
        }
        static void calculaEspaço(int x ) {

           for (int espaçolinha = 66; x<=66; x++)
            {
                Console.Write(" ");
            }
          
        }



    }
}
