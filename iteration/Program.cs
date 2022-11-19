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
        //Console.WriteLine("Type a day of the week to look for it in the list");
        //string dayInput = Console.ReadLine();
        //int index = list.IndexOf(dayInput);
        ////created a loop that iterates through the list and displaysthe index that matches the content in input
        //for (int i= 0; i < list.Count; i++)
        //{
        //    if (dayInput == list[i])
        //    {
        //       Console.WriteLine(list[i] + " index is "+ index);
        //        break;
        //    }
        //    else if (!list.Contains(dayInput))
        //    {
        //        Console.WriteLine("This input is not in the list");
        //
        //    }
        //
        //}
        //
        //
        //Console.ReadLine();




        ////PART 5 
        ////Added a list of strings with two identicalstrings
        //List<string> classroom = new List<string>() { "roberto", "andrea", "roberto", "paris", "sofia", "israel" };
        ////Ask user to select text to search from the list
        //Console.WriteLine("choose a classmate");
        //string classmateChoose = Console.ReadLine();
        //int idx = classroom.IndexOf(classmateChoose); 


        ////create a loop that iterates through the list and displays index of items that match the input text
        //for (int a = 0; a < classroom.Count; a++)
        //{
        //    if (classroom[a] == classmateChoose)
        //    {
        //        Console.WriteLine(classmateChoose + " has index " + idx);
        //        
        //    }
        //    if (!classroom.Contains(classmateChoose))
        //    {
        //        Console.WriteLine("This is not in the list");
        //        break;
        //    }
        //    idx++;
        //}
        //Console.ReadLine();



        //PART 6
        //create list of strings with two identicla items
        List<string> names = new List<string>() { "Anne", "Brianna", "Camille", "Doreen", "Anne" };
        //create empty list to add repeated items
        List<string> repeatedNames = new List<string>();
        int n = 0;


        //create foreach loop that iterates throught the list
        foreach (string name in names)
        {
            //print duplicate in items found in the repeates names list
            if (!repeatedNames.Contains(name))
            {
                Console.WriteLine(name + " is a unique item");
                repeatedNames.Add(name);
            }
            else
            {
                Console.WriteLine(name + " is a duplicate item");
            }
        }

       
        Console.ReadLine();


    }
}

