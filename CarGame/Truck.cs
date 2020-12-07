using System;

namespace CarGame
{
    internal sealed class Truck : Car
    {
        public Truck(string name, int maxSp, int mass) : base(name)
        {
            if (maxSp <= 0 || maxSp > 250)
            {
                throw new ArgumentException("Invalid max speed Truck");
            }

            if (mass < 3000 || mass > 10500)
            {
                throw new ArgumentException("Invalid mass Truck");
            }

            _maxSpeed = maxSp;
            _mass = mass;
        }
    }
}
