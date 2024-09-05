namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PalindromeService.IsPalindromeByRecursion("madam"));       // Output: True
            Console.WriteLine(PalindromeService.IsPalindromeByRecursion("abba"));        // Output: True
            Console.WriteLine(PalindromeService.IsPalindromeByRecursion("palindrome"));  // Output: False
            Console.WriteLine(PalindromeService.IsPalindromeByRecursion("wepanicinapew"));// Output: True
        }
    }
}
