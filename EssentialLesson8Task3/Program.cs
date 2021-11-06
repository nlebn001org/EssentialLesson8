using System;

namespace EssentialLesson8Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            if (new Accountant().AskForBonus(Post.Manager, 200))
            {
                Console.WriteLine("Bonus was accepted.");
            }
            else
            {
                Console.WriteLine("Bonus was not accepted.");
            }
        }
    }
}
