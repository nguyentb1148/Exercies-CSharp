using System;

namespace Exercies4_CSharp
{
    public class Seat : ICar
    {
        public  string Model { get; private set; }
        public  string Color { get; private set; }

        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public string Start()
        {
            return "Engine start\n";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            return $"{Color} Seat {Model}\n{Start()}{Stop()}";
        }
    }
}