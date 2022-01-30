using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Second student = new Second();
            student.name = "ali";
            student.Surname = "habilov";
            student.Yash = 23;
            student.gmail = "habilov@gmail.com";

            Second student2 = new Second();
            student2.name = "ali";
            student2.Surname = "habilov";
            student2.Yash = 23;
            student2.gmail = "habilov@gmail.com";


            Second[] students = new Second[2];

            students[0]=student;
            students[1]=student2;

            //foreach (Second stu in students)
            //{

            //    stu.GetInfo();
            //}

            try
            {
                Console.WriteLine("eded daxl edimn :");
                int siraNo = int.Parse(Console.ReadLine());
                Console.WriteLine(getStudent(siraNo, students));
            }
            catch (Exception)
            {

                Console.WriteLine("bele bur teelebe yoxdur"); ;
            }
           
        }
        public static string getStudent(int x, Second[] array)
        {
            Second stu = array[x];
            return $"{stu.name} {stu.Surname} {stu.Yash}";
        }


    }
}
