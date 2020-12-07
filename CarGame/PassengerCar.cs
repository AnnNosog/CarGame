using System;

namespace CarGame
{
    internal sealed class PassengerCar : Car
    {
        public PassengerCar(string name, int maxSp, int mass) : base(name)
        {
            if (maxSp <= 0 || maxSp > 300)
            {
                throw new ArgumentException("Invalid max speed PassengerCar");
            }

            if (mass < 1000 || mass > 4500)
            {
                throw new ArgumentException("Invalid mass PassengerCar");
            }

            _maxSpeed = maxSp;
            _mass = mass;
        }
    }
}
