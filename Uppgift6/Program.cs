using System;
using System.Collections.Generic;
namespace uppgift6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> varor = new List<string>();
            List<int> priser = new List<int>();
            List<string> handlingslista = new List<string>();
            Console.Write("Skriv in namn på matvaror: ");
            foreach (string vara in Console.ReadLine().Split())
            {
                varor.Add(vara);
            }
            Console.Write("Skriv in matvarornas priser: ");
            foreach (string pris in Console.ReadLine().Split())
            {
                priser.Add(int.Parse(pris));
            }
            Dictionary<string, int> dic = new Dictionary<string, int>();
            int a = 0;
            foreach (string vara in varor)
            {
                dic[vara] = priser[a];
                a++;
            }
            Console.Write("Skriv in din handlingslista: ");
            foreach (string vara in Console.ReadLine().Split())
            {
                handlingslista.Add(vara);
            }
            double summa = 0;
            foreach (string vara in handlingslista)
            {
                summa += dic[vara];
            }
            Console.WriteLine();
            Console.WriteLine($"Priset för handlingslistan är: {summa}kr");
            Console.ReadKey();
        }
    }
}