using System;
using System.Collections.Generic;
using System.Globalization;


namespace SolicitarCalc.Entities
{
    class Imc
    {

        public void CalcImc()
        {
            double P, A;

            Console.WriteLine("Calculadora IMC");
            Console.WriteLine();
            Console.WriteLine("Informe seu peso");
            P = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe seu Altura");
            A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine(CalcclassifiIMC(P, A));
        }
        public  string CalcclassifiIMC(double P, double A)
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


    }
}
