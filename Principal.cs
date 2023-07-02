using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOAT32_2
{
    internal class Principal
    {

        public static void Main(string[] args)
        {

            int escolha;




            do
            {

                Console.WriteLine("Questão 33             Questão 49");
                Console.WriteLine("Questão 34             Questão 50");
                Console.WriteLine("Questão 35             Questão 51");
                Console.WriteLine("Questão 36             Questão 52");
                Console.WriteLine("Questão 37             Questão 53");
                Console.WriteLine("Questão 38             Questão 54");
                Console.WriteLine("Questão 39             Questão 55");
                Console.WriteLine("Questão 40             Questão 56");
                Console.WriteLine("Questão 41             Questão 57");
                Console.WriteLine("Questão 42             Questão 58");
                Console.WriteLine("Questão 43             Questão 59");
                Console.WriteLine("Questão 44             Questão 60");
                Console.WriteLine("Questão 45             Questão 61");
                Console.WriteLine("Questão 46             Questão 62");
                Console.WriteLine("Questão 47             Questão 63");
                Console.WriteLine("Questão 48             Questão 64");
                Console.WriteLine("Escolha uma questão");
                Console.WriteLine("Ou pressione 0 pra sair");



                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 33:
                        Exercicios op33 = new Exercicios();
                        op33.Questao33();


                        break;
                    case 34:
                        Exercicios op34 = new Exercicios();
                        op34.Questao34();
                        break;
                    case 35:
                        Exercicios op35 = new Exercicios();
                        op35.Questao35();
                        break;
                    case 36:
                        Exercicios op36 = new Exercicios();
                        op36.Questao36();
                        break;
                    case 37:
                        Exercicios op37 = new Exercicios();
                        op37.Questao37();
                        break;
                    case 38:
                        Exercicios op38 = new Exercicios();
                        op38.Questao38();
                        break;
                    case 39:
                        Exercicios op39 = new Exercicios();
                        op39.Questao39();
                        break;
                    case 40:
                        Exercicios op40 = new Exercicios();
                        op40.Questao40();
                        break;
                    case 41:
                        Exercicios op41 = new Exercicios();
                        op41.Questao41();
                        break;
                    case 42:
                        Exercicios op42 = new Exercicios();
                        op42.Questao42();
                        break;
                    case 43:
                        Exercicios op43 = new Exercicios();
                        op43.Questao43();
                        break;
                    case 44:
                        Exercicios op44 = new Exercicios();
                        op44.Questao44();
                        break;
                    case 45:
                        Exercicios op45 = new Exercicios();
                        op45.Questao45();
                        break;
                    case 46:
                        Exercicios op46 = new Exercicios();
                        op46.Questao46();
                        break;
                    case 47:
                        Exercicios op47 = new Exercicios();
                        op47.Questao47();
                        break;
                    case 48:
                        Exercicios op48 = new Exercicios();
                        op48.Questao48();
                        break;
                    case 49:
                        Exercicios op49 = new Exercicios();
                        op49.Questao49();
                        break;
                    case 50:
                        Exercicios op50 = new Exercicios();
                        op50.Questao50();
                        break;
                    case 51:
                        Exercicios op51 = new Exercicios();
                        op51.Questao51();
                        break;
                    case 52:
                        Exercicios op52 = new Exercicios();
                        op52.Questao52();
                        break;
                    case 53:
                        Exercicios op53 = new Exercicios();
                        op53.Questao53();
                        break;
                    case 54:
                        Exercicios op54 = new Exercicios();
                        op54.Questao54();
                        break;
                    case 55:
                        Exercicios op55 = new Exercicios();
                        op55.Questao55();
                        break;
                    case 56:
                        Exercicios op56 = new Exercicios();
                        op56.Questao56();
                        break;
                    case 57:
                        Exercicios op57 = new Exercicios();
                        op57.Questao57();
                        break;
                    case 58:
                        Exercicios op58 = new Exercicios();
                        op58.Questao58();
                        break;
                    case 59:
                        Exercicios op59 = new Exercicios();
                        op59.Questao59();
                        break;
                    case 60:
                        Exercicios op60 = new Exercicios();
                        op60.Questao60();
                        break;
                    case 61:
                        Exercicios op61 = new Exercicios();
                        op61.Questao61();
                        break;
                    case 62:
                        Exercicios op62 = new Exercicios();
                        op62.Questao62();
                        break;
                    case 63:
                        Exercicios op63 = new Exercicios();
                        op63.Questao63();
                        break;
                    case 64:
                        Exercicios op64 = new Exercicios();
                        op64.Questao64();
                        break;


                    case 0:
                        Console.WriteLine("Sair!");
                        break;
                    default:
                        Console.WriteLine("Opção invalida");

                        break;





                }






            } while (escolha != 0);



        }
    }
}


    }
}
