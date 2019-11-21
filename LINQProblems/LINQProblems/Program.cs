using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqPractice linq = new LinqPractice();
            linq.ReturnSubstring();
            linq.ReturnNonDuplicateNames();
            linq.ReturnClassAverage();
            linq.AlphabeticallyOrderedStringFrequency();
        }
    }
}
