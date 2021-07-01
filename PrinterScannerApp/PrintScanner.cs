using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterScannerApp
{
    public class PrintScanner:IPrinter,IScanner
    {
         public void PrintDocument(Printer printer)
        {
            printer.Print();

        }

        public void ScanDocument(Scanner scanner)
        {
            scanner.Scan();
        }
    }
}
