namespace ReverseWordInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reversedWords = new ReverseWords();

            Console.WriteLine(reversedWords.Reversed("Hello, World!"));
            
            Console.WriteLine(reversedWords.Reversed("Hello, sdgsdfg sdfgsdg sdfgreff World!"));
            
            Console.WriteLine(reversedWords.Reversed("sdfgsdg sdfgd, ghh erw4 World!"));
        }
    }
}
