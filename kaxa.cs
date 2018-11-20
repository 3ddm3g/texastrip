using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ferriskelle
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int ar = 0;
            Console.WriteLine("mien píza szeretnel?");
            string type = Console.ReadLine();
            Console.WriteLine("milyen meret?");
            int size = Convert.ToInt32(Console.ReadLine());
            if (type == "margareta" || type == "gombas")
            {
                if (size == 28) ar = 1200;
                else if (size == 50) ar = 2400;
            }
            else if (type == "vegetarianus" || type == "gyrosos" || type == "negysajtos")
            {
                if (size == 28) ar = 1800;
                else if (size == 50) ar = 3500;
            }
            if (ar > 0) Console.WriteLine("Fizetendo: " + ar);
            else Console.WriteLine("Eltevedtel?"+ar);

            //2
            Console.WriteLine("Süt-e a nap?");
            int sute = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fúj-e a szél?");
            int fuje = Convert.ToInt32(Console.ReadLine());
            if (sute == 1 && fuje == 0) Console.WriteLine("Kirandulni megyunk");
            else if (sute == 1 && fuje == 1) Console.WriteLine("Moziba megyunk");
            else if (sute == 0) Console.WriteLine("Othon maradunk");

            //3
            Console.WriteLine("Kezdö érték:");
            int begin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vég érték:");
            int end = Convert.ToInt32(Console.ReadLine());
            int oss = 0;
            for (int i = begin; i <= end; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write(i + " ");
                    oss++;
                }
            }
            Console.WriteLine("| osszesen: "+oss);
            
            //4
            Console.WriteLine("szamjegyek: ");
            int jegy = Convert.ToInt32(Console.ReadLine()), beg = 1, eni = 0;
            for (int i = 1; i < jegy; i++) beg *= 10;
            eni = beg*10;
            for (int i = beg; i < eni; i++) if (automorf(i)) Console.Write(i+"\n");

            //5
            for (int i = 100; i < 1000; i++) if (i.ToString().ToCharArray()[0] == i.ToString().ToCharArray()[2]) Console.Write(i+"\n");


                Console.ReadKey();
        }
        static bool automorf(int numa)
        {
            string lap = numa + "";
            string negyzet = numa*numa + "";
            if (negyzet.EndsWith(lap)) return true;
            else return false;
        }

    }
}
