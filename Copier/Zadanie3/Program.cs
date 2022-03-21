using System;

namespace Zadanie3
{
    class Program
    {
        static void Main()
        {
            var xeroxp = new Printer();
            var xeroxs = new Scanner();
            var xerox = new Copier(xeroxp, xeroxs);
            xerox.PowerOn();
            IDocument doc1 = new PDFDocument("aaa.pdf");
            xerox.Print(in doc1);

            IDocument doc2;
            xerox.Scan(out doc2);
            xerox.Scan(out doc2, formatType: IDocument.FormatType.JPG);

            xerox.ScanAndPrint();
            System.Console.WriteLine(xerox.Counter);
            System.Console.WriteLine(xeroxp.PrintCounter);
            System.Console.WriteLine(xerox.ScanCounter);

        }
    }
}
