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
            int opcao = 0;
            Cabcalhopadrao();
            Menu(opcao);
        }

        static void Cabcalhopadrao()
        {
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine("|Calculadora Didática                                              |");
            Console.WriteLine("|------------------------------------------------------------------|");
        }
        static void Menu(int opcao)
        {
            string ParaConverter, SeraConvertido;

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

            string[] tipos = { "Decimal", "Binário", "Octal", "Hexadecimal" };


            switch (opcao)
            {
                case 0:

                    break;

                case 1:
                    ParaConverter = tipos[0];
                    SeraConvertido = tipos[1];
                    titulo(ParaConverter, SeraConvertido);
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
            Console.Clear();
            Cabcalhopadrao();
            Console.WriteLine($"|A Conversão de Bases Será de {x} para {y}                 |");


        }


    }
}
