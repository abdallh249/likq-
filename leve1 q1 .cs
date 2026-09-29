

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new [] { 1, 5, 0, 10,13,20,8 };

            var greaterThanFive = numbers.Where(n => n > 5).OrderByDescending(n => n);

            foreach (var number in greaterThanFive)
            {
                Console.WriteLine($" greaterThanFive => {number}");
            }
           
        }
    }
}
