namespace AttributeEnumConsoleApp
{
    [Flags]
    enum FontStyle
    {
        Bold = 0,
        Italic = 1,
        Underlined = 2,
        Arabic = 4
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            FontStyle c = FontStyle.Bold ^ FontStyle.Italic;
            c ^= FontStyle.Italic;
            Console.WriteLine(c);
        }
    }
}