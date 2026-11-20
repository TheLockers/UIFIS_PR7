namespace UIFIS_PR7
{
    /// <summary>
    /// Главный класс.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Точка входа.
        /// </summary>
        public static void Main()
        {
            static int Calc(int a, int b)
            {
                return a + b;
            }

            int total = Calc(1, 2);

            Console.WriteLine($"СУмма: {total}");

            string? userName = null;

            if (userName != null)
            {
                Console.WriteLine(userName.Length);
            }
            else
            {
                Console.WriteLine("Имя не задано");
            }
        }
    }
}