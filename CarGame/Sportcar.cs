using System;

namespace CarGame
{
    internal sealed class Sportcar : Car
    {
        public Sportcar(string name, int maxSp, int mass) : base(name)
        {
            if (maxSp <= 0 || maxSp > 450)
            {
                throw new ArgumentException("Invalid max speed sportcar");
            }

            if (mass < 500 || mass > 1500)
            {
                throw new ArgumentException("Invalid mass sportcar");
            }

            _maxSpeed = maxSp;
            _mass = mass;
        }
    }
}
