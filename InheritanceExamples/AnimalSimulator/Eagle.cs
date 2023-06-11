using InheritanceExamples.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples.AnimalSimulator
{
    public class Eagle : Bird, IFlyable
    {
        public int FlyingSpeed { get; set; }

        public override string Speak()
        {
            return "Eagle..";
        }

        public string Fly()
        {
            return "Eagle is flying..";
        }
    }
}
