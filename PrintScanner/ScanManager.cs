using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintScannerApp
{
    public class ScanManager : IScanner
    {
        public void Scan()
        {
            Console.WriteLine("Scan in Action");
        }
    }
}
