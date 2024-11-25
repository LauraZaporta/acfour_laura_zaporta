//PRE: The values given by the user will be numbers
using System;
using acfour_library;

namespace acfour
{
    public class code_acfour
    {
        public static void Main()
        {
            const string AskLengthArray = "How many numbers do You want to type? ";
            const string AskNumber = "Type a number: ";
            const string ShowingNumbers = "Your numbers are: ";
            const string FormatError = "Incorrect format.";

            int count = 0;
            int numInputsUser = 0;
            int numInput = 0;
            bool valid;

            do
            {
                try
                {
                    Console.Write(AskLengthArray);
                    numInputsUser = Convert.ToInt32(Console.ReadLine());
                    valid = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine(FormatError);
                    valid = false;
                }
            } while (!valid);

            int[] arrayNums = new int[numInputsUser];

            while (count < numInputsUser)
            {
                do
                {
                    try
                    {
                        Console.Write($"{AskNumber}{count + 1} of {numInputsUser}: ");
                        numInput = Convert.ToInt32(Console.ReadLine());
                        valid = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine(FormatError);
                        valid = false;
                    }
                } while (!valid);
                arrayNums[count] = numInput;
                count++;
            }
            Console.Write(ShowingNumbers);
            Acfour.DescOrderArray(arrayNums);
            Acfour.PrintArray(arrayNums);
            }
            
    }
}

//POST: The program will return all the numbers that the User put in the program ordered in a descending way