using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Euler {
    class Problem16 {

        public static void Main() {

            double n = Math.Pow(2, 1000);
            string nString = n.ToString();

            List<double> list = new List<double>();

            var result = nString.Select(s => s.ToSafeInt()).ToArray();

            
            
            Console.WriteLine(nSum);
            Console.ReadLine();                  
        }

        



    }
}
