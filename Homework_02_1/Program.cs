using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
            {
                string FullName = "Селиванов Дмитрий Олегович";
                byte Age = 25;
                string Email = "demetrius.w.0813@gmail.com";
                double Programing_Scores = 35.6;
                double Math_Scores = 84.82;
                double Phisics_Scores = 87.14;
                string Pattern = "Ф.И.О.: {0} \nВозраст: {1} лет \nEmail: {2} \nБаллы по програмированию: {3} \nБаллы по математике: {4} \nБаллы по физике: {5}";

                Console.WriteLine (Pattern, 
                                   FullName, 
                                   Age, 
                                   Email, 
                                   Programing_Scores, 
                                   Math_Scores, 
                                   Phisics_Scores);

         Console.ReadKey();
        }
    }
}
