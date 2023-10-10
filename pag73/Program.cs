namespace pag73
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Inser a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            if(num % 2 == 0)
            {
                Console.WriteLine($"il numero {num} e' pari");
            }
            else
            {
                Console.WriteLine($"il numero {num} e' dispari");
            }


        }
    }
}