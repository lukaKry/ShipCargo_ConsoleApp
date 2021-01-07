using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCargo_ConsoleApp
{
    class Ship
    {
        //Constant values
        //weight of the different types of cargo: cycles, vehicals, trucks, trainTrucks
        const int CYCLE_WEIGHT = 3;
        const int VEHICLE_WEIGHT = 5;
        const int TRUCK_WEIGHT = 11;
        const int TRAIN_TRUCK_WEIGHT = 17;

        //total amount of one type items
        const int MAX_AMOUNT = 10;


        //Properties: number of loaded cargo items and full ship capacity
        public int CyclesNum { get; set; }
        public int VehicalsNum { get; set; }
        public int TrucksNum { get; set; }
        public int TrainTrucsNum { get; set; }

        public int ShipCapacity { get; set; }

        Random rand = new Random();


        //Constructor: creates a ship with a random capacity; sets properties theirs start value
        public Ship()
        {
            CyclesNum = 0;
            VehicalsNum = 0;
            TrucksNum = 0;
            TrainTrucsNum = 0;
            ShipCapacity = rand.Next(MAX_AMOUNT) * CYCLE_WEIGHT + rand.Next(MAX_AMOUNT) * VEHICLE_WEIGHT + rand.Next(MAX_AMOUNT) * TRUCK_WEIGHT + rand.Next(MAX_AMOUNT) * TRAIN_TRUCK_WEIGHT;


        }


        //Methods
        public int getShipLoaded()
        {
            return CyclesNum * CYCLE_WEIGHT + VehicalsNum * VEHICLE_WEIGHT + TrucksNum * TRUCK_WEIGHT + TrainTrucsNum * TRAIN_TRUCK_WEIGHT;
        }

        public int leftSpace()
        {
            return ShipCapacity - getShipLoaded();
        }

        public override string ToString()
        {
            return $"Full capacity of the ship: {ShipCapacity}   Current load: {getShipLoaded()}   Left space: {leftSpace()}";
        }

        public void printLoad()
        {
            Console.WriteLine($"The ship has a capacity of {ShipCapacity}.\n" +
                              $"The ship has {CyclesNum} motorcycles.\n" +
                              $"The ship has {VehicalsNum} vehicals.\n" +
                              $"The ship has {TrucksNum} trucks.\n" +
                              $"The ship has {TrainTrucsNum} train trucks.\n");
                                       
        }

        public void askForLoad()
        {
            Console.WriteLine("How many motorcycles would you like to load?");
            string inputCycles = Console.ReadLine();
            int result;
            while (!Int32.TryParse(inputCycles,out result))
            {
                Console.WriteLine($"Please write number between 1 to {MAX_AMOUNT}");
                inputCycles = Console.ReadLine();
            }
            CyclesNum = result;

            Console.WriteLine("How many vehicals would you like to load?");
            string inputVehicals = Console.ReadLine();
            int result2;
            while (!Int32.TryParse(inputVehicals, out result2))
            {
                Console.WriteLine($"Please write number between 1 to {MAX_AMOUNT}");
                inputVehicals = Console.ReadLine();
            }
            VehicalsNum = result2;

            Console.WriteLine("How many trucks would you like to load?");
            string inputTrucks = Console.ReadLine();
            int result3;
            while (!Int32.TryParse(inputTrucks, out result3))
            {
                Console.WriteLine($"Please write number between 1 to {MAX_AMOUNT}");
                inputTrucks = Console.ReadLine();
            }
            TrucksNum = result3;


            Console.WriteLine("How many train trucks would you like to load?");
            string inputTrainTrucks = Console.ReadLine();
            int result4;
            while (!Int32.TryParse(inputTrainTrucks, out result4))
            {
                Console.WriteLine($"Please write number between 1 to {MAX_AMOUNT}");
                inputTrainTrucks = Console.ReadLine();
            }
            TrainTrucsNum = result4;

        }
    }
}
