﻿using System;
using System.Collections.Generic;
using System.Text;

/*
The sum of the squares of the first ten natural numbers is,

1^2 + 2^2 + ... + 10^2 = 385

The square of the sum of the first ten natural numbers is,
(1 + 2 + ... + 10)^2 = 55^2 = 3025
Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.


namespace Project_Euler
{
    class Problem6
    {
        public static void Main() {
            int x;
            int b = 0;
            int c = 0;

            for (x = 1;x<=100;x++)
            {
               b += x*x;               
            }
            Console.WriteLine(b);

            for (x=1; x <= 100; x++) {
                c += x;
            }

            c = c * c;
            Console.WriteLine(c);
            Console.WriteLine(c - b);
            
            

            Console.ReadLine();



        } 
        
    }
}
*/
