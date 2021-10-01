using System;

namespace LabCompis
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = true;
            do
            {
                Console.WriteLine("Ingrese Cadena a operar");
                string regexp = Console.ReadLine();
                Parser parser = new Parser();
                parser.Parse(regexp);
                double res = parser.res;
                Console.WriteLine("Resultado: " + res);
                Console.WriteLine("Desea ingresar otra? Y/N");
                string confir = Console.ReadLine();
                confir.ToLower();
                if (confir.Equals("n"))
                {
                    x = false;
                }
            } while (x);
        }
    }
}
