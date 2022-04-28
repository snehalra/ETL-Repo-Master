using System;
using FarmSystem.Test2;

namespace FarmSystem.Test1
{
    public class Cow : IAnimal,IMilkableAnimal, IWalkableAnimal
    {
        public string Id;
        public int NoOfLegs = 4;
        public string name = "Cow";




        public void Talk()
        {
            Console.WriteLine("Cow says Moo!");
        }

        public void  Walk()
        {
            Console.WriteLine("Cow is walking");
        }

        public void ProduceMilk()
        {
            Console.WriteLine("Cow was milked!");
        }

        public void Run()
        {
            Console.WriteLine("Cow has left the farm");
        }

    }
}