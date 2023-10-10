namespace pag110
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             genera numeri casuali (0-50) finche' non viene visualizzato lo 0
             */
            Random rd = new Random();
            bool cond = true;
            int random_num;

            while(cond)
            {
                random_num = rd.Next(0, 51);
                if(random_num == 0)
                {
                    cond = false;
                    Console.WriteLine(random_num);
                }
                else
                {
                    Console.WriteLine(random_num);
                }
            }
        }

    }
}