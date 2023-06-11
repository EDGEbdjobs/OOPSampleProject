using InheritanceExamples.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples.TransportationSimulator
{
    public class Aeroplane : IFlyable
    {
        public Aeroplane()
        {
            FlyingSpeed = 6; 
        }
        public int FlyingSpeed { get; set; }

        public string Fly()
        {
            return "Aeroplane is flying!";
        }
    }
}
