﻿using System;

namespace FarmSystem.Test1
{
    public class Horse :IAnimal
    {
        private string _id;
        private int _noOfLegs;
        public string name = "Horse";
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
        

        public void Talk()
        {
            Console.WriteLine("Horse says neigh!");
        }

        public void Run()
        {
            Console.WriteLine("Horse has left the farm");
        }
        
    }
}