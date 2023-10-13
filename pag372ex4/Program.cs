namespace pag372ex4
{
    internal class Program
    {
        //soluzione complicata bhooo
        //creo una funzione che prende in input una str per poter cambiare la richiesta all'utente 
        /*
        static int[] AskTime(string time)
        {
            //creo un array di str
            string[] timeStr;
            //creo un array di interi di grandezza 3
            int[] timeInt = new int[3];

            //chiedo in input l'orario (e quale orario grazie alla stringa che viene chiesta quando si chiama la funzione) dicendo all'utente di separare ore minuti e secondi con ":"
            Console.Write($"insert the {time} time with this format (hh:mm:ss): ");
            //immetto nell'array l'input dell'utente che viene diviso in un'array dalla funzione .split(":")
            //ex. input -> "15:39:20" viene trasformato e immagazzinato come string[] array = {"15", "39", "20"};
            timeStr = Console.ReadLine().Split(":");

            //creo un ciclo for che giri per la lunghezza dell'array di stringhe
            for(int i = 0; i < timeStr.Length; i++)
            {
            //la funzione switch serve a smistare in base al'indice quale operazione il valore deve subire
                switch(i)
                {
                    //per il valore nel primo indice nell'array
                    case 0:
                        //si prende l'array di interi e nella posizione 0 ci si mette dentro il valore dell'indice 0 dell'array di stringhe trasformato in int e poi moltiplicato per 3600 (trsaformazione da h a s)
                        timeInt[i] = (3600 * (Convert.ToInt32(timeStr[i])));
                        break;
                    case 1:
                        //si prende l'array di interi e nella posizione 1 ci si mette dentro il valore dell'indice 1 dell'array di stringhe trasformato in int e poi moltiplicato per 60 (trsaformazione da m a s)
                        timeInt[i] = (60 * (Convert.ToInt32(timeStr[i])));
                        break;
                    case 2:
                        //si prende l'array di interi e nella posizione 0 ci si mette dentro il valore dell'indice 0 dell'array di stringhe trasformato in int
                        timeInt[i] = (Convert.ToInt32(timeStr[i]));
                        break;
                }

            }
        //restituisco l'array di int all'utente
            return timeInt;
            
        }
        */
        static void Main(string[] args)
        {
            //soluzione semplice
            int hour, min, sec, sum1, sum2, diff;

            //chiedo in input le ore del primo orario
            Console.WriteLine("insert the hour of the first time: ");
            hour = Convert.ToInt32(Console.ReadLine());

            //chiedo in input i minuti del primo orario
            Console.WriteLine("insert the minutes of the first time: ");
            min = Convert.ToInt32(Console.ReadLine());

            //chiedo in input i minuti del primo orario
            Console.WriteLine("insert the second of the first time: ");
            sec = Convert.ToInt32(Console.ReadLine());

            //calcolo la somma in secondi del primo orario, trasformando le ore in secondi moltiplicando il valore per 3600, e trasformo i minuti in secondi moltiplicando per 60
            sum1 = (sec + min * 60 + hour * 3600);

            //chiedo in input le ore del secondo orario
            Console.WriteLine("\ninsert the hour of the second time: ");
            hour = Convert.ToInt32(Console.ReadLine());

            //chiedo in input i minuti del secondo orario
            Console.WriteLine("insert the minutes of the second time: ");
            min = Convert.ToInt32(Console.ReadLine());

            //chiedo in input i minuti del secondo orario
            Console.WriteLine("insert the second of the second time: ");
            sec = Convert.ToInt32(Console.ReadLine());

            //calcolo la somma in secondi del secondo orario, trasformando le ore in secondi moltiplicando il valore per 3600, e trasformo i minuti in secondi moltiplicando per 60
            sum2 = (sec + min * 60 + hour * 3600);
          
            //calcolo la differenza tra il primo e il secondo orario, trasformando il risultato in un valore assoluto evitando risultati negativi
            diff = Math.Abs(sum1 - sum2);

            Console.WriteLine($"the difference is {diff}");
            


            /*
            int hour, min, sec, sum1, sum2, diff;
            string[] time1s, time2s;
            int[] time1i = new int[3];

            Console.WriteLine("insert the first time with this format (hh:mm:ss): ");
            time1s = Console.ReadLine().Split(":");

            for (int i = 0; i < time1s.Length; i++)
            {
                switch(i)
                {
                    case 0:
                        time1i[i] = (360 * (Convert.ToInt32(time1s[i])));
                        break;
                    case 1:
                        time1i[i] = (60 * (Convert.ToInt32(time1s[i])));
                        break;
                    case 2:
                        time1i[i] = (Convert.ToInt32(time1s[i]));
                        break;
                }
                
            }

            Console.WriteLine("insert the first time with this format (hh:mm:ss): ");
            time1s = Console.ReadLine().Split(":");

            for(int i = 0; i < time1s.Length; i++)
            {
                switch(i)
                {
                    case 0:
                        time1i[i] = (360 * (Convert.ToInt32(time1s[i])));
                        break;
                    case 1:
                        time1i[i] = (60 * (Convert.ToInt32(time1s[i])));
                        break;
                    case 2:
                        time1i[i] = (Convert.ToInt32(time1s[i]));
                        break;
                }

            }
            */

            //soluzione complicata
            /*
            int[] Time_list_1 = AskTime("first");
            int[] Time_list_2 = AskTime("second");
            //int[] Time_list_1 = {7200, 60, 20};
            //int[] Time_list_2 = {2880, 60, 20};

            int Time_1 = 0, Time_2 = 0, diff = 0;

            for( int i = 0; i < Time_list_1.Length; i++)
            {
                Time_1 += Time_list_1[i];
            }

            for(int i = 0; i < Time_list_1.Length; i++)
            {
                Time_2 += Time_list_2[i];
            }

            Console.WriteLine($"{Time_1} {Time_2}");

            Console.WriteLine($"the time difference is: {diff}");
            */










        }
    }
}
