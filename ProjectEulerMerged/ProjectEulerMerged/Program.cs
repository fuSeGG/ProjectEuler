using ProjectEulerMerged.Problems;
using System;

namespace ProjectEulerMerged
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            Problem11 activeProblem = new Problem11();
            activeProblem.PopulateStrings();
            activeProblem.ShowString();
        }
    }
}
