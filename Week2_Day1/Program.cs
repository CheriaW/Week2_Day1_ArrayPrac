﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Day1
{
    class Program
    {
        static void Main(string[] args)
        {


            //// for the sake of example (int favoriteNumber;)
            //int[] favoriteNumbers = { 61, 22, 3, 44, 105, 36 };
            //// pluralize on purpose becasue we are talking about many instead of one
            ////a number of different like items in order sequence
            ////empty array, having declared anything yet
            //// = gives value to the array "1-6"
            ////anytthing going into this array is an INT
            ////size/ length of our array if 6
            //string[] studentNames = { "Raz", "Monica", "Cheria", "Brad", "Kat", "Yuseff", "Katie" };
            //Console.WriteLine(favoriteNumbers[0]);
            //Console.WriteLine(studentNames[2]);
            ////remember to specify arrays and indexs

            ////do it
            //string[] topVaca = { "Peru", "Belieze", "India", "Tokyo", "Hawaii", "Italy", "Paris", "Moscow", "Florida", "California" };
            //Console.WriteLine(topVaca[0]);
            //Console.WriteLine(topVaca[9]);
            //int[] kidsAge = { 8, 7, 1 };
            //Console.WriteLine(kidsAge[0]);
            //Console.WriteLine(kidsAge[1]);
            //Console.WriteLine(kidsAge[2]);
            //decimal[] kidGpa = {4.0m, 3.5m, 3.0m, 2.5m, 2.0m, 1.5m, 1.0m, .5m};
            ////Console.WriteLine();
            //char[] firstInitial = { 'F', 'Y', 'J', 'B' };


            //int[] numbers = new int[4];
            ////new int is used for when we dont know the data
            //numbers [0] = 43;
            //numbers[1] = 12;
            //Console.WriteLine("Please enter a number.");
            //numbers[2] = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter a number.");
            //numbers[3] = int.Parse(Console.ReadLine());
            //Console.WriteLine(numbers[3]);

            //numbers[0] = 30;

            ////do it #2 and 
            //string[] sevenDays = new string[7];
            //sevenDays[0] = "Sun";
            //sevenDays[1] = "Mon";
            //sevenDays[2] = "Tues";
            //sevenDays[3] = "Wed";
            //sevenDays[4] = "Thurs";
            //sevenDays[5] = "Fri";
            //sevenDays[6] = "Sat";

            //int[] studentAges = new int[4];
            //studentAges[0] = 12;
            //studentAges[1] = 4;
            //studentAges[2] = 6;
            //studentAges[3] = 8;
            //Console.WriteLine(sevenDays.Length);


            //char[] lastName = { 'W', 'H', 'I', 'T', 'E' };
            //Console.WriteLine(lastName.Length);

            //string[] exampleStringArray = { "This", "is", "an", "array", "of", "words" };
            ////Console.WriteLine(exampleStringArray.Length);
            //int index = exampleStringArray.Length;
            //index = index - 2;

            //Console.WriteLine(exampleStringArray[index]);
            ////tells you what word exactly in index 5
            //Console.WriteLine("This is the last index " + (exampleStringArray.Length - 1));
            ////shorthand
            //Console.WriteLine(exampleStringArray[exampleStringArray.Length - 1]);


            
            //Console.WriteLine("Please enter the size of the array.");
            //int arraySize = int.Parse(Console.ReadLine());
            //int[] newArray = new int[arraySize];
            //Console.WriteLine("The array is of length " + newArray.Length + ".");

            //string[] birthMonths = { "October", "July", "October", "May" };
            //Console.WriteLine(Array.IndexOf(birthMonths, "October"));
            ////it will just return the first occurance of "october"
            ////entering an element that isnt included in the string will result in a "-1"
            //int[] numbers = { 2, 3, 9, 4, 3, 4, 6, 5 };
            //Console.WriteLine(Array.LastIndexOf(numbers, 4));
            //Console.WriteLine(Array.LastIndexOf(numbers, 5));

            //Array.Reverse(numbers);
            ////flips the whole array (mirror image)
            //Console.WriteLine(numbers[0]);
            ////will return '5' because the array had been switched

            //Array.Sort(numbers);
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[numbers.Length - 1]);


            //do it #4
            string[] firstNames = { "Cheria", "Chris", "Taniesha", "Niema", "Tre", "Demetrius" };
            Console.WriteLine(Array.IndexOf(firstNames, "Demetrius"));


            int[] luckyNum = { 2, 4, 24, 48, 100, 2, 4, 24, 48, 100 };
            Console.WriteLine(Array.IndexOf(luckyNum, 48));
            Console.WriteLine(Array.LastIndexOf(luckyNum, 100));

            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f' };
            Console.WriteLine(letters[0]);
            Array.Reverse(letters);
            Console.WriteLine(letters[0]);

            string[] studentNames = { "Cheria", "JD", "Kevin", "Katie", "Kathleen", "Brad" };
            Array.Sort(studentNames);
            Console.WriteLine(studentNames[0]);
            Console.WriteLine(studentNames[studentNames.Length - 1]);


            double[] favNum = { 48, 11, 42, 7, 5, 3, 8, 64, 32, 788};
            Array.Sort(favNum);
            Console.WriteLine(favNum[0]);
            Console.WriteLine(favNum[favNum.Length - 1]);

            //DAY 2 ---------- LOOPS



        }
    }
}
