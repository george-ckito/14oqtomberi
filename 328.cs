using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14oqtomberi
{
    internal class _328
    {
        public void Execute() {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a % 2 != 0)
            {
                a++;
            }

            for (int i = a; i <= b; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
