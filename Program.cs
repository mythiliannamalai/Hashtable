using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We find frequency from hashmap!");
            LinkedHashMap<string,int> LinkedHashMap = new LinkedHashMap<string,int>(5);
            string sentence = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidablesituations";
            string[] words = sentence.ToLower().Split(" ");
            foreach (string word in words)
            {
                int value = LinkedHashMap.Get(word);
                if (value == default)
                {
                    value = 1;
                }
                else value += 1;
                LinkedHashMap.Add(word, value);
            }
            int frequency = LinkedHashMap.Get("are");
            Console.WriteLine(frequency);
            
        }
    }
}