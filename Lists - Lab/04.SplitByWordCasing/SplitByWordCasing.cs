﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(new char[]
                        { ' ', ';', ',', '.', ':', '!', '(', ')', '\'', '"', '\\', '/', '[', ']' },
                    StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> upperCase = new List<string>();
            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();

            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].All(char.IsUpper))
                {
                    upperCase.Add(words[i]);
                }
                else if (words[i].All(char.IsLower))
                {
                    lowerCase.Add(words[i]);
                }
                else
                {
                    mixedCase.Add(words[i]);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }
    }
}
