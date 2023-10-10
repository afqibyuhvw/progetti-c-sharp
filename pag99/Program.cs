namespace pag99
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            bassa stagione:
            sigola: 40
            doppia: 75
            tripla: 110

            alta stagione:
            singola: 50
            doppia: 90
            tripla: 140

            per soggiorni superiori a 7 giorni si applica scondo del 5%
            input:
            periodo (A, B)
            giorni di prenotamento
            type camera (S, D, T)
             */

            const double LOW_S = 40, LOW_D = 75, LOW_T = 110;
            const double HIGH_S = 50, HIGH_D = 90, HIGH_T = 140;
            const double VOUCER = 0.05;
            double days, price;
            string period, type_room;

            Console.Write("Insert the period (B or A): ");
            period = Console.ReadLine();

            Console.Write("Insert the number of days you will stay: ");
            days = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insert the type of the room (S, D, T): ");
            type_room = Console.ReadLine();

            switch(period)
            {
                case "B":
                    switch(type_room)
                    {
                        case "S":
                            if(days >= 7)
                            {
                                price = days * (LOW_S - (LOW_S * VOUCER));
                                Console.WriteLine($"you will spend {price}");
                            }
                            else
                            {
                                price = days * LOW_S;
                                Console.WriteLine($"you will spend {price}");
                            }
                            break;

                        case "D":
                            if(days >= 7)
                            {
                                price = days * (LOW_D - (LOW_D * VOUCER));
                                Console.WriteLine($"you will spend {price}");
                            }
                            else
                            {
                                price = days * LOW_D;
                                Console.WriteLine($"you will spend {price}");
                            }
                            break;

                        case "T":
                            if(days >= 7)
                            {
                                price = days * (LOW_T - (LOW_T * VOUCER));
                                Console.WriteLine($"you will spend {price}");
                            }
                            else
                            {
                                price = days * LOW_T;
                                Console.WriteLine($"you will spend {price}");
                            }
                            break;

                    }
                    break;
                case "A":
                    case "S":
                        if(days >= 7)
                        {
                            price = days * (HIGH_S - (HIGH_S * VOUCER));
                            Console.WriteLine($"you will spend {price}");
                        }
                        else
                        {
                            price = days * HIGH_S;
                            Console.WriteLine($"you will spend {price}");
                        }
                        break;

                    case "D":
                        if(days >= 7)
                        {
                            price = days * (HIGH_D - (HIGH_D * VOUCER));
                            Console.WriteLine($"you will spend {price}");
                        }
                        else
                        {
                            price = days * HIGH_D;
                            Console.WriteLine($"you will spend {price}");
                        }
                        break;

                    case "T":
                        if(days >= 7)
                        {
                            price = days * (HIGH_T - (HIGH_T * VOUCER));
                            Console.WriteLine($"you will spend {price}");
                        }
                        else
                        {
                            price = days * HIGH_T;
                            Console.WriteLine($"you will spend {price}");
                        }
                        break;

            }
        }

        
        
    }
}