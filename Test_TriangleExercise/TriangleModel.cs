using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_TriangleExercise {
    class TriangleModel {
        public int side1 { get; set; }
        public int side2 { get; set; }
        public int side3 { get; set; }
        TriangleType type;

        public TriangleModel() { }

        public TriangleModel(int Side1, int Side2, int Side3) {
            side1 = Side1;
            side2 = Side2;
            side3 = Side3;
        }

        public TriangleType GetTriangleType() {
            return type;
        }


        public void SetTriangleType()
        {
            if (side1 == side2 && side2 == side3 && side1 == side3) {
                type = TriangleType.Equilateral;
            }
            else if(side1 == side2 && side2 != side3 ||
                    side2 == side3 && side1 != side2 ||
                    side1 == side3 && side1 != side3) {
                type = TriangleType.Isosceles;
            }
            else if(side1 != side2 && side1 != side3 && side2 != side3) {
                type = TriangleType.Scalene;
            }
        }
    }


}
