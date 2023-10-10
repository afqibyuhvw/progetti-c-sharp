namespace pag83
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            string symbol;

            Console.Write("Insert the first number: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insert the second number: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insert the symbol of the opation: ");
            symbol = Console.ReadLine();

            switch(symbol)
            {
                case "+":
                    Console.WriteLine(n1 + n2);
                    break;

                case "-":
                    Console.WriteLine(n1 - n2);
                    break;

                case "*":
                    Console.WriteLine(n1 * n2);
                    break;

                case "/":
                    Console.WriteLine((double) n1 / n2);
                    break;

                default:
                    Console.WriteLine("Symbol gived is not known");
                    break;
            }
        }
    }
}