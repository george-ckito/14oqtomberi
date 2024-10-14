using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14oqtomberi
{
    internal class palindrome
    {
        public void Execute()
        {
            bool ans = true;
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != input[input.Length - i - 1])
                {
                    ans = false;
                    break;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
