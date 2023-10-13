namespace pag372ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Uno studente ha effettuato tre prove ottenendo voti  compresi tra 1 e 10.
            Scrivi un programma che calcoli la media dei voti e li visualizzi.
             */
            double a, b, c, media;

            Console.Write("Inserisci il primo voto: ");
            a = Double.Parse(Console.ReadLine());

            Console.Write("Inserisci il secondo voto: ");
            b = Double.Parse(Console.ReadLine());

            Console.Write("Inserisci il terzo voto: ");
            c = Double.Parse(Console.ReadLine());

            media = (a + b + c) / 3;

            Console.WriteLine(String.Format("la media dei voti {0}, {1}, {2}. e': {3}", a, b, c, media));
        }
    }
}