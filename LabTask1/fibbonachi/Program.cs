using System;

namespace fibbonachi
{
    class Program
    {
        static void Main(string[] args)
        {

            //fibbianachi
            //0 1 1 2 3 5 8 13
            #region
            int a = 0;
            int b = 1;
            int cem = 0;
            int daxil = int.Parse(Console.ReadLine());
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 2; i < daxil; i++)
            {
                cem = a + b;
                Console.WriteLine(cem);
                a = b;
                b = cem;


            }
            #endregion


            //polindrom

            






        }
         void getInfo()
        {

        }
    }
}
