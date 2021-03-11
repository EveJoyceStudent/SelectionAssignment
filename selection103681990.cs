using System;
namespace week2
{
    class Program
    {
        static void Main(string[] args)
        {
//            Exercise 1
// Create C# for the following:
// A program receives a person's age as input from the user. If the input is greater than 17, output "Legally adult age", otherwise output "Legally not adult age"

        Console.WriteLine("Please input your age");
        int age = Convert.ToInt32(Console.ReadLine());
        if(age>17){
            Console.WriteLine("Legally adult age");
        } else {
            Console.WriteLine("Legally not adult age");
        }

// A program receives the gender of a person (male or female) and also their age. The program should output accordingly, "M/F is an adult/not an adult"
        Console.WriteLine("Please input your gender");
        string gender = Console.ReadLine();
        Console.WriteLine("Please input your age");
        int age2 = Convert.ToInt32(Console.ReadLine());
        if(age2>17){
            Console.WriteLine(gender+" is an adult");
        } else {
            Console.WriteLine(gender+" is not an adult");
        }

// A program receives two numbers. If the numbers add up to greater code than 10, output "Sum of numbers is greater than 10". If the numbers add up to less than 10, output "Sum of numbers is less than 10". What happens if the numbers add up to 10?
        Console.WriteLine("Please input two numbers");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        if(a+b>10){
            Console.WriteLine("Sum of numbers is greater than 10");
        } else {
            if(a+b<10){
                Console.WriteLine("Sum of numbers is less than 10");
            }
        }

// Nested Selection

// Exercise 2

// Create this login process in C# -
// Wait for user to enter username and password
// Check that the username exists
// If the username exists
// Check that the password is correct
// if password is correct, tell the user "login successful"
// if password is incorrect, tell the user "login unsuccessful"
// If the username doesn't exist
// tell the user "login unsuccessful"
            Console.WriteLine("Please input username");
            string username=Console.ReadLine();
            Console.WriteLine("Please input password");
            string password=Console.ReadLine();
            if(username=="exists"){
                if(password=="correct"){
                    Console.WriteLine("login successful");
                } else {
                    Console.WriteLine("login unsuccessful");
                }
            } else {
                Console.WriteLine("login unsuccessful");
            }

// Fix up the algorithm from exercise 1-3 to handle the situation where the two numbers add up to 10. Output "Sum of numbers is equal to 10"
            Console.WriteLine("Please input two numbers");
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            if(a2+2>10){
                Console.WriteLine("Sum of numbers is greater than 10");
            }
            if(a2+b2<10){
                Console.WriteLine("Sum of numbers is less than 10");
            }
            if(a2+b2==10){
                Console.WriteLine("Sum of numbers is equal to 10");
            }
        }
    }
}
