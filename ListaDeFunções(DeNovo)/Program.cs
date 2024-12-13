using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeFunções_DeNovo_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            do
            {
                op = Menu();
                switch (op)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("OBRIGADO POR UTILIZAR ESSE SOFTWARE");
                        break;


                    case 1:
                        Console.Clear();
                        Console.WriteLine("VERIFICAR SE O NÚMERO É PAR OU ÍMPAR\n");
                        Console.Write("Digite um número: ");
                        int numero = Convert.ToInt32(Console.ReadLine());
                        
                        if (Verifica_Par_Ou_Impar(numero) == true)
                        {
                            Console.WriteLine("O número é Par");
                        }
                        else
                        {
                            Console.WriteLine("O número é Ímpar");
                        }
                        Console.Write("\nDigite qualquer tecla para voltar para o MENU: ");
                        Console.ReadKey();
                        Console.Clear();
                        break;


                    case 2:
                        Console.Clear();
                        Console.WriteLine("CALCULAR A ÁREA DO CÍRCULO E PERIMETRO\n");
                        Console.Write("Digite o valor do raio: ");
                        double raio = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"O valor da Área é {Area(raio)}");
                        Console.WriteLine($"O valor da Perimetro é {Perimetro(raio)}");

                        Console.Write("\nDigite qualquer tecla para voltar para o MENU: ");
                        Console.ReadKey();
                        Console.Clear();
                        break;


                    case 3:
                        Console.Clear();
                        Console.WriteLine("CONVERSOR DE FAHRENHEIT PARA CELSIUS\n");
                        Console.Write("Digite um valor para a temperatura Fahrenheit: ");
                        double Fahrenheit = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"O valor {Fahrenheit}°F em Celsius é {Celsius(Fahrenheit)}°C");

                        Console.Write("\nDigite qualquer tecla para voltar para o MENU: ");
                        Console.ReadKey();
                        Console.Clear();
                        break; 


                    case 4:
                        Console.Clear();
                        Console.WriteLine("VERIFICAR A MÉDIA SEMESTRAL\n");
                        Console.Write("Digite a primeira nota do aluno: ");
                        double nota1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite a segunda nota do aluno: ");
                        double nota2 = Convert.ToDouble(Console.ReadLine());

                        if (NotasSemestre(nota1, nota2) >= 6)
                        {
                            Console.WriteLine("PARABÉNS! Você foi aprovado!");
                        }
                        else
                        {
                            Console.WriteLine("Infelizmente você foi reprovado!");
                        }
                        Console.Write("\nDigite qualquer tecla para voltar para o MENU: ");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("PESO IDEAL\n");
                        Console.Write("Digite a sua altura [em metros]: ");
                        double altura = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite o seu sexo [1 - feminino | 2 - masculino]: ");
                        int sexo = Convert.ToInt32(Console.ReadLine());
                        if (sexo == 1 || sexo == 2)
                        {
                            Console.WriteLine($"O peso ideal para você é {PesoIdeal(altura,sexo)} Kg");
                        }
                        else
                        {
                            Console.WriteLine("Valor digitado no sexo inválido");
                        }
                        Console.Write("\nDigite qualquer tecla para voltar para o MENU: ");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 6:
                        Console.Clear();
                        Console.WriteLine("POLÍGONOS");
                        Console.WriteLine("VALORES DE LADOS ACEITADOS -> 3,4,5");
                        Console.Write("Digite a quantidade de lados do seu polígono: ");
                        int lados = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite a medida do lado [em centímetros]: ");
                        double medidadelado = Convert.ToDouble(Console.ReadLine());
                        Poligono(lados,medidadelado);

                        Console.Write("\nDigite qualquer tecla para voltar para o MENU: ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("OPÇÃO INVÁLIDA. TENTE NOVAMENTE\n");
                        break;
                }
            }
            while (op != 0);



            Console.ReadKey();
        }
        
        //Função para o MENU
        static int Menu()
        {

            Console.WriteLine("MENU\n");
            Console.WriteLine("0 - SAIR");
            Console.WriteLine("1 - Verificar se um número é Par ou Ímpar");
            Console.WriteLine("2 - Calcular a área do círculo e perimetro");
            Console.WriteLine("3 - Conversor de Fahrenheit para Celsius");
            Console.WriteLine("4 - Verificar a média semestral");
            Console.WriteLine("5 - Peso Ideal");
            Console.WriteLine("6 - Polígono");
            Console.WriteLine("Infome sua opção: ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            return opcao;
        }

        //Exercicio 1
        static bool Verifica_Par_Ou_Impar(int num)
        {
            bool Par = true;

            if (num % 2 == 0)
            {
                Par = true;
            }
            else
            {
                Par = false;
            }
            return Par;
        }

        //Exercicio 2
        static double Area(double raio)
        {
            double area = 3.14 * (raio * raio);
            return area;
        }
        static double Perimetro(double raio)
        {
            double perimetro = 3.14 * 2 * raio;
            return perimetro;
        }

        //Exercicio 3
        static double Celsius(double Fahrenheit)
        {
            double celsius = ((Fahrenheit - 32) / 9) * 5;
            return celsius;
        }
        
        //Exercicio 4
        static double NotasSemestre(double nota1, double nota2)
        {
            double mediasemestral = (nota1 + nota2) / 2;
            return mediasemestral;
        }
        
        //Exercicio 5 
        static double PesoIdeal(double altura, int sexo)
        {
            double PesoIdeal;
            if (sexo == 1)
            {
                PesoIdeal = (62.1 * altura) - 44.7;
                return PesoIdeal;
            }
            else
            {
                PesoIdeal = (72.7 * altura) - 58;
                return PesoIdeal;
            }
            
        }

        //Exercicio 6
        static void Poligono(int lados, double medidadolado)
        {
            if(lados == 3)
            {
                double perimetro = medidadolado * lados;
                Console.WriteLine("TRIÂNGULO");
                Console.WriteLine($"O valor da área é {perimetro}");
            }
            else if(lados == 4)
            {
                double perimetro = medidadolado * lados;
                Console.WriteLine("QUADRADO");
                Console.WriteLine($"O valor da área é {perimetro}");
            }
            else if (lados == 5)
            {
                double perimetro = medidadolado * lados;
                Console.WriteLine("PENTÁGONO");
                Console.WriteLine($"O valor da área é {perimetro}");
            }
            else
            {
                Console.WriteLine("Valor não encontrado.");
            }
        }

        //Exercicio 7 
    }
}
