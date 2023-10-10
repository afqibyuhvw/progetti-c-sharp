namespace pag67
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Il costo di un biglietto di una discoteca e' di:
            15 euro per i minorenni 
            18 euro per i maggiorenni (compresa prima consumazione)
            7 euro consumazione aggiunta
            (meta' dei maggiorenni hanno comprato un drink aggiuntivo)
            inserisci in input:
            n maggiorenni, 
            n minorenni
            inserisci in output:
            n ragazzi tot, 
            incasso minorenni, 
            incasso maggiorenni 
            totale incassato
            */

            const int price_min = 15, price_mag = 18, price_drink = 7;
            int mny_min, mny_mag, tot_guys, mny_drink, tot_mny;
            int num_min, num_mag, num_drnk;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Insert the number of underage guys: ");
            num_min = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insert the number of overage guys: ");
            num_mag = Convert.ToInt32(Console.ReadLine());

            tot_guys = num_min + num_mag;

            mny_min = price_min * num_min;

            mny_mag = price_mag * num_mag;

            mny_drink = price_drink * (num_mag/2);

            tot_mny = mny_drink + mny_mag + mny_min;
            Console.WriteLine();
            Console.WriteLine($"the total number of guys is: {tot_guys}.");
            Console.WriteLine($"The underage guys gave us {mny_min}euro while the overage guys gave us {mny_mag}euro.");
            Console.WriteLine($"The total money we earned is {tot_mny}euro.");

            //Console.WriteLine(String.Format("the total number of guys is: {0}.", tot_guys));
            //Console.WriteLine(String.Format("The underage guys gave us {0}euro while the overage guys gave us {1}euro.", mny_min, mny_mag));
            //Console.WriteLine(String.Format("The total money we earned is {0}euro.", tot_mny));
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}