using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMiscellaneousProjects_NumberOfCharacters
{
    public class CharacterCounter
    {
        public static string CharacterCount(string word)
        {
            if (word.Length == 0) return $"You must input a word to count its letters!";
            return $"{word} has {word.Length} characters";
        }
    }
}
