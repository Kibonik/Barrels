using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrels
{
    public class Barrel
    {

        public int ID { get; }
        public double Diameter { get; }
        public double Height { get; }

        public double Volume { get; } 
        public double Diagonal { get; }

        public Barrel(int id, double diameter, double height)
        {
            ID = id;
            Diameter = diameter;
            Height = height;
            Volume = Math.PI * Math.Pow(Diameter / 2, 2) * Height;
            Diagonal = Math.Sqrt(Diameter * Diameter + Height * Height);
        }

    }
    public class BarrelLine : List<Barrel> { }
    public class BarrelLineList : List<BarrelLine> { }
}
