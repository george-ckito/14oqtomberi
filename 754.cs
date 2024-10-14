using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14oqtomberi
{
    internal class _754
    {
        public void Execute()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= n; i++) {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}
