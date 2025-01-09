using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceNew
{
    public class Reptile : Animal
    {
        // Create a class Reptile
        // give this class 4 members that are specific to Reptile
        // Set this class to inherit from your Animal Class

        public string ScaleType { get; set; }
        public bool IsColdBlooded { get; set; }
        public bool IsVenomous { get; set; }
        public int Lifespan { get; set; }
    }
}
