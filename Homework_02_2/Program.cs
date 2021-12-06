using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
                double Math_Scores = 84.82;
                double Phisics_Scores = 87.14;
                string Pattern = "Баллы по математике: {0}; Баллы по физике: {1}.";
                double Sum = Math_Scores + Phisics_Scores;                  
                double Mean = Sum/2;      
                
         Console.WriteLine (Pattern, Math_Scores, Phisics_Scores);         
         Console.ReadKey();               

         Console.WriteLine ($"Сумма баллов = {Sum}"); 
         Console.ReadKey();  
            
         Console.WriteLine ($"Среднее арифметическое = {Mean}"); 
         Console.ReadKey();  





        }
    }
}
