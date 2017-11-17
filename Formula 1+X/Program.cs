using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            Console.WriteLine("Cuantas Iteraciones");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero a trabajar");
            i = int.Parse(Console.ReadLine());
            proceso(n, i);
            Console.ReadKey();
        }
        static public double ResCad(int p, int n)
        {
            double r;
            if (p == 0)
            {
                return 1;
            }
            else
            {
                r = n * ResCad(p - 1, n);

            }
            return r;
        }
        static public void Cad(int p, int r)
        {
            if (p == 0)
            {
                Console.Write($"{r})");
                return;
            }
            else
            {
                Console.Write("{0} *", r);
                Cad(p - 1, r + 2);
            }
        }
        static public double Resul(int p, int n, int i, int ii)
        {
            double r = 0;
            if (ii <= i)
            {
                return r + 1;
            }
            else
            {
                r = r + Math.Pow(n, ii + 2) / ResCad(p, 3);
                Resul(p, n, i, ii);
            }
            return r;
        }
        static void proceso(int i, int n)
        {
            Imprime(0, 3, i);
            Console.Write($"{Resul(3, n, i, 0)}");
        }
        static public void Imprime(int p, int pf, int n)
        {
            if (p >= pf)
            {
                Console.Write("1 =");
                return;
            }
            else
            {
                Console.Write($"({Math.Pow(n, p + 2)}/");
                Cad(p, 3);
                Console.Write("+");
                Imprime(p + 1, pf, n);
            }

        }

    }
}