﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14oqtomberi
{
    internal class _755
    {
        public void Execute()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int ans = 1;
            for (int i = 0; i < n; i++) {
                ans *= 2;
            }
            Console.WriteLine(ans);
        }
    }
}
