namespace pag80
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.Write("Inser the first number: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inser the second number: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            if(n1>=0 && n2>= 0)
            {
                Console.WriteLine(n1+n2);
            }
            else
            {
                Console.WriteLine(n1 * n2);
            }
        }
    }
}