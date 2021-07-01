using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterScannerApp
{
    public class ScanManager:IScanner
    {
        public void ScanDocument(Scanner scanner)
        {
            scanner.Scan();
        }
    }
}
