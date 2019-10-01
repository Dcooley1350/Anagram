using System;
using System.Collections.Generic;

namespace Anagram.Models
{
    public class Sort
    {
       
        public static string masterWord = "";
        // public static List<char[]> organizedList = new List<char[]>();
        public static List<string> userWords = new List<string>();

        public static List<char[]> charList = new List<char[]>();

        public static char[] StringToArray()
        {
            return masterWord.ToCharArray();
        }
        public static void AddItem(string item)
        {
            
            userWords.Add(item);
        }
        public static void SortArray(char[] array)
        {
           Array.Sort(array);
        }
        public static void ClearAll()
        {
            masterWord = "";
            userWords.Clear();
            charList.Clear();
        }
        public static void SortEveryItemInList(List<char[]> whateverList)
        {
             foreach(char[] item in whateverList)
             {
                Sort.SortArray(item);
             }
        }
    //     public static void Compare(List<char[]> whatItShouldList)
    // {
        
    //      oragnizedList.CompareTo(whatItShouldList);
    // }

        
    
        }
        
    }
