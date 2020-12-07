using System;

namespace CarGame
{
    internal sealed class Bus : Car
    {
        public Bus(string name, int maxSp, int mass) : base(name)
        {
            if (maxSp <= 0 || maxSp > 200)
            {
                throw new ArgumentException("Invalid max speed bus");
            }

            if (mass < 1000 || mass > 6500)
            {
                throw new ArgumentException("Invalid mass bus");
            }

            _maxSpeed = maxSp;
            _mass = mass;
        }
    }
}
