using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //a Fibonacci sequence is generated by adding the previous two terms :
            //By starting with 1 and 2 find the sum of the even-valued terms - do not exceed 4 million.


            
            //create variables to hold current, previous, and next value.
            int currentv = 2,
                previousv = 1,
                nextv = 0,
                sumv = 2;

            //display 1 and 2 becaue while loop begins at 3 - initially started with 0 and 1 and need this but decided to just change the number values
           // Console.WriteLine( "{0} \n{1}", previousv, currentv);

            //Condition: continue looping through equation as long as value is below 4 million
            while (nextv < 4000000)
            {
                //every time in loops the currentv becomes the previousv and the nextv becomes the currentv
                nextv = currentv + previousv;                
                previousv = currentv;
                currentv = nextv;

                //the final currentv's are divided by 2 and if there is no remainder the value will be even and get passed through the if 
                if (currentv % 2 == 0)
                {
                    //the sum of all even numbers
                    sumv += currentv;
                }//end if
                
            }//end for

            //displaying sum of even numbers
            Console.WriteLine(sumv);
            
        }
    }
}
