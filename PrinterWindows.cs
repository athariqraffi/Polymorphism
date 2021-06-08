using System;
using System.Collections.Generic;
using System.Text;

namespace contoh01
{
    public class PrinterWindows
    {
        public virtual void Show()
        {
            Console.WriteLine("Select Printer to show dispay dimension ...");
        }

        public virtual void Print()
        {
            Console.WriteLine("Select Printer to printing ...");
        }
    }

    public class Canon : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Canon Display Dimension : 10 * 11");
        }

        public override void Print()
        {
            Console.WriteLine("Canon printer printing....");
        }
    }

    public class Epson : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Epson Display Dimension : 9.5 * 11");
        }

        public override void Print()
        {
            Console.WriteLine("Epson printer printing....");
        }

    }

    public class LaserJet : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("LaserJet Display Dimension : 20 * 20");
        }

        public override void Print()
        {
            Console.WriteLine("LaserJet printer printing....");
        }
    }

}
