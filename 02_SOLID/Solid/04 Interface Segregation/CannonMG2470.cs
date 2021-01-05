using System;

namespace SOLID._04_Interface_Segregation
{
    public class CannonMG2470 : IPrintTasks
    {
        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("PhotoCopy Done"); return true;
        }
        public bool PrintContent(string content)
        {
            Console.WriteLine("Print Done"); return true;
        }
        public bool ScanContent(string content)
        {
            Console.WriteLine("Scan Done"); return true;
        }
        public bool PrintDuplexContent(string content)
        {
            return false;
        }
        public bool FaxContent(string content)
        {
            return false;
        }
    }
}
