using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;
            int soma = 0;   
            int qty = 0;
            while (valor != -1)
            {
                Console.WriteLine("Digite um valor (-1 para sair): ");
                valor = int.Parse(Console.ReadLine());
                if  (valor != -1)
                {
                    soma += valor;
                    qty += 1;
                }
                
                    
            }
            Console.WriteLine("A soma dos valores é: " + soma + ". Já a média é: " + soma / qty);
            Console.ReadLine();
        }
    }
}
