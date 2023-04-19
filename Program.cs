using System;
using System.Security.Cryptography.X509Certificates;

namespace ExercicioWhile02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 1;
           
           while (x != 0 && y != 0)
            {
                string [] vet = Console.ReadLine().Split(' ');
                
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);

                if(x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if(x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                }
                else if(x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else if(x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
            }
        

            
           
        }
    }
}
