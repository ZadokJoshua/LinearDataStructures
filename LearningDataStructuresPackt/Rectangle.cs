using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDataStructuresPackt1
{
    public class Rectangle
    {
        public int SideA { get; }
        public int SideB { get; }

        public Rectangle(int sideA, int sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public long GetArea()
        {
            return SideA * SideB;
        }

        public static int GetNumberOfAngles() => 4;
    }
}
