﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RPG
{
    public interface Item
    {
         int OriginalValue { get; set; }
         int ResellValue { get; set; }
    }
}
