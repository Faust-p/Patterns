﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3.Beverages
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "DarkRoast";
        }

        public override double Cost()
        {
            return 3.40;
        }
    }
}
