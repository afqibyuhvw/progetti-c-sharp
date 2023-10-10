namespace pag77
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, max;

            Console.Write("Insert the first number: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insert the second number: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insert the third number: ");
            n3 = Convert.ToInt32(Console.ReadLine());
            /*
            if(n1 > n2 && n1>n3)
            {
                Console.WriteLine(n1);
            }
            else if(n1 > n2 && n1 < n3)
            {
                Console.WriteLine(n3);
            }
            else if(n1 < n2 && n2 > n3)
            {
                Console.WriteLine(n2);
            }
            else if(n1 < n2 && n2 < n3)
            {
                Console.WriteLine(n3);
            }
            */

            max = n1;
            if(n2 > max)
            {
                max = n2;
            }
            if(n3 > max)
            {
                max = n3;
            }
            Console.WriteLine(max);
        }
    }
}
