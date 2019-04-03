 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            int divisor = 0;
            try
            {
                
                int result = num / divisor;
                Console.WriteLine(result);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("finally block");              

            }
            Console.WriteLine("After Finally Block");
            Console.ReadKey();
        }
    }
}
