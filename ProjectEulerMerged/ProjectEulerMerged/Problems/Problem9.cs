using System;
using System.Collections.Generic;
using System.Text;

/*
  A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

a2 + b2 = c2
For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.

There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc.

    a + b + c = 1000
    a<b<c
    a^2 + b^2 = c2
    
    x = a*b*c
    



namespace Project_Euler.Problems {

    class Problem9 {

        public static void Main() {

            for (int c = 3; c <= 1000; c++) {
                for (int b = 2; b <= c; b++) {
                    for (int a = 1; a <= b; a++) {

                        int sumtest = a + b + c;
                        double cPwr = c * c;
                        int result = a * b * c;
                        double abPwr = (a * a) + (b * b);

                        if (sumtest == 1000 && abPwr == cPwr) {
                            Console.WriteLine("Result: {0}", result);
                            Console.ReadLine();
                        }
                    }
                }
            }
        }
    }
}
*/
