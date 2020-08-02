using System;

namespace LearningExceptions
{
    class Person
        //used snippet to create manually implemented property
    {
        private String name;

        public String Name
        {
            get { return name; }
            set
            {
            if (value == null)
                
                    throw new NullReferenceException("name must have a value");
                    name = value;
 
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var person = new Person();
                //person.Name is from class Person and Name is for get/set
                person.Name = null;
            }
            
        }
    }
}
