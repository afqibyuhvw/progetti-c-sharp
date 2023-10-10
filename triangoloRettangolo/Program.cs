namespace triangoloRettangolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cate1, cate2, hypo, perimeter, area;

            Console.WriteLine("Insert the first cathetus: ");
            cate1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insert the second cathetus: ");
            cate2 = Convert.ToDouble(Console.ReadLine());

            hypo = Math.Sqrt(Math.Pow(cate1, 2) + Math.Pow(cate2,2));

            area = (cate1 * cate2)/2;
            perimeter = cate1 + cate2 + hypo;

            Console.WriteLine($"The perimeter of the right triangle is: {perimeter}.\nThe area of the right triangle is: {area}");

        }
    }
}