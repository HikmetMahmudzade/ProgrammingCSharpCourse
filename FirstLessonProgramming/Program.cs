using System;

namespace FirstLessonProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eded1 daxil edin : ");

            int eded1;

            while (true)
            {
                try
                {
                    eded1 = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Ancaq int tipli simvol daxil edin!");
                }
            }

            Console.WriteLine("Eded2 daxil edin : ");
            int eded2 = int.Parse(Console.ReadLine());

            //int sum = Sum(eded1, eded2);

            Console.WriteLine("Cavab : " + Sum(eded1, eded2));
        }

        public static int Sum(int a,int b)
        {
            return a + b;
        }
    }
}
