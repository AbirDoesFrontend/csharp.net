/* Numeric Data Types */
namespace Numeric_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int x = 10, y = 20, z = 30;
            Console.WriteLine(string.Join(", ", new[]{x.ToString(), y.ToString(), z.ToString()}));
            
            int age = 23;
            Console.WriteLine(age);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            long bigNumber = 9000000L;
            Console.WriteLine(bigNumber);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            double smallNumber = 50.55;
            Console.WriteLine(smallNumber);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);
            
            float precision = 0.00001f;
            Console.WriteLine(precision);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            decimal money = 14.99M;
            Console.WriteLine(money);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);
            
            Console.ReadLine();
        }
    }
}