using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Xml.Linq;
using System.Xml.Schema;

internal class Program
{
    static void Main(string[] args)
    {
        ////PART 1
        ////create a one dimensional array of strings
        //string[] arrayStr = new string[] {"m", "a", "l", "p", "q", "r"};

        ////ask user to input some text
        //Console.WriteLine("Please type whatever");
        //string input = Console.ReadLine();

        ////loop that itereates and adds input to string
        //for (int l=0; l<arrayStr.Length; l++)
        //{
        //    arrayStr[l] = arrayStr[l] + input;
        //}

        ////loop that prints each string in the array one at a time
        //for (int a=0; a<arrayStr.Length; a++)
        //{
        //    Console.WriteLine(arrayStr[a]);
        //}

        //Console.ReadLine();


        ////PART 2
        ////create an infinite loop 
        //Console.WriteLine("Type the number of the first Star Wars episode");
        //int episodeNum = Convert.ToInt32(Console.ReadLine());
        //bool numOfEpisodes = episodeNum <= 9;

        //while (numOfEpisodes == true)
        //{
        //    Console.WriteLine(episodeNum + " is an episode in the StarWars saga");
        //    episodeNum++;
        //    //fixed the inifine loop with an if statement and break;
        //    if (episodeNum > 9)
        //    {
        //        break;
        //    }

        //}
        //Console.ReadLine();



        ////PART 3
        //// loop that uses < to determine weather to continue or not
        //Console.WriteLine("Enter the episode number you are watching to see the episode numbers you are missing to watch");
        //int episodeWatching = Convert.ToInt32(Console.ReadLine());

        //while (episodeWatching < 20)
        //{
        //    Console.WriteLine("you are still missing episode " + episodeWatching);
        //    episodeWatching++;
        //}
        //Console.ReadLine();

        ////loop that uses <= t determine weather to continue or not 
        //Console.WriteLine("type a number lower than 100");
        //int numberInput = Convert.ToInt32(Console.ReadLine());

        //while (numberInput <= 100)
        //{
        //    Console.WriteLine(numberInput);
        //    numberInput++;
        //}
        //Console.ReadLine();


        ////PART 4
        ////a list of strings where each item is unique
        //List<string> list = new List<string>() { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
        ////ask user to input text to sear for in the list
        //Console.WriteLine("Type a day of the week to loor for in the list");
        //string dayInput = Console.ReadLine();
        //int index = list.IndexOf(dayInput);

        ////created a loop that iterates through the list and displaysthe index that matches the content in input
        //for (int i= 0; i < list.Count; i++)
        //{
        //    if (list[i] == dayInput)
        //    {
        //        Console.WriteLine(list[i] + " index is "+ index);
        //    }
        //    if (dayInput != list[i])
        //    {
        //        Console.WriteLine("That is not in the list");
        //        break;
        //    }
        //}
        //Console.ReadLine();



        //PART 5 
        //Added a list of strings with two identicalstrings
        List<string> classroom = new List<string>() { "Roberto", "Andrea", "Roberto", "Paris", "Sofia", "Israel" };
        //Ask user to select text to search from the list
        Console.WriteLine("choose a classmate");
        string classmateChoose = Console.ReadLine();
        int idx = classroom.IndexOf(classmateChoose);


        //create a loop that iterates through the list and displays index of items that match the input text
        foreach (string classmate in classroom)
        {
            if (classmate == classmateChoose)
            {
                Console.WriteLine(classmate + " has index " + idx);
                
            }
            if (classmateChoose != classmate)
            {
                Console.WriteLine("This is not in the list");
                break;
            }
        }
        Console.ReadLine();



        //PART 6
        ////create list of strings with two identicla items
        //List<string> names = new List<string>() { "Anne", "Brianna", "Camille", "Doreen", "Anne" };
        ////create empty list to add repeated items
        //List<string> repeatedNames = new List<string>();


        ////create foreach loop that iterates throught the list
        //foreach (string name in names)
        //{
        //    //created a for loop that fives n a value to compare
        //    for (int n = 0; n < 4; n++)
        //    {
        //        //created if loop that adds item to list
        //        if (name == names[n])
        //        {
        //            repeatedNames.Add(name);
        //        }
        //        //created an if loop that prints unique items
        //        if (name != names[n])
        //        {
        //            Console.WriteLine(name + " is unique");
        //        }

        //    }

        //}
        //Console.WriteLine(repeatedNames[0] + " is a duplicate");

        //Console.ReadLine();


    }
}

