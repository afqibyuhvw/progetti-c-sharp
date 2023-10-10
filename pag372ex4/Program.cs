namespace pag372ex4
{
    internal class Program
    {
        static int[] AskTime(string time)
        {
            string[] timeStr;
            int[] timeInt = new int[3];
            Console.WriteLine($"insert the {time} time with this format (hh:mm:ss): ");
            timeStr = Console.ReadLine().Split(":");

            for(int i = 0; i < timeStr.Length; i++)
            {
                switch(i)
                {
                    case 0:
                        timeInt[i] = (3600 * (Convert.ToInt32(timeStr[i])));
                        break;
                    case 1:
                        timeInt[i] = (60 * (Convert.ToInt32(timeStr[i])));
                        break;
                    case 2:
                        timeInt[i] = (Convert.ToInt32(timeStr[i]));
                        break;
                }

            }
            return timeInt;
            
        }
        static void Main(string[] args)
        {
            /*
            int hour, min, sec, sum1, sum2, diff;

            Console.WriteLine("insert the hour of the first time: ");
            hour = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("insert the minutes of the first time: ");
            min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("insert the second of the first time: ");
            sec = Convert.ToInt32(Console.ReadLine());

            sum1 = (sec + min * 60 + hour * 360);

            Console.WriteLine("\ninsert the hour of the second time: ");
            hour = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("insert the minutes of the second time: ");
            min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("insert the second of the second time: ");
            sec = Convert.ToInt32(Console.ReadLine());

            sum2 = (sec + min * 60 + hour * 360);
          
            diff = Math.Abs(sum1 - sum2);

            Console.WriteLine($"the difference is {diff}");
            */


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











        }
    }
}