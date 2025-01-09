using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.src.OopPrinciples.Composition
{
    public class Car
    {
        private Engine _engine = new();
        private Wheels _wheels = new();
        private Seats _seats = new();
        private Chassis _chassis = new();

        public void StartCar()
        {
            _engine.Start();
            _wheels.Rotate();
            _chassis.Support();
            _seats.Sit();
        }

    }
}