using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    public class LinqPractice
    {
        //member variables
        List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
        string name = "Nelson";
        List<string> classGrades = new List<string>()
            {
            "80,100,92,89,65",
            "93,81,78,84,69",
            "73,88,83,99,64",
            "98,100,66,74,55"
            };

        //constructor

        //member methods
        public List<Words> GetWords()
        {
            return new List<Words>()
            {
                new Words {word = "the"},
                new Words {word = "bike"},
                new Words {word = "this"},
                new Words {word = "it"},
                new Words {word = "tenth"},
                new Words {word = "mathematics"},
            };
        }

        public void ReturnSubstring()
        {
            var words = new LinqPractice().GetWords();
            var thWords = words.Where(w => w.word.Contains("th"));
            foreach (var word in thWords)
            {
                Console.WriteLine(word.word);

            }
            Console.ReadLine();
        }

        public void ReturnNonDuplicateNames()
        {
            List<string> resultOfNoDuplicates = names.Distinct().ToList();
            foreach (var name in resultOfNoDuplicates)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

        }

        public void ReturnClassAverage()
        {
            var grades = classGrades;
            var dropLowestForEachStudent = classGrades.Select(s => s.Split(',').Select(l => Convert.ToInt32(l)).ToList().OrderByDescending(n => n).Take(4).ToList().Average()).Average();
            Console.WriteLine(dropLowestForEachStudent);
            Console.ReadLine();
        }

        public void AlphabeticallyOrderedStringFrequency()
        {

            //var result = name.ToLower().GroupBy(x => x).Where(x => x.Key != ' ').Select(x => $"{x.Key} = {x.Count()}").OrderBy(c => c);
            var newResult = name.ToLower().GroupBy(x => x).Where(x => x.Key != ' ').Select(x => $"{x.Count()}").Zip(name, (first, second) => first + second + "|").OrderBy(c => c);
            string finalResult = "";
            foreach(string thing in newResult)
            {
                finalResult += thing;
            }
            Console.WriteLine(finalResult);
            Console.ReadLine();
        }
    }
}
