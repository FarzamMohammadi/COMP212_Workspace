using LinqToDB;
using Q1Lab3;
using System;
using System.Collections.Generic;
using System.Linq;


namespace _301109706_Mohammadi__Lab05
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> returnedList = new List<string>();

            returnedList = Country.countryNamesInAlphabeticalOrder();
            foreach (string item in returnedList)
            {

                Console.WriteLine(item);
            }

            returnedList = Country.countryNamesInDescendingNumberOfResources();
            Console.WriteLine();
            foreach (string item in returnedList) { 
                
                Console.WriteLine(item);
            }

            returnedList = Country.bordersArgentina();
            Console.WriteLine();
            foreach (string item in returnedList)
            {
                Console.WriteLine(item);
            }

            returnedList = Country.countriesOverTenMilPopulation();
            Console.WriteLine();
            foreach (string item in returnedList)
            {
                Console.WriteLine(item);
            }


            returnedList = Country.countryWithMaxPopulation();
            Console.WriteLine();
            foreach (string item in returnedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
