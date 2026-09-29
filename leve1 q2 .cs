namespace q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> number =  new List<int> { 1, 2, 3, 4, 5,14 };

            var  allPositive = number.All(x => x > 0) ;

            Console.WriteLine($" divisable: All numbers are positive => {allPositive}");

            var divisable = number.Any(x => x % 7 == 0 );
            
            Console.WriteLine($" divisable:  At least one number is divisible by 7 => {divisable}");    

        }
    }
}
