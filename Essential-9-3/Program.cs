namespace Essential_9_3
{
    delegate double AverageDelegate(int a, int b, int c);
    class Program
    {

        static void Main()
        {
            double Avg1(int a, int b, int c) => Math.Round((((double)(a + b + c)) / 3),2);

            AverageDelegate Avg = (a, b, c) => Math.Round((((double)(a + b + c)) / 3), 2);

            Console.WriteLine("лямбда вираз"+Avg1(2, 2, 3));
            Console.WriteLine("Анонімна функція"+Avg(2, 2, 3));
        }
    }
}