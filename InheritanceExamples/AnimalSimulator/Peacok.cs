using InheritanceExamples.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples.AnimalSimulator
{
    public class Peacok : IFlyable
    {
        
        public Peacok()
        {
            FlyingSpeed = 2;
        }
        public int FlyingSpeed { get; set; }

        public string Fly()
        {
            return "Peacok is flying!";
        }
    }
}
