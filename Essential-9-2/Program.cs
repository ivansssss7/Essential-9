using System;

namespace Essential9_2
{
    delegate int MyDelegate();
    delegate double MyDelegatesArr(MyDelegate[] a);

    class Program
    {
        static void Main()
        {
            MyDelegate[] delegatesArray = new MyDelegate[5];

            Random rnd = new Random();
            for (int i = 0; i < delegatesArray.Length; i++)
            {
                int randomNumber = rnd.Next(1, 10);
                delegatesArray[i] = () => randomNumber;
                Console.WriteLine(randomNumber);
            }

            MyDelegatesArr averageDelegate = delegate (MyDelegate[] a)
            {
                double sum = 0;
                foreach (var del in a)
                {
                    sum += del();
                }
                return sum / a.Length;
            };

            double average = averageDelegate(delegatesArray);
            Console.WriteLine($"Average value: {average}");

            Console.ReadKey();
        }
    }
}
