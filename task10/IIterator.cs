﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10
{
    public interface IIterator<T>
    {
        bool HasNext();

        object Next();
    }
}
