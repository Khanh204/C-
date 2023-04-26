using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A
{
    internal class Hocsinh
    {
        public int Id
        {
            get; set;
        }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public double MathScore { get; set; }
        public double PhysicsScore { get; set; }
        public double ChemistryScore { get; set; }
        public double GPA { get { return (MathScore + PhysicsScore + ChemistryScore) / 3; } }
        public string AcademicPerformance
        {
            get
            {
                if(GPA >= 8)
                {
                    return "Excellent";
                }else if(GPA >= 6.5)
                {
                    return "Fair";
                }else if(GPA >= 5)
                {
                    return "Average";
                }
                else
                {
                    return "Weak";
                }
            }
        }

    }
}
