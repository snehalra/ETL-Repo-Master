using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        Queue AnimalQueue = new Queue();
       

        //TEST 1
        public void Enter(object animal)
        {

            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities

            
            Type AnimalType = animal.GetType();
            AnimalQueue.Enqueue(AnimalType.Name);
            


            Console.WriteLine(AnimalType.Name + " "+"has entered the farm");
           
        }
     
        //TEST 2
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk


           foreach (var Animal in AnimalQueue)
            {
                Console.WriteLine("{0}  has entered the farm", Animal);
            }


            Cow myCow = new Cow(); // Create a Cow object
            myCow.Talk();  // Call the abstract method
           

            Hen myHen = new Hen(); // Create a Hen object
            myHen.Talk();

            Horse myHorse = new Horse(); // Create a Horse object
            myHorse.Talk();

            Sheep mySheep = new Sheep(); // Create a Sheep object
            mySheep.Talk();

            
        }

        //TEST 3
        public void MilkAnimals()
        {

            foreach (var Animal in AnimalQueue)
            {
                Console.WriteLine("{0}  has entered the farm", Animal);
            }

            Cow myCow = new Cow(); // Create a Cow object
            myCow.ProduceMilk();  // Call the abstract method

        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            while (AnimalQueue.Count > 0)
                Console.WriteLine("{0}  has entered the farm", AnimalQueue.Dequeue());
            
            Cow myCow = new Cow(); // Create a Cow object
            myCow.Run();  // Call the abstract method

            Hen myHen = new Hen(); // Create a Hen object
            myHen.Run();

            Horse myHorse = new Horse(); // Create a Horse object
            myHorse.Run();

            Sheep mySheep = new Sheep(); // Create a Sheep object
            mySheep.Run();

          
        }
    }
}