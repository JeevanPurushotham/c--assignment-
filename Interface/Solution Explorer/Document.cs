namespace InterfaceDemo
{
    public class Document : IPrintable, ILoggable
    {
        public void Print()
        {
            Console.WriteLine("Document is being printed.");
        }

        void ILoggable.Print()
        {
            Console.WriteLine("Document is being logged.");
        }
    }
}
