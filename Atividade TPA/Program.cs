using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_TPA
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string[] nome = new string[5];
            int[] pontos = new int[5];


            for(i = 0; i <= 4; i++)
            {
                Console.WriteLine("Escreva o {0}° nome", i+1);
                nome[i] = Console.ReadLine();

            }
            for (i = 0; i <= 4; i++)
                {
                    Console.WriteLine("Escreva os pontos do {0}° time", i + 1);
                    pontos[i] = int.Parse(Console.ReadLine());

                }
        }
    }
}
