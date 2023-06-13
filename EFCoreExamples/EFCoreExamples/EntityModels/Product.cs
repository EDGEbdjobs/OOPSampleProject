using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreExamples.EntityModels
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductNo { get; set; }
        public string Name { get; set; }
        
    }
}
