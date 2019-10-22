using System.Collections.Generic;
using System.Linq;

namespace CodeWars.Commands
{
    public class StringHandler
    {
        public int GetVowelCount(string str)
        {
            int vowelCount = 0;
            List<string> vowels = new List<string>()
            {
                "A", "E", "I", "O", "U"
            };

            foreach(char letter in str)
            {
                vowelCount += vowels.Count(ltr => ltr == letter.ToString().ToUpper());
            }

            return vowelCount;
        }
    }
}
