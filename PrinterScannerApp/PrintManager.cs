using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterScannerApp
{
    public class PrintManager:IPrinter
    {
       

        public void PrintDocument(Printer printer)
        {
            printer.Print();

        }

    }
}

