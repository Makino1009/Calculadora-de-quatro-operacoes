using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)

        {
            float a, b, r; 
            string aa;


            Console.WriteLine("Insira o primeiro valor: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("O que quer fazer?");
            aa = (Console.ReadLine());
            switch (aa)
            {
                case
                "somar":
                    r = a + b; Console.WriteLine(r);
 break;
                case
                "subtrair":
                    r = a - b; Console.WriteLine(r);
 break;
                case
                    "multiplicar":
                    r = a * b; Console.WriteLine(r);
 break;
                case
                    "dividir":
                    r = a / b; Console.WriteLine(r);
 break;          
                
                default: Console.WriteLine("favor escrever uma operação reconhecida."); break;
            }
            Console.WriteLine("Aperte enter pra fechar o programa.");
            Console.ReadLine();

        }
    }
}
