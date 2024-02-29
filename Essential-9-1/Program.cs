

    
namespace Essential9_1
{
    class Program
    {
        static int Sum(int left, int right) => left + right;
        static int Sub(int left, int right) => left - right;

        static int Mul(int left, int right) => left * right;
        static int Div(int left, int right) => right != 0 ? left / right : throw new DivideByZeroException();

        static void Main()
        {

            Console.WriteLine(Sum(1, 2));
            Console.WriteLine(Sub(3, 2));
            Console.WriteLine(Mul(3, 3));
            Console.WriteLine(Div(4, 2));
            Console.WriteLine(Div(1, 0));

            Console.ReadKey();

        }
    }
}