using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14oqtomberi
{
    internal class _296
    {
        public void Execute()
        {
            // YES - oris xarisxi, sxva shemtxvevashi - NO
            int x = Convert.ToInt32(Console.ReadLine());
            while (x % 2 == 0) {
                x /= 2;
            }
            if (x == 1)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
