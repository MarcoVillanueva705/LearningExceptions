using System;

namespace LearningExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new Exception("Custom Message");
            }
            catch (Exception ex)

            {
                Console.WriteLine(ex);
            }
        }
    }
}
