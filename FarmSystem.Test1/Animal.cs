using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test1
{
   public abstract class Animal
    {
        public  string name ="COW";
        public string _id;
        public int _noOfLegs = 4;


        
        public abstract void Talk();
        public abstract void Walk();
        public abstract void Run();
        public abstract void ProduceMilk();



    }
}
