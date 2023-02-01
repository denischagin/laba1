namespace laba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double s, k;

            s = 5;
            Console.WriteLine($"s = {s}");

            s = 57;
            Console.WriteLine($"s = {s}");

            s = 6;
            Console.WriteLine($"s = {s}");

            s *= -5.2;
            Console.WriteLine($"s = {s}");

            s = 0;
            Console.WriteLine($"s = {s}");

            s = -7.5;
            Console.WriteLine($"s = {s}");

            s *= 2;
            Console.WriteLine($"s = {s}");

            s = 45;
            Console.WriteLine($"s = {s}");

            s = -25;
            Console.WriteLine($"s = {s}");

            Console.WriteLine($"Введите k: ");
            k = Convert.ToDouble(Console.ReadLine());
            s += k;
            Console.WriteLine($"s = {s}");
        }
    }
}