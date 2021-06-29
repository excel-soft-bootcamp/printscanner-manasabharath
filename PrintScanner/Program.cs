using System;

namespace PrintScannerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintManager printManager = new PrintManager();
            ScanManager scanManager = new ScanManager();
            PrintScanner print_scan = new PrintScanner(printManager, scanManager);
            print_scan.PrintScan();
        }
    }
}
