using System;

namespace EvAlqiSatqisi
{
    class Program
    {
        static void Main(string[] args)
        {




            Ev ev1 = new Ev
            {
                flat = 39,
                size= 191, 
                price = 200000,
                location = "Seyid Azim Sirvani  1b"
            };
            Ev ev2 = new Ev
            {
                flat = 19,
                size = 131,
                price = 202000,
                location = "Seyid Azim Sirvani  1b"
            };
            Ev ev3 = new Ev
            {
                flat = 19,
                size = 141,
                price = 100000,
                location = "Seyid Azim Sirvani  1b"
            };
            Ev ev4 = new Ev
            {
                flat = 49,
                size = 121,
                price = 90000,
                location = "Seyid Azim Sirvani  1b"
            };
            Ev ev5 = new Ev
            {
                flat = 339,
                size = 161,
                price = 200000,
                location = "Seyid Azim Sirvani  1b"
            };
            Ev[] evler = new Ev[5];

            evler[0] = ev1;
            evler[1] = ev2;
            evler[2] = ev3;
            evler[3] = ev4;
            evler[4] = ev5;
            try
            {
                Console.WriteLine("daxil edin");
                int MenzilNo = int.Parse(Console.ReadLine());
                int MenzilNo2 = int.Parse(Console.ReadLine());
                Console.WriteLine(Ev.getwo(MenzilNo, MenzilNo2, evler));
            }
            catch (Exception)
            {

                throw;
            }

            



             


        }
    }
}

