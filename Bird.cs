using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceNew
{
    public class Bird : Animal
    {
        // Create a class Bird
        // give this class 4 members that are specific to Bird
        // Set this class to inherit from your Animal Class

        public string FeatherColor { get; set; }
        public double WingSpan { get; set; }
        public bool CanFly { get; set; }
        public string BeakType { get; set; }

    }
}
