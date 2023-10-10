namespace pag114
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            fare la media dei voti di uno studente
            non si sa quanti voti abbia ricevuto
            stoppare l'input quando un voto e' uguale a 0
             */
            double voto = 0;
            double somma = 0;
            int i = 0;
            do
            {
                Console.Write("inserisci il voto e premi invio (per fermare digitare 0): ");
                voto = Convert.ToDouble(Console.ReadLine());
                i++;
                somma += voto;
            } while(voto != 0);

            double media = somma / (i-1);
            Console.WriteLine($"la media dei voti e': {media}");




        }   
    }
}