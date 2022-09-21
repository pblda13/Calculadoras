using System;
using System.Collections.Generic;
using System.Text;

namespace SolicitarCalc.Entities
{
    class RegraDe3
    {

        public void Regrade_3()
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

            Console.WriteLine(CalculoRegra(A, B, C));

        }
        public  double CalculoRegra(double A, double B, double C)
        {

            double resultado = (A * B) / C;

            return resultado;
        }

        
    }
}
