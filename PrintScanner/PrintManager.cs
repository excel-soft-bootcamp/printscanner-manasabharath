﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintScannerApp
{
    public class PrintManager:IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Print in Action");
        }
    }
}
