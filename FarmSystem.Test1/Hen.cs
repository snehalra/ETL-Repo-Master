using System;

namespace FarmSystem.Test1
{
    public class Hen : IAnimal
    {
        private string _id;
        private int _noOfLegs = 4;
        public string name = "Hen";


        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }



        public int NoOfLegs
        {
            get
            {
                return _noOfLegs;
            }
            set
            {
                _noOfLegs = 4;
            }
        }

        public  void Talk()
        {
            Console.WriteLine("Hen say CLUCKAAAAAWWWWK!");
        }

        public  void Run()
        {
            Console.WriteLine("Hen has left the farm");
        }
    }
}