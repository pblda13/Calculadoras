using System;
using System.Globalization;


namespace SolicitarCalc
{
    class Program
    {

        static float Imc()
        {
            float imc;

            Console.WriteLine("Calculadora IMC");
            Console.WriteLine();
            Console.WriteLine("Informe seu peso");
            float P = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe seu Altura");
            float A = float.Parse(Console.ReadLine());
            Console.WriteLine();

            imc = (P / (A * A));

            return imc;

        }

        static double AreaCirculo()
        {
            Console.WriteLine("Calculadora Area Circulo");
            Console.WriteLine();
            Console.WriteLine("Informe o raio");
            double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            double pi = 3.14159;
            double a = pi * (r * r);

            return a;

        }

        static double Regrade_3()
        {
            double A, B, C, resultado;
            Console.WriteLine("Calculadora regra de 3");
            Console.WriteLine();
            Console.WriteLine("Digite o valor de A");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C ");
            C = double.Parse(Console.ReadLine());

            resultado = (A * B) / C;

            return resultado;

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
                float imc = Imc();

                if (imc < 18.5)
                {
                    Console.WriteLine("Peso abaixo do normal " + imc.ToString("F2"));
                }
                else if ((imc == 18.5) || (imc == 25))
                {
                    Console.WriteLine("Peso normal " + imc.ToString("F2"));
                }
                if ((imc > 25) || (imc == 30))

                {
                    Console.WriteLine("Sobre o Peso " + imc.ToString("F2"));
                }
                else if ((imc > 30) || (imc == 35))
                {
                    Console.WriteLine("Grau de Obesidade I " + imc.ToString("F2"));
                }
                if ((imc > 35) || (imc == 40))
                {
                    Console.WriteLine("Grau de Obesidade II " + imc.ToString("F2"));
                }
                else if (imc > 40)
                {
                    Console.WriteLine("Obesidade Grau III " + imc.ToString("F2"));
                }

                Console.ReadKey();

            }

            else if (nun == 2)
            {
                double a = AreaCirculo();

                Console.WriteLine(" A = " + a.ToString("0.00"), CultureInfo.InvariantCulture);

                Console.ReadKey();


            }

            else if (nun == 3)
            {
                double resultado = Regrade_3();

                Console.WriteLine("O resultado é " + resultado, CultureInfo.InvariantCulture);

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