namespace SOLID._04_Interface_Segregation
{
    public interface IPrintScanContent
    {
        bool PrintContent(string content);
        bool ScanContent(string content);
        bool PhotoCopyContent(string content);
    }

    public interface IFaxContent
    {
        bool FaxContent(string content);
    }

    public interface IPrintDuplex
    {
        bool PrintDuplexContent(string content);
    }
}
