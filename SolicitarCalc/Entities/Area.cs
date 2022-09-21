using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SolicitarCalc.Entities
{
    class Area
    {

        public void AreaCirculo()
        {
            Console.WriteLine("Calculadora Area Circulo");
            Console.WriteLine();
            Console.WriteLine("Informe o raio");
            double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine(Calculoarea(r));


        }
        public  double Calculoarea(double r)

        {
            double pi = 3.14159;
            double a = pi * (r * r);

            return a;

        }
        
    }
}
