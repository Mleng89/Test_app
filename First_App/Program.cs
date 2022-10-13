/*
 * OLD format
using System;

namespace First_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
*/

/*NOTES:
 * 
 * Data types
 * 
 * string name = "Matthew";
 * char grade = 'A';
 * int age = 33;
 * 
 *  float,double,decimal (decimal int)
 * -less accurate to most accurate ->
 * 
 * double gpa = 3.8;
 * 
 * bool switchOn = false;
 * 
 * 
 * String templates:
 * $"Hello, my name is {name}, I am {age} years old."
 * 
 * METHODS:
 * string: 
 * .Length
 * .Contains --returns T/F
 * .IndexOf --does the string contain a certain value? and gives us index
 * .SubString(index where to start, how many indexes to go) --grab a part of the string
 * 
 * Math.
 * Abs() --absolute value
 * Pow(3,2) --power of = 9
 * .Sqrt() --square root
 * 
 * 
 * CREATING METHODS/FUNTION:
 * 
static void SayHi(string name)
{
    Console.WriteLine($"Hello {name}!");
    //return $"Hello {name}";
};

SayHi("Matthew");

 * RETURN VALUES 
static int cube(int num)
{
    return num * num * num;
}

Console.WriteLine(cube(2));


for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}


try
{
    Console.Write("Enter a number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter another number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(num1 / num2);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
*/

using First_App;
// OBJECT TESTING/METHOD TESTS
//Book book1 = new Book("Hitchhiker's Guide", "Douglas Adams", 600);
////book1.title = "Hitchiker's Guide";
////book1.author = "Douglas Adams";
////book1.pages = 500;

//Console.WriteLine(book1.title);
//Console.WriteLine(book1.pages);
Console.WriteLine(Person.peopleCount);
Person person1 = new Person("John", "Doe", 10);
Console.WriteLine(Person.peopleCount);
Person person2 = new Person("Julia", "Doe", 35);
Console.WriteLine(Person.peopleCount);

Console.WriteLine(person1.overAge()); //false
Console.WriteLine(person2.overAge()); //true
person1.Age = -1;
Console.WriteLine(person1.Age);
Console.WriteLine(person2.Age);

Console.ReadLine();