using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_Cars.Model;


namespace Lesson_Cars
{
      
         
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Car car = new Car();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + ex.StackTrace);
            }            
            Console.ReadKey();
        }
    }
}
