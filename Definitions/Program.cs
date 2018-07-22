using System;

namespace Definitions
{
    class Program
    {
        static void Main(string[] args)
        {
            // A "statement" is a line of code that we can execute to perform a task
            // For example:
            // Assigning a value to a variable
            // Controlling the flow (logic) of the program

            string example1 = "my";
            string example2 = "cat";

            // An "expression" is a line of code that combines two values to return a new value.

            string combination = example1 + " " + example2;

            //An "operator" is the symbol we use to change those values.
            //For example: * + =

            int x = 3;
            int y = 2;
            int z = x + y;

            z.ToString();

            //an "operand" is the value changed by the operator.
            //For example, in this case the variable combination2 is an operand.

            string combination2 = combination + " is " + z + " years old.";

            Console.WriteLine(combination2);
            Console.ReadLine();
        }
    }
}
