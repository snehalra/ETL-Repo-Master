using System;
using System.Collections;
using System.Collections.Generic;

namespace FarmSystem.Test1
{
    public delegate string FarmEmptyHandler();
    internal class Program
    {
        
        event FarmEmptyHandler FarmEmpty;
        static EmydexFarmSystem farm = new EmydexFarmSystem();
        public static Queue Animalqueue = new Queue();
        private static void Main(string[] args)
        {
            Excercise1();
            Excercise2();
            Excercise3();
            Excercise4();

            Program obj1 = new Program();
            string result = obj1.FarmEmpty();
            Console.WriteLine(result);
            
            Console.ReadKey();

        }
        public Program()
        {
            this.FarmEmpty += new FarmEmptyHandler(this.EmydexFarm);
        }

        /************************************************************************************************************
        Exercise 1 : Apply OOP concepts (abstraction and encapsulation) to the classes 
        modify the code to get the output below
        Cow has entered the farm
        Hen has entered the farm
        Horse has entered the farm
        Sheep has entered the farm
        ***************************************************************************************************************/
        private static void Excercise1()
        {
            Console.WriteLine("Exercise 1 : Press any key when it is time to open the Farm to animals");
            Console.ReadKey();
            
            // Program.farm1.Enter(cow)

            Cow cow = new Cow();
            cow.Id = Guid.NewGuid().ToString();
            cow.NoOfLegs = 4;
            Program.farm.Enter(cow);

            Hen hen = new Hen();
            hen.Id = Guid.NewGuid().ToString();
            cow.NoOfLegs = 4;
            Program.farm.Enter(hen);

            Horse horse = new Horse();
            horse.Id = Guid.NewGuid().ToString();
            horse.NoOfLegs = 4;
            Program.farm.Enter(horse);

            Sheep sheep = new Sheep();
            sheep.Id = Guid.NewGuid().ToString();
            sheep.NoOfLegs = 4;
            Program.farm.Enter(sheep);

            Console.ReadKey();

        }

        /***************************************************************************************************************
         Test Excercise 2
         If you have completed the first test excercise, you can continue with the second one
         Modify the program and EmydexFarmSystem.MakeNoise() method to get the below output
         Expected Test 2 Program Output

         Exercise 2 : Press any key to scare the animals in the farm
            Cow has entered the farm
            Hen has entered the farm
            Horse has entered the farm
            Sheep has entered the farm
            Cow says Moo!
            Hen says CLUCKAAAAAWWWWK!
            Horse says Neigh!
            Sheep says baa!
         *****************************************************************************************************************/
        private static void Excercise2()
        {
            //TODO : Apply OOP concepts and modify the code below to get the required output 
            Console.WriteLine("Exercise 2 : Press any key to scare the animals in the farm");
            Console.ReadKey();

            Program.farm.MakeNoise();
            Console.ReadKey();

        }

        /*****************************************************************************************************************
        Test Excercise 3
        If you have completed the previous test excercise, you can continue with this one 
        The project includes an interface IMilkableAnimal. Make use of this interface to implement on the relevant classes
        so that calling the EmydexFarmSystem.MilkAnimals() method to get the below output

        Expected Test 3 Program Output

        Exercise 3 : Press any key when it is time to milk animals
        Cow has entered the farm
        Hen has entered the farm
        Horse has entered the farm
        Sheep has entered the farm
        Cow was milked!
        ************************************************************************************************************/
        private static void Excercise3()
        {
            //TODO : Apply OOP concepts and modify the code below to get the required output 
            Console.WriteLine("Exercise 3 : Press any key when it is time to milk animals");
            Console.ReadKey();

            Program.farm.MilkAnimals();
            Console.ReadKey();
        }

        /****************************************************************************************************
        Test Excercise 4
        Modify the EmydexFarmSystem.ReleaseAllAnimals() so that all animals are released (simply clear the collection )
        Expose an event on the FarmSystem FarmEmpty which is invoked once all the animals are released
        Subscribe to that event in the main to get the expected output

        Expected Test 4 Program Output

        Exercise 4: Press any key to free all animals
        Cow has entered the farm
        Hen has entered the farm
        Horse has entered the farm
        Sheep has entered the farm
        Cow has left the farm
        Hen has left the farm
        Horse has left the farm
        Sheep has left the farm
        Emydex Farm is now empty
        ********************************************************************************************************************/
       
        private static void Excercise4()
        {

            //TODO : Apply OOP concepts and modify the code below to get the required output 
            Console.WriteLine("Exercise 4: Press any key to free all animals");
            Console.ReadKey();

            Program.farm.ReleaseAllAnimals();
         
        }
      

        public string EmydexFarm()
        {
            return "Emydex Farm is now empty";
        }


    }
}