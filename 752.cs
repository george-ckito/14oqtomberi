using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14oqtomberi
{
    internal class _752
    {
        public void Execute()
        {
            string ticket = Console.ReadLine();
            if (Convert.ToInt32(ticket[0]) + Convert.ToInt32(ticket[1]) + Convert.ToInt32(ticket[2]) == Convert.ToInt32(ticket[3]) + Convert.ToInt32(ticket[4]) + Convert.ToInt32(ticket[5]))
            {
                Console.WriteLine("YES");
            } else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
