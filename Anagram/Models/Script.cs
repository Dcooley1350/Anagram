using System;
using System.Collections.Generic;
using Anagram.Models;

namespace Models.Script
{
    class Script
    {
        public static void AddItemToCompare()
        {
            Console.WriteLine("Enter a word to compare.");
            string wordToCompare = Console.ReadLine();
            Sort.AddItem(wordToCompare);
        }
        public static void  CompareMasterToList()
        {
            char[] masterChar = Sort.StringToArray();
            Sort.SortArray(masterChar);
            Array.Sort(Sort.StringToArray());
            foreach(string item in Sort.userWords)
            {
                //item.ToCharArray();
                Sort.charList.Add(item.ToCharArray());
            }
            Sort.SortEveryItemInList(Sort.charList);
            foreach(char[] item in Sort.charList)
            {
                string array = new string(item);
                string compare  = new string (masterChar);
                if (array == compare)
                {
                    System.Console.WriteLine(masterChar);
                    Console.WriteLine("{0} is an Anagram of {1}.", array, Sort.masterWord);
                }
                else
                {
                    System.Console.WriteLine(item);
                    System.Console.WriteLine(masterChar);
                    System.Console.WriteLine("{0} is not an Anagram of {1}.", array, Sort.masterWord);
                }
            }
        }
    }
}

