using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvAlqiSatqisi
{
    class Ev
    {

        public int flat ;
        public int size;
        public int price;
        public string location;

        public void About()
        {
            Console.WriteLine($"{flat}\n" +
                $"{size}\n" +
                $"{price}\n" +
                $"{location}");

        }

        public static string getwo(int x, int y, Ev[] array)
        {
            return $"{array[x].flat} {array[y].flat}";
            }

    }
}
