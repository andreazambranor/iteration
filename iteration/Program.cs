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
        //create list of strings with two identicla items
        List<string> names = new List<string>() { "Anne", "Brianna", "Camille", "Doreen", "Anne" };
        //create empty list to add repeated items
        List<string> repeatedNames = new List<string>();


        //create foreach loop that iterates throught the list
        foreach (string name in names)
        {
            //created a for loop that fives n a value to compare
            for (int n = 0; n < 4; n++)
            {
                //created if loop that adds item to list
                if (name == names[n])
                {
                    repeatedNames.Add(name);
                }
                //created an if loop that prints unique items
                if (name != names[n])
                {
                    Console.WriteLine(name + " is unique");
                }

            }

        }
        Console.WriteLine(repeatedNames[0] + " is a duplicate");

        Console.ReadLine();

          
    }
}

