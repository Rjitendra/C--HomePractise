using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class AdditionOfNumber
    {

        static void Main(string[] args) { 
            Console.WriteLine("enter a no");
            int number =Convert.ToInt32(Console.ReadLine());
           
          
            for(int i=1;i<=number;i++)
            {
                long digit,temp, sum = 0;
                temp = i;
                if (temp % 4 == 0) {
                    while (temp > 0)
                    {
                        digit = temp % 10;
                        sum = sum + digit;
                        temp /= 10;
                    }
                

                    Console.WriteLine(sum);
                }

            }
          
            Console.ReadLine();

        }
    }
}
