namespace pag75
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;

            Console.Write("Insert the name of the persone: ");
            name = Console.ReadLine();

            Console.Write("Insert the age of the persone: ");
            age = Convert.ToInt32(Console.ReadLine());

            if(age >= 18)
            {
                Console.WriteLine($"{name} has {age}, so he's overage!");
            }
            else
            {
                Console.WriteLine($"{name} has {age}, so he's underage!");
            }
        }
    }
}