using System;

namespace inlämningsuppgift_3._2
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiet?");
            Console.WriteLine("Tryck gärna på j för ja och n för nej");
            string boose = Console.ReadLine();
            Console.WriteLine("hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());
            if (ålder >= 22)
            {
                Console.WriteLine("tyvärr vi söker annan personal just nu");
            }
            else if (ålder<22 && boose == "j")
            {
                Console.WriteLine("Vi vill gärna anställa dig");
            }
            else
            {
                Console.WriteLine("vi letar efter annan personal just nu");
            }
            Console.ReadKey();
        }
    }
}
