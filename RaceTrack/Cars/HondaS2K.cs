using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class HondaS2K : RaceCar
    {
        public HondaS2K()
        {
            Name = "HondaS2K";
            TopSpeed = 100;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} sounds like a jet!!!!");
        }
        public override void Brake()
        {
            Console.WriteLine($"The {Name} stops on a dime!");
            base.Brake();
        }
        public override void StopEngine()
        {
            Console.WriteLine($"The {Name} engine stops");
        }
    }
}
