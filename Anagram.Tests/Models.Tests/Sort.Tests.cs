using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagram.Tests
{
    [TestClass]
    public class AnagramTest : IDisposable 
    {
        public void Dispose()
        {
            Sort.ClearAll();
        }
        // public void Compare()
        // {

        // }
        [TestMethod]
        public void StringToArray_ConvertAStringToAnArray_True()
        {
            Sort.masterWord = "bread";
            char[] correctArray = {'b','r','e','a','d'};
            Console.WriteLine(correctArray);
            System.Console.WriteLine(Sort.StringToArray());
            CollectionAssert.AreEqual(Sort.StringToArray(), correctArray);
        }
        [TestMethod]
        public void AddItem_AddAnItemToList_True()
        {
            string item = "dead";
            List<string> testList = new List<string> {"dead"};
            Sort.AddItem(item);
            CollectionAssert.AreEqual(Sort.userWords, testList);
        }
        [TestMethod]
        public void SortArray_SortAnArrayIntoAlphabeticalOrder_True()
        {
            char[] array = {'b','r','e','a','d'};
            char [] whatItShould = {'a','b','d','e','r'};
            Sort.SortArray(array);
            CollectionAssert.AreEqual(whatItShould , array);
        }
        [TestMethod]
        public void SortEveryItemInList_SortEveryItemInList_True()
        {
            char[] char1 = { 'o','l','k','y'};
            char[] char2 = {'a','f','q','l','p'};
            List<char[]> chars = new List<char[]>{char1,char2};
            Sort.SortEveryItemInList(chars);
            char [] whatItShould = {'k','l','o','y'};
            char [] whatItShould2 = {'a','f','l','p','q'};
            List<char[]> whatItShouldList = new List<char[]>{whatItShould,whatItShould2};
            // Console.WriteLine(whatItShouldList[0]);
            Console.WriteLine(chars[0]);
            Console.WriteLine(whatItShouldList[0]);
            // chars.ToArray();
            // whatItShouldList.ToArray();
            System.Console.WriteLine(chars);
            System.Console.WriteLine(whatItShouldList);
            // foreach(char[] beforechar in chars)
            // {
            //     foreach(char[] afterchar in whatItShouldList)
            //     {
            //         if(CollectionAssert.AreEqual(beforechar, afterchar))
            //         {
            //             Console.WriteLine("its passed")
            //         }
            //     }
            // }
            // CollectionAssert.AreEqual(chars.ToArray(), whatItShouldList.ToArray());
           CollectionAssert.AreEqual(chars, whatItShouldList); 
           
        }
         
    }
}