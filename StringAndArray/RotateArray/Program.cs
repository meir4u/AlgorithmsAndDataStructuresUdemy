using System.Text;

namespace RotateArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>([1,2,3,4,5,6,7,8,9]);
            var rotate = new RotateArray();
            Console.WriteLine(print<int>(rotate.RotateRight(3,list.ToList())));
            Console.WriteLine(print<int>(rotate.RotateLeft(3,list.ToList())));
        }

        static string print<T>(List<T> list)
        {
            var sb = new StringBuilder();

            foreach (var item in list)
            {
                sb.Append(item + ",");
            }

            return sb.ToString().TrimEnd(',');
        }
    }
}
