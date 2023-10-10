namespace pagina65
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            il costo unitario delle fotocopie in bianco e nero e' di 10centesimi di euro, quello delle fotocopie a colori e' di 80centesimi
            e quelle per rilegare un fascicolo di fotocopie e' di 1.30 euro. Letti in input il numero di fotocopie in bianco e nere e il numero di fotocopie a colori, calcola e stampa:
            -il numero di fotocopie totali aquistate;
            -il costo delle fotocopie in bianco e nero;
            -il costo delle fotocopie a colori;
            -il costo totale del fascicolo di fotocopie rilegato
            int num_bN, num_col, num_fas;
            Console.Write("inserisci il numero di fotocopie in bianco e nero, a colori, e di fascicoli separati da uno spazio: ");
            num_bN = Convert.ToInt32(());
            */

            const double price_one_bN = 0.80, price_one_col = 0.80, price_fas = 1.30;

            double[] count = new double[2];

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            for (int i = 0; i < 2; i++) {
                Console.Write("inserisci il numero di fotocopie in bianco e nero e di fotocopie a colori separati da un' invio: ");
                count[i] = Convert.ToDouble(Console.ReadLine()); 
            }

            int tot_copy = Convert.ToInt32(count[0] + count[1]);
            double price_bN_copy = count[0] * price_one_bN;
            double price_col_copy = count[1] * price_one_col;
            double total_price = price_bN_copy + price_col_copy + price_fas;

            
            Console.WriteLine();
            Console.WriteLine($"il numero totale di fotocopie e': {tot_copy}");
            Console.WriteLine($"il costo per le fotocopie in bianco e nero e': {price_bN_copy}euro");
            Console.WriteLine($"il costo per le fotocopie a colori e': {price_col_copy}euro");
            Console.WriteLine($"il costo totale e': {total_price}euro");
            Console.ResetColor();
            






        }
    }
}