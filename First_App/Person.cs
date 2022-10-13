using System;
namespace First_App
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public int age;

        public Person( string aFirstName, string aLastName, int aAge)
        {
            firstName = aFirstName;
            lastName = aLastName;
            age = aAge;
        }
        //methods accessible for class/object
        public bool overAge()
        {
            if(age > 18)
            {
                return true;
            };
            return false;
        }
    }
}

