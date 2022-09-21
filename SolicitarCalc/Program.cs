using System;
using SolicitarCalc.Entities;


namespace SolicitarCalc
{
    class Program
    {


        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("Selecione a calculadora desejada");
                    Console.WriteLine();
                    Console.WriteLine("1 - Calculadora IMC ");
                    Console.WriteLine("2 - Calculadora Area Circulo");
                    Console.WriteLine("3 - Calculadora regra de 3");
                    Console.WriteLine("4 - Sair");
                    int nun = int.Parse(Console.ReadLine());



                    if (nun == 1)
                    {
                        Imc imc = new Imc();
                        imc.CalcImc();


                        Console.ReadKey();

                    }

                    else if (nun == 2)
                    {

                        Area area = new Area();
                        area.AreaCirculo();

                        Console.ReadKey();

                    }

                    else if (nun == 3)
                    {
                        RegraDe3 regraDe3 = new RegraDe3();
                        regraDe3.Regrade_3();

                        Console.ReadKey();

                    }

                    else
                    {
                        Console.WriteLine("FINALIZADO COM SUCESSO!");

                        Console.ReadKey();
                    }

                }
                catch (Exception e)
                {
                    

                }

            }

        }
    }
}