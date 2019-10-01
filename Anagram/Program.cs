using System;
using System.Collections.Generic;
using Anagram.Models;
using Models.Script;

namespace Anagram
{
    class program
    {
        public static void Main()
        {
           
            Console.WriteLine("enter a string");
            Sort.masterWord = Console.ReadLine();
            Script.AddItemToCompare();
            System.Console.WriteLine("Would you like to add another word to compare? Type 1 for yes and 2 for no.");
            string caseSwitch = Console.ReadLine();
            switch (caseSwitch)
            {
                case "1":
                    Script.AddItemToCompare();
                    break;
                case "2":
                    Console.WriteLine("Calculating Matches...");
                    break;
                default:
                    System.Console.WriteLine("Please enter 1 of 2");
                    Script.AddItemToCompare();
                    break;
            }
            Script.CompareMasterToList();
            // var charr = Console.ReadLine().ToCharArray();
            // Console.WriteLine("Enter another string that could be anagram");
            // Sort.AddItem(charr);

            // var whatItShould = Console.ReadLine().ToCharArray();
            // Array.Sort(charr);
            // Array.Sort(whatItShould);
            // string example = new string(charr);
            // string what = new string (whatItShould);

            // if(example == what)
            // {
            //     Console.WriteLine("passed");
                
            // }
            // else
            // {
            //     System.Console.WriteLine("failed");
            // }

            
            // string [] array = {"deard","leard","berad"};
            // array.Sort() ;
        }

        
    }
}