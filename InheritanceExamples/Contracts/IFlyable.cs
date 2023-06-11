using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples.Contracts
{
    public interface IFlyable
    {
        public int  FlyingSpeed { get; set; }
        public string Fly();    
        
    }
}
