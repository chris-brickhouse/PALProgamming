using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.IO;
using PALProgramming.Models;

namespace PALProgramming {

    class Program {

        // the Main() function is the entryway to the component. string[] is the array of arguments you can pass if running this via Windows command prompt.
        static void Main(string[] args) {
            // TODO: this is a todo
            // FIXME: this is a fixme

            // simple hello world write to console
            //Console.WriteLine("Hello World!");
            //Console.ReadLine();

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

            // mash two sentences together using string interpolation -$"{variable_name} some text"; (dollar sign, quotes, variables inside brackets)
            string first_sentence = "This is the first part";
            string second_sentence = "This is the second part";
            Console.WriteLine($"{first_sentence} - {second_sentence}");
            Console.ReadLine();

            // does the username the user input have a space in it ? if yes, reverse it and put a comma in it.reversed_name[0] is first name since arrays are 0 based, reversed_name[1] is last name
            bool has_space = user_name.IndexOf(" ") > -1;
            string[] reversed_name = user_name.Split(" ");
            Console.WriteLine(has_space ? $"{reversed_name[1]}, {reversed_name[0]}" : user_name);
            Console.ReadLine();

            // replace the space in the username gathered with a period
            string period_name = user_name.Replace(" ", ".");
            Console.WriteLine(period_name);
            Console.ReadLine();

            // split the first_sentence string variable into an array object and show how many spaces it has in it
            string[] s = first_sentence.Split(" ");
            int num_spaces = s.Length;
            Console.WriteLine($"'{first_sentence}' has {num_spaces} in it.");
            Console.ReadLine();

            // loop through every word in first_sentence
            for (int i = 0; i <= s.Length - 1; i++) {
                Console.WriteLine(s[i]);
            }
            Console.ReadLine();

            // create a new string array and a new list of strings, two ways of dealing with multiple strings in a single object that you can loop through
            string[] my_array = new string[] { "First", "Second", "Third" };
            List<string> my_string_list = new List<string>() { "First List Item", "Second List Item", "Third List Item" };

            // loop through my_array 
            foreach (string item in my_array) {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            // display length for my_array
            Console.WriteLine($"That array had {my_array.Length} items in it");
            Console.ReadLine();

            // loop through list of strings variable my_string_list
            foreach (string item in my_string_list) {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            // display length for list of strings my_string_list
            Console.WriteLine($"That array had {my_string_list.Count} items in it");
            Console.ReadLine();

            Console.WriteLine(string.Join(",", my_array));
            Console.ReadLine();

            // declare number variables 4 and 10
            int my_number = 4;
            int my_second_number = 10;

            // show sentence 4 + 10 = 14 - first part is formatting, second part does the math and formats
            Console.WriteLine($"{my_number} + {my_second_number} = {(my_number + my_second_number)}");
            Console.ReadLine();

            // doubles are numbers with decimals
            double my_third_number = 4.32;
            double my_fourth_number = .8;

            // show 4.32 * 80% (.8) = 3.456
            Console.WriteLine($"{my_third_number} * {(my_fourth_number * 100)}% = {Math.Round(my_third_number * my_fourth_number, 2)}");
            Console.ReadLine();

            // turn my_third_number negative, but then use math.abs to show without negative
            my_third_number = -4.32;
            Console.WriteLine($"{my_third_number} * {(my_fourth_number * 100)}% = {Math.Abs(Math.Round(my_third_number * my_fourth_number, 2))}");
            Console.ReadLine();

            // create array and list of int data types
            int[] my_int_array = new int[] { 1, 2, 3 };
            List<int> my_int_list = new List<int>() { 4, 5, 6 };

            // one way to sum items, += adds numbers together to get variable 'result'
            int result = 0;
            foreach (int item in my_int_array) {
                result += item;
            }
            Console.WriteLine(result);

            // alternatively - use .Sum() from Linq to add numbers together
            int new_result = my_int_list.Sum();
            Console.WriteLine(new_result);
            Console.ReadLine();

            // we opened windows explorer and created file c:\temp\test.txt filled with 8 lines of words seperated by commas like below:
            /* 
                this,is,text,from,the,external,file1
                this,is,text,from,the,external,file2
                this,is,text,from,the,external,file3
                this,is,text,from,the,external,file4
                this,is,text,from,the,external,file5
                this,is,text,from,the,external,file6
                this,is,text,from,the,external,file7
                this,is,text,from,the,external,file8
             */

            // this line reads all of those lines into the 'from_text' string variable
            string from_text = File.ReadAllText(@"c:\temp\test.txt");

            // output file contents
            Console.WriteLine(from_text);
            Console.ReadLine();

            // write to c:\temp\test1.txt
            string to_text = "write this to external file";
            File.WriteAllText(@"c:\temp\test1.txt", to_text);


            // split the file contents into 8 lines
            string[] next_text = from_text.Split(Environment.NewLine);

            // loop each line
            foreach (string line in next_text) {

                // split each line by commas
                string[] split_line = line.Split(",");

                // display each item in comma list
                foreach (string item in split_line) {
                    Console.WriteLine(item);
                }
            }
            Console.ReadLine();

            // ACTION: right click on the project (PALProgramming) and click "add  --> class". Call it "NinetyNineBottles.cs". Go into the file after created and follow along from there

            // call the object we created with whatever number (I used 45), it will run it that many times
            // put a breakpoint on the nn.Run99 so you can see the properties of the 'nn' object
            NinetyNineBottles nn = new NinetyNineBottles(45);
            nn.Run99();

            // this will show you what you passed in the number field and the halfway there point
            Console.WriteLine($"{nn.Number} - halfwaythere = {nn.HalfWayThere}");
            Console.ReadLine();

            // ACTION: right click on the project (PALProgramming) and click "add --> class". Call it "Bottle.cs". Go into the file and follow along from there.

            //create 'bl' variable which is a complex list, a list of the new Bottle class we created in Bottle.cs
            List<Bottle> bl = new List<Bottle>();

            // loop 99 times
            for (int i = 0; i <= 99; i++) {

                // get random type from BottleType enum - so either Beer, Soda, Juice, Water
                Array values = Enum.GetValues(typeof(BottleType));
                Random random = new Random();
                BottleType type = (BottleType)values.GetValue(random.Next(values.Length));

                // insert new Bottle object into 'bl' list with the number from i and the random type from above
                bl.Add(new Bottle() { Number = i, Type = type });
            }

            // since we looped 0-99 instead of 99-0, let's sort by number descending. Using Lambda expression (x => x.Number) is the ability to access properties of objects inside the list and use to sort, loop, etc
            bl = bl.OrderByDescending(x => x.Number).ToList();

            // loop bl and display the number and type
            foreach (Bottle b in bl) {
                Console.WriteLine($"{b.Number} bottles of {b.Type}, {b.Number} bottles of {b.Type}, take one down and pass it around, {b.Number - 1} bottle of {b.Type} on the wall");
            }
            Console.ReadLine();

            // a different way to loop - ForEach loops through every Bottle in the List of Bottles with the variable 'b' as a lambda expression
            bl.ForEach(b => {
                Console.WriteLine($"{b.Number} bottles of {b.Type}, {b.Number} bottles of {b.Type}, take one down and pass it around, {b.Number - 1} bottle of {b.Type} on the wall");
            });
            Console.ReadLine();

            // get the bottle with the Number propery equal 100. since it doesn't exist since we only added 99, it will use the Bottle object after the "??", which is called a null coalesce operator. if something is null, use a default instead.
            Bottle bottle = bl.Where(x => x.Number == 100).FirstOrDefault() ?? new Bottle() { Number = 0, Type = null };
            Console.WriteLine($"Bottle type for #{bottle.Number} - {bottle.Type}");
            Console.ReadLine();

            // create one of the child objects of Bottle, beer.
            Beer beer = new Beer() { Number = 700, ABV = "15%", Size = 40 };
            Console.WriteLine($"Bottle type for #{beer.Number} - {beer.Type} - {beer.ABV}");
            Console.ReadLine();

            // now, fun with dates. create a new date object
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            // format in various ways
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("MM/dd/yyyy hh:mm tt"));
            now = now.AddMonths(20);
            Console.WriteLine(now.Date.Year);
            Console.ReadLine();

            // create list of DateTime objects with the dates from this day from the previous 12 months
            List<DateTime> ld = new List<DateTime>();
            for (int i = 0; i <= 11; i++) {
                ld.Add(DateTime.Today.AddMonths(-i));
            }
            Console.WriteLine(string.Join(",", ld.ToArray()));
            Console.WriteLine(ld.First());
            Console.WriteLine(ld.Last());
            Console.ReadLine();

            // ACTION: right click project, click add new --> class, create PALModels.cs, then go into the class and follow along from there

            // once finished all of that, create instance of newly created dbcontext PALModels.
            PALModels db = new PALModels();

            // query the PALModels Users dbset for all treachers, return as a list of users. 
            List<Users> lu = (from u in db.Users where u.IsTeacher == true orderby u.LastName select u).ToList() ?? new List<Users>();

            // loop the above results and output the full name
            lu.ForEach(u => {
                Console.WriteLine($"{u.FullName} - {u.UserID}");
            });

            Console.Read();

            // try to select a user that doesn't exist 
            Users user = (from u in db.Users where u.UserID == 666 select u).FirstOrDefault() ?? new Users() { FirstName = "No", LastName = "User" };
            if (user.UserID == 0) {
                Console.WriteLine($"Does not exist");
            } else {
                Console.WriteLine($"{user.FullName} - {user.UserID}");
            }
            Console.Read();

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
