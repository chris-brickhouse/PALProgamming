using System;
using System.Xml;

namespace PALProgramming {
    class Program {

        // the Main() function is the entryway to the component. string[] is the array of arguments you can pass if running this via Windows command prompt.
        static void Main(string[] args) {
            // TODO: this is a todo
            // FIXME: this is a fixme

            // simple hello world write to console
            Console.WriteLine("Hello World!");
            Console.ReadLine();

            // make the message into a string variable than we then output
            string my_string = "Hello World, this is my first C# app! ";
            Console.WriteLine(my_string);
            Console.ReadLine();

            // run 99 bottles function, on line 62
            NintyNineBottles();

            // do we have arguments? if yes, output the argument
            if (args.Length > 0) {
                Console.WriteLine(args[0]);
                Console.ReadLine();
            }

            // cause an error by trying to divide by zero, and catching said error to deal with gracefully
            try {
                int error_zero = 0;
                int error = 100 / error_zero;
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }            

            // input - have user enter name
            Console.WriteLine("Enter Your Name:");
            string user_name = Console.ReadLine();
            Console.ReadLine();

            // insert the input name into a sentence
            string my_string_c = $"hello there, PAL student ({user_name})";
            Console.WriteLine(my_string_c);
            Console.ReadLine();

            // mash two sentences together using string interpolation - $"{variable_name} some text"; (dollar sign, quotes, variables inside brackets)
            string first_sentence = "This is the first part";
            string second_sentence = "This is the second part";
            Console.WriteLine($"{first_sentence} - {second_sentence}");
            Console.ReadLine();

            // does the username the user input have a space in it? if yes, reverse it and put a comma in it. reversed_name[0] is first name since arrays are 0 based, reversed_name[1] is last name
            bool has_space = user_name.IndexOf(" ") > -1;
            string[] reversed_name = user_name.Split(" ");
            Console.WriteLine(has_space ? $"{reversed_name[1]}, {reversed_name[0]}" : user_name);
            Console.ReadLine();

            // replace the space in the username gathered with a period
            string period_name = user_name.Replace(" ", ".");
            Console.WriteLine(period_name);
            Console.ReadLine(); 

        }

        static void NintyNineBottles() {

            // for statement = (int variable_name = {number_to_start_at}?; {variable_name} <= (less than or equal) or >= (greater than or equal, if going downwards) {number_to_end_at}; variable_name{++ to add, -- to minus}) - then every for has brackets to contain the code - {}
            for (int i = 99; i >= 0; i--) {
                // if ({variable} == (equals) something) - brackets contain the contents of if statement {}
                if (i == 50) {
                    // using string interpolation to insert the number stored in {i} into the bottles of beer jawn
                    Console.WriteLine($"{i} bottles of beer on the wall, almost halfway!");
                } else {
                    Console.WriteLine($"{i} bottles of beer on the wall");
                }               
            }
            Console.ReadLine();
        }
    }
}
