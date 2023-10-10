namespace pag372ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Determina l'area e il perimetro di un trapezio rettangolo, avendo come dati
            iniziali le misure delle basi e dell'altezza.

             */
            double B, b, h, l, perimeter, area;
            Console.WriteLine("Enter the major base: ");
            B = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the minor base: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the high: ");
            h = Convert.ToDouble(Console.ReadLine());

            l = Math.Pow((B - b), 2) + Math.Pow(h, 2);
            l = Math.Sqrt(l);

            perimeter = Math.Round(B + b + l + h, 2);
            
            area = Math.Round(((B + b) * h)/ 2, 2);

            Console.WriteLine($"The perimeter is: {perimeter}cm. \nThe area is: {area}cm^2.");


        }
    }
}