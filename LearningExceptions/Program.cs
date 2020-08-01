using System;

namespace LearningExceptions
{
    class Person
    {
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
    }

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
