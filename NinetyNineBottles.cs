using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PALProgramming {
    class NinetyNineBottles {

        // this is the constructor, or entry point into the object. you call this using "NinetyNineBottles nn =  new NinetyNineBottles({number});".
        // the number param is optional since "= 0" is after it. If the number is greater than zero (the default), it sets the number property to the number you're passing in
        public NinetyNineBottles(int _number = 0) {
            if (_number > 0) {
                Number = _number;
            }
        }

        // this property holds the number of bottles of beer on the wall. = 99 means it defaults to 99. get/set means it can be read and written.
        public int Number { get; set; } = 99;


        // this property is readonly since it only has get. it returns the halfway point to the Number property.
        public decimal HalfWayThere {
            get {
                return Math.Ceiling(Convert.ToDecimal(Number / 2));
            }
        }

        // This runs the function from Program.cs but instead runs it {Number} Times and the Halfway there is automatically calculated by the Number property
        public void Run99() {

            // for statement = (int variable_name = {number_to_start_at}?; {variable_name} <= (less than or equal) or >= (greater than or equal, if going downwards) {number_to_end_at}; variable_name{++ to add, -- to minus}) - then every for has brackets to contain the code - {}
            for (int i = Number; i >= 0; i--) {
                // if ({variable} == (equals) something) - brackets contain the contents of if statement {}
                if (i == HalfWayThere) {
                    // using string interpolation to insert the number stored in {i} into the bottles of beer jawn
                    Console.WriteLine($"{i} bottles of beer on the wall, almost halfway!");
                } else {
                    Console.WriteLine($"{i} bottles of beer on the wall, {i} bottles of beer, take one down and pass it around, {(i == 0 ? 0 : i - 1)} bottles of beer on the wall");
                }
            }
            Console.ReadLine();

        }

    }
}
