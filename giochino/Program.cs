using System;
using System.IO;
namespace Mony
{
    internal class Program
    {
        //ho aggiunto un commento dio madonna
        //static string soldi_sal = @"E:\OMADA\salvataggio.txt";
        //static string[] salvataggio = File.ReadAllLines(soldi_sal);
        /*int.Parse(salvataggio[0])*/

        //si impostano i prezzi delle aziende
        static int prezzo_amp = 300, prezzo_veloc = 600, prezzo_com = 100, prezzo_kog = 1021;
        //si impostano i valori true e false che dicono se l'utente ha gia' aquistato quella determinata azieda
        static bool amp = false, veloc = false, com = false, kog = false;

        static void inizio(ref int soldi)
        {
            //imposto la posizione del testo
            Console.SetCursorPosition(10, 0);
            //imposto il colore del riquadro
            Console.BackgroundColor = ConsoleColor.Green;
            //imposto il colore del testo 
            Console.ForegroundColor = ConsoleColor.Black;
            //imposto il testo
            Console.WriteLine($"{soldi}$");

            //imposto la posizione della 1 riga
            Console.SetCursorPosition(70, 0);
            //imposto il colore dello sfondo 
            Console.BackgroundColor = ConsoleColor.Blue;
            //imposto il colore del testo
            Console.ForegroundColor = ConsoleColor.White;
            //printo la 1 riga
            Console.WriteLine("+------------+-------+");

            //imposto la posizione della 2 riga
            Console.SetCursorPosition(70, 1);
            //printo la 2 riga
            Console.WriteLine("|  Funzioni  | Tasti |");

            Console.SetCursorPosition(70, 2);
            Console.WriteLine("+------------+-------+");

            Console.SetCursorPosition(70, 3);
            Console.WriteLine("| Soldi      |   x   |");

            Console.SetCursorPosition(70, 4);
            Console.WriteLine("| Upgrade    |   u   |");

            Console.SetCursorPosition(70, 5);
            Console.WriteLine("| Industrie  |   i   |");

            Console.SetCursorPosition(70, 6);
            Console.WriteLine("+------------+-------+");

            //imposto la posizione del cursore dell'utente
            Console.SetCursorPosition(1, 2);
            //imposto lo sfondo della console
            Console.BackgroundColor = ConsoleColor.Black;
            //imposto il colore del testo che scrivera' l'utente
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }
        //creo la funzione 'soldoni' che si attivera' quando l'utente digita 'x'
        static void soldoni(ref int incremento, ref int soldi)
        {
            //imposto la posizione del cursore dell'utente
            Console.SetCursorPosition(1, 2);
            //imposto il colore della console
            Console.BackgroundColor = ConsoleColor.Black;
            //imposto il colore del testo ???
            Console.ForegroundColor = ConsoleColor.DarkRed;
            //pulisco la console dal testo che l'utente ha appena scritto
            Console.Clear();
            //prendo la var soldi e la sommo alla variabile incremento
            soldi += incremento;
            //salvataggio[0] = soldi.ToString();
        }
        //imposto la funzione 'upgrade' che si attivera' quando l'utente digita 'u'
        static void upgrade(ref int incremento, ref int prezzo_incremento, ref int livello, ref int soldi)
        {
            string response;
            int soldi_finti = soldi, prezzo_incremento_prima = prezzo_incremento, aggiunta_incremento = 5;
            //imposto la posizione del testo
            Console.SetCursorPosition(65, 8);
            //imposto il colore dello sfondo
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            //imposto il colore del testo
            Console.ForegroundColor = ConsoleColor.White;
            //testo 1 del riquadro
            Console.WriteLine($"Upgrade lvl {livello} costo:{prezzo_incremento}$ incremento di {aggiunta_incremento}$ al guadagno");
            //imposto la posizione del testo 2 del riquadro
            Console.SetCursorPosition(65, 9);
            //testo 2 del riquadro
            Console.WriteLine("digita 'y' per comprare l'upgrade o 'n' per annullare");

            //imposto la posizione del cursore dell'utente
            Console.SetCursorPosition(65, 10);
            //imposto lo sfondo della console su black
            Console.BackgroundColor = ConsoleColor.Black;
            //imposto il testo della console su white
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            //chiedo all'utente cosa vuole fare 'y' oppure 'n'
            response = Console.ReadLine();

            //l'utente ha risposto 'y' e ha abbastanza soldi per l'upgrade
            if (response == "y" && soldi >= prezzo_incremento)
            {
                //si posiziona il cursore dell'utente???
                Console.SetCursorPosition(1, 2);
                //modifico la var soldi sottraendo il costo dell'upgrade
                soldi -= prezzo_incremento;
                //icremento di uno la var livello
                livello++;
                //moltiplico per 2 il valore della var prezzo incremento
                prezzo_incremento *= 2;
                //si aumenta l'incremento all'aggiunta incremento dell'upgrade
                incremento += aggiunta_incremento;
                //si aumenta l'aggiunta incremento che si avra' la prossima volta che si fa un'upgrade
                aggiunta_incremento += 5;

                //si imposta la posizione del testo di uscita
                Console.SetCursorPosition(65, 12);
                //si dice all'utente che l'operazione e' andata a buon fine
                Console.WriteLine("Upgrade acquistato, premere invio");

                //si imposta la posizione del cursore dell'utente
                Console.SetCursorPosition(98, 12);
                //si imposta il colore dello sfondo della console
                Console.BackgroundColor = ConsoleColor.Black;
                //si imposta il colore del testo che impostera' l'utente
                Console.ForegroundColor = ConsoleColor.DarkRed;
                //il programma aspetta l'invio dell'utente per proseguire
                Console.ReadLine();
            }
            //se la risposta dell'utente e' uguale a 'n'
            if (response == "n")
            {
                //imposta la posizione del testo
                Console.SetCursorPosition(65, 12);
                //si imposta il colore dello sfondo su nero
                Console.BackgroundColor = ConsoleColor.Black;
                //si imposta il colore del testo su rosso
                Console.ForegroundColor = ConsoleColor.DarkRed;
                //si dice all'utente che l'operazione e' stata annullata correttamente
                Console.WriteLine("Operazione annullata correttamente");

                //si imposta la posizione del cursore dell'utente
                Console.SetCursorPosition(99, 12);
                //si imposta il colore dello sfondo su nero
                Console.BackgroundColor = ConsoleColor.Black;
                //si imposta il colore del testo su rosso
                Console.ForegroundColor = ConsoleColor.DarkRed;
                //il programma aspetta l'invio dell'utente per proseguire
                Console.ReadLine();
            }
            //se l'input dell'utente non coincide con 'y' e 'n'
            if (response != "n" && response != "y")
            {
                //si imposta la posizione del testo che apparira' all'utente
                Console.SetCursorPosition(65, 12);
                //si imposta il colore dello sfondo su nero
                Console.BackgroundColor = ConsoleColor.Black;
                //si imposta il colore del testo su rosso
                Console.ForegroundColor = ConsoleColor.DarkRed;
                //si dici all'utente che ha sbagliato a scrivere
                Console.WriteLine("Hai sbagliato a scrivere coglione");

                //si imposta la posizione del cursore dell'utente
                Console.SetCursorPosition(98, 12);
                //si imposta il colore dello sfondo della console
                Console.BackgroundColor = ConsoleColor.Black;
                //si imposta il colore del testo dell'utente
                Console.ForegroundColor = ConsoleColor.DarkRed;
                //si aspetta che l'utente prema invio
                Console.ReadLine();

            }

            //se la risposta era 'y' ma l'utente non ha sufficienti soldi
            if (soldi_finti < prezzo_incremento_prima && response == "y")
            {
                //si imposta la posizione del testo
                Console.SetCursorPosition(65, 12);
                //si imposta il colore dello sfondo del testo
                Console.BackgroundColor = ConsoleColor.Black;
                //si imposta il colore del testo
                Console.ForegroundColor = ConsoleColor.DarkRed;
                //si dice all'utente che i soldi non bastano
                Console.WriteLine("I soldi non bastano");
                //si imposta la posizione del cursore dell'utente
                Console.SetCursorPosition(84, 12);
                //si imposta il colore della console
                Console.BackgroundColor = ConsoleColor.Black;
                //si imposta il colore del testo che scrive l'utente
                Console.ForegroundColor = ConsoleColor.DarkRed;
                //si aspetta che l'utente prema invio
                Console.ReadLine();


            }
            //si imposta lo sfondo su nero
            Console.BackgroundColor = ConsoleColor.Black;
            //si imposta il colore del testo dell'utente
            Console.ForegroundColor = ConsoleColor.White;
            //si aspetta che l'utente prema invio
            Console.Clear();
        }
        //si imposta la funzione imprese che si attivera' quando l'utente digitera' 'i'
        static void imprese(ref int incremento, ref int soldi)
        {
            //ogni volta che l'utente entra nella funzione imprese opz prende il valore True
            bool opz = true;
            string leggi;

            //si imposta la posizione del testo
            Console.SetCursorPosition(65, 8);
            //si imposta il colore dello sfondo del testo
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            //si imposta il colore del testo
            Console.ForegroundColor = ConsoleColor.White;
            //si printa il testo
            Console.WriteLine("Aziende acquistabili:");

            //si imposta la pozisione del testo
            Console.SetCursorPosition(65, 9);
            //si imposta lo sfondo del testo
            Console.BackgroundColor = ConsoleColor.Black;
            //si imposta il colore del testo
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            //si printa il nome dell'azienda
            Console.WriteLine("Amplison 300$ (+40$ ogni x)");

            Console.SetCursorPosition(65, 10);
            Console.WriteLine("Veloci Racing 600$ (+80$ ogni x)");

            Console.SetCursorPosition(65, 11);
            Console.WriteLine("Comunismo&Co 100$ (+20$ ogni x)");

            Console.SetCursorPosition(65, 12);
            Console.WriteLine("KogRace 1021$ (+569$ ogni x)");
            //finche' opz e' true il loop continua
            while (opz == true)
            {
                //si imposta la posizione del testo
                Console.SetCursorPosition(65, 14);
                //si imposta il colore dello sfondo del testo
                Console.BackgroundColor = ConsoleColor.White;
                //si imposta il colore del testo
                Console.ForegroundColor = ConsoleColor.DarkRed;
                //si printa il testo
                Console.WriteLine("Scrivi il nome dell'azienda che vuoi");

                //si imposta la posizione del testo
                Console.SetCursorPosition(65, 15);
                //si printa il testo
                Console.WriteLine("acquistare o '<' per annullare:");

                //si imposta la posizione del cursore dell'utente
                Console.SetCursorPosition(65, 17);
                //si imposta il colore dello sfondo del testo dell'utente
                Console.BackgroundColor = ConsoleColor.Red;
                //si imposta il colore del testo dell'utente
                Console.ForegroundColor = ConsoleColor.White;
                //si aspetta la risposta dell'utente

                leggi = Console.ReadLine();
                switch (leggi)
                {
                    //se l'utente ha scritto "Amplison" parte la funzione amplison
                    case "Amplison":
                        amplison(ref opz, ref incremento, ref soldi);
                        break;

                    //se l'utente ha scritto "Veloci Racing" parte la funzione Veloci Racing
                    case "Veloci Racing":
                        veloci(ref opz, ref incremento, ref soldi);
                        break;

                    //se l'utente ha scritto "Comunismo&Co" parte la funzione Comunismo&Co
                    case "Comunismo&Co":
                        comunismo(ref opz, ref incremento, ref soldi);
                        break;

                    //se l'utente ha scritto "KogRace" parte la funzione KogRace
                    case "KogRace":
                        kograce(ref opz, ref incremento, ref soldi);
                        break;

                    //se l'utente ha annullato opz diventa false
                    case "<":
                        opz = false;
                        break;
                    //se l'utente non ha scritto nulla delle cose precedenti
                    default:
                        //si imposta la posizione del testo
                        Console.SetCursorPosition(65, 19);
                        //si imposta il colore dello sfondo del testo
                        Console.BackgroundColor = ConsoleColor.Black;
                        //si imposta il colore del testo
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        //testo in output
                        Console.WriteLine("Hai sbagliato a scrivere");

                        //si imposta la posizione del cursore dell'utente
                        Console.SetCursorPosition(89, 19);
                        //si aspetta che l'utente prema invio
                        Console.ReadLine();

                        Console.SetCursorPosition(65, 19);
                        Console.WriteLine("                        "); 
                        Console.SetCursorPosition(65, 17);
                        Console.WriteLine("                              "); 
                        break;
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
        }
        static void amplison(ref bool opz, ref int incremento, ref int soldi)
        {
            opz = false;
            Console.SetCursorPosition(65, 19);
            if (amp == true)
            {
                Console.WriteLine("Possiedi già questa azienda");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(92, 19);
                Console.ReadLine();
                Console.SetCursorPosition(1, 2);
                opz = false;
            }
            if (soldi >= prezzo_amp && amp == false)
            {
                soldi -= prezzo_amp;
                incremento += 40;
                amp = true;
                Console.WriteLine("AZIENDA ACQUISTATA");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(83, 19);
                Console.ReadLine();
                Console.SetCursorPosition(1, 2);
                opz = false;
            }
            if (soldi < prezzo_amp && amp == false)
            {
                Console.WriteLine("Non hai abbastanza soldi");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                opz = false;
                Console.SetCursorPosition(1, 2);
                Console.ReadLine();
            }
        }
        static void veloci(ref bool opz, ref int incremento, ref int soldi)
        {
            Console.SetCursorPosition(65, 19);
            if (veloc == true)
            {
                Console.WriteLine("Possiedi già questa azienda");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(92, 19);
                Console.ReadLine();
                Console.SetCursorPosition(1, 2);
                opz = false;
            }
            if (soldi >= prezzo_veloc && veloc == false)
            {
                soldi -= prezzo_veloc;
                incremento += 80;
                veloc = true;
                Console.WriteLine("AZIENDA ACQUISTATA");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(83, 19);
                Console.ReadLine();
                Console.SetCursorPosition(1, 2);
                opz = false;
            }
            if (soldi < prezzo_amp && veloc == false)
            {
                Console.WriteLine("Non hai abbastanza soldi");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                opz = false;
            }
            Console.SetCursorPosition(1, 2);
            Console.ReadLine();
        }
        static void comunismo(ref bool opz, ref int incremento, ref int soldi)
        {
            Console.SetCursorPosition(65, 19);
            if (com == true)
            {
                Console.WriteLine("Possiedi già questa azienda");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(92, 19);
                Console.ReadLine();
                Console.SetCursorPosition(1, 2);
                opz = false;
            }
            if (soldi >= prezzo_com && com == false)
            {
                soldi -= prezzo_com;
                incremento += 20;
                com = true;
                Console.WriteLine("AZIENDA ACQUISTATA");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(83, 19);
                Console.ReadLine();
                Console.SetCursorPosition(1, 2); ;
                opz = false;
            }
            if (soldi < prezzo_com && com == false)
            {
                Console.WriteLine("Non hai abbastanza soldi");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                opz = false;
            }
            Console.SetCursorPosition(1, 2);
            Console.ReadLine();
        }
        static void kograce(ref bool opz, ref int incremento, ref int soldi)
        {
            Console.SetCursorPosition(65, 19);
            if (kog == true)
            {
                Console.WriteLine("Possiedi già questa azienda");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(92, 19);
                Console.ReadLine();
                Console.SetCursorPosition(1, 2); ;
                opz = false;
            }
            if (soldi >= prezzo_kog && kog == false)
            {
                soldi -= prezzo_kog;
                incremento += 569;
                kog = true;
                Console.WriteLine("AZIENDA ACQUISTATA");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(83, 19);
                Console.ReadLine();
                Console.SetCursorPosition(1, 2);
                opz = false;
            }
            if (soldi < prezzo_kog && kog == false)
            {
                Console.WriteLine("Non hai abbastanza soldi");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                opz = false;
            }
            Console.SetCursorPosition(1, 2);
            Console.ReadLine();
        }
        static void Main()
        {
            int incremento = 10, prezzo_incremento = 25, livello = 1, soldi = 0;

            while (true)
            {
                inizio(ref soldi);
                switch (Console.ReadLine())
                {
                    case "x":
                        soldoni(ref incremento, ref soldi);
                        break;


                    case "u":
                        upgrade(ref incremento, ref prezzo_incremento, ref livello, ref soldi);
                        break;


                    case "i":
                        imprese(ref incremento, ref soldi);
                        break;







                }
            }
        }

    }
}
