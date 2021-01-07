using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCargo_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simple quess game - the Ship has a known capacity (in weight units)
            //Thera are four type of cargo items: cycles, vehicals, trucks, train trucks. 
            //Each of these has a different weight 
            //The aim of the game is to guess the right amount of each cargo item to get the ship fully loaded.

            Ship shipOne = new Ship();
            bool didWin = false;
            while (!didWin)
            {
                printWelcome();
                Console.WriteLine("");
                shipOne.printLoad();
                shipOne.askForLoad();
                
                shipOne.printLoad();
                Console.Clear();
                Console.WriteLine(shipOne.ToString());

                


                if (shipOne.leftSpace() == 0)
                {
                    didWin = true;
                    shipOne.printLoad();
                    Console.WriteLine("OH yeah!! You nailed it!!");
                }
                else
                {
                    Console.WriteLine("Try another numbers.");
                }




            }



            

            Console.ReadLine();






        }

        static void printWelcome()
        {
            Console.WriteLine("Welcome to Cargo Ship. The goal of the game is to load the ship with proper number of cycles, vehicals, trucks and train trucks.");
            Console.WriteLine("A cycles takes 3 units of space. \n" +
                              "A vehicle takes 5 units of space. \n" +
                              "A truck takes 11 units of space. \n" +
                              "A traind truck takes 17 units of space.");
        }

       
    }
}
