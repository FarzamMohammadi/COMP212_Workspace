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

            List<string> namesInORder = new List<string>();
            
            namesInORder = Country.countryNamesInAlphabeticalOrder();
            foreach (string name in namesInORder)
            {

                Console.WriteLine(name);
            }

            namesInORder = Country.countryNamesInDescendingNumberOfResources();
            Console.WriteLine();
            foreach (string name in namesInORder) { 
                
                Console.WriteLine(name);
            }

            namesInORder = Country.bordersArgentina();
            Console.WriteLine();
            foreach (string name in namesInORder)
            {
                Console.WriteLine(name);
            }

            namesInORder = Country.countriesOverTenMilPopulation();
            Console.WriteLine();
            foreach (string name in namesInORder)
            {
                Console.WriteLine(name);
            }


            namesInORder = Country.countryWithMaxPopulation();
            Console.WriteLine();
            foreach (string name in namesInORder)
            {
                Console.WriteLine(name);
            }
        }
    }
}
