using System;


namespace PetRecord
{
    // *
    // Handles list of errors 
    // *
    class ErrorList
    {
        // Prints error when the error is about the input being out of range.
        public static void InvalidInputError()
        {
            Console.WriteLine("\nError 1: Invalid Input. The input did not match to any options.");
        }

        // Prints error when the input type did not match to the needed input type.
        public static void InvalidInputTypeError()
        {
            Console.WriteLine("\nError 2: Invalid Input Type. The input type did not match.");
        }
    }
}
