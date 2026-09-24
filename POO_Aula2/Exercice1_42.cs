namespace Lessons
{
    public class Exercice1_42
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"1,2,3,4");

            for (int i = 1; i <= 4; i++)
            {
                Console.Write($"{i}");

                if (i < 4)
                {
                    Console.Write($","); 
                }
            }
            
            Console.WriteLine();

            int a = 1;
            while (a <= 4)
            {
                Console.Write($"{a}");
                
                if (a < 4)
                {
                    Console.Write($","); 
                }
                
                a += 1;
            }
        }
    }
}

