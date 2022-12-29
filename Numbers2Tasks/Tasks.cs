
namespace Numbers2Tasks
{
    public static class Tasks
    {
        public static void Task1(int n)
        {
            int result = 0;

            result = n%10;

            Console.WriteLine(result);
        }

        public static void Task2(int n)
        {
            int result = 0;
            int x = n / 10;
            int y = n % 10;
            result = (y * 10) + x;
            Console.WriteLine(result);
        }

        public static void Task3(int n)
        {
            int result = 0;
            int i = n / 10;
            int x = i % 10;
            int y = n % 10;
            int z = n / 100;
            result = (y * 100) +( x * 10 ) +z;
            
            Console.WriteLine(result);
        }

        public static void Task4(int n)
        {
            int result = 0;
            int x = n % 10;
            result = (x * 100) + (n / 10);


            Console.WriteLine(result);
        }
    }
}
