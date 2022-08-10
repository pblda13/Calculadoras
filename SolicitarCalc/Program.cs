using System;
using System.Globalization;


namespace SolicitarCalc
{
    class Program
    {
        public static string CalcclassifiIMC(double P, double A)
        {


            double imc = P / (A * A);

            if (imc < 18.49)
            {
                return ("Peso abaixo do normal ");
            }
            else if (imc <= 24.99)
            {
                return ("Peso normal ");
            }
            else if (imc <= 29.99)

            {
                return ("Sobre o Peso ");
            }
            else if (imc <= 34.99)
            {
                return ("Grau de Obesidade I ");
            }
            else if (imc <= 39.99)
            {
                return ("Grau de Obesidade II ");
            }
            else
            {
                return ("Obesidade Grau III ");
            }

        }

        static void CalcImc()
        {
            double P, A;

            Console.WriteLine("Calculadora IMC");
            Console.WriteLine();
            Console.WriteLine("Informe seu peso");
            P = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe seu Altura");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(CalcclassifiIMC(P, A));

        }
        //-----------------------------------------------------------------------------------------------------------------
        public static double Calculoarea(double r)

        {
            double pi = 3.14159;
            double a = pi * (r * r);

            return a;

        }
        static void AreaCirculo()
        {
            Console.WriteLine("Calculadora Area Circulo");
            Console.WriteLine();
            Console.WriteLine("Informe o raio");
            double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine(Calculoarea(r));


        }

        //-----------------------------------------------------------------------------------------------------------------

        public static double CalculoRegra(double A, double B,double C)
        {
           
            double resultado = (A * B) / C;

            return resultado;
        }

        static void Regrade_3()
        {
            double A, B, C;
            Console.WriteLine("Calculadora regra de 3");
            Console.WriteLine();
            Console.WriteLine("Digite o valor de A");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C ");
            C = double.Parse(Console.ReadLine());

            Console.WriteLine(CalculoRegra( A,B,C));

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Selecione a calculadora desejada");
            Console.WriteLine();
            Console.WriteLine("1 - Calculadora IMC ");
            Console.WriteLine("2 - Calculadora Area Circulo");
            Console.WriteLine("3 - Calculadora regra de 3");
            Console.WriteLine("4 - Sair");
            int nun = int.Parse(Console.ReadLine());



            if (nun == 1)
            {
                CalcImc();

                Console.ReadKey();

            }

            else if (nun == 2)
            {

                AreaCirculo();

                Console.ReadKey();

            }

            else if (nun == 3)
            {
                Regrade_3();

                Console.ReadKey();

            }

            else
            {
                Console.WriteLine("FINALIZADO COM SUCESSO!");

                Console.ReadKey();
            }
        }


    }
}