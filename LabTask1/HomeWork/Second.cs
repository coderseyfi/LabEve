using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Second
    {

        public string name;
        public string Surname;
        public int Yash;
        public string gmail;

        public void GetInfo()
        {
            Console.WriteLine($"{name}\n" +
                $"{Surname}\n" +
                $"{gmail}\n" +
                $"{Yash}");
            
        }

        public string GetValue()
        {
            return $"{name} {Surname}";
            //return elirikse onda program class da
            //console write line ile yaz
        }

        
        

    }
}
