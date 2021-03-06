﻿using System;

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
            //if you remove catch and run finally
            //db resource still disconnects and runs
            //finally message; app crashes
            catch (Exception)
            {
                Console.WriteLine("Exception Caught");
            }
            //will run whether anything was 'tried' or 'caught'
            //good for opening and closing resources
            //such as db connections
            finally
            {
                Console.WriteLine("Disconnecting Database...You Have My Sympathies...");
            }
            
        }
    }
}
