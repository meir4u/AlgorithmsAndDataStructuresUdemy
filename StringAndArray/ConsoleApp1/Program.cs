namespace ExpressionEvaluater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ExpressionEvaluateService.Evaluate("3<5"));       // Output: true
            Console.WriteLine(ExpressionEvaluateService.Evaluate("aa>bb"));     // Output: false
            Console.WriteLine(ExpressionEvaluateService.Evaluate("true=false")); // Output: false
            Console.WriteLine(ExpressionEvaluateService.Evaluate("hrc"));       // Output: true
            Console.WriteLine(ExpressionEvaluateService.Evaluate("false=false"));// Output: true
            Console.WriteLine(ExpressionEvaluateService.Evaluate("false>true")); // Output: false
            Console.WriteLine(ExpressionEvaluateService.Evaluate("-10<98"));    // Output: true
        }
    }
}
