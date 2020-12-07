using System;

namespace CarGame
{
    abstract class Car
    {
        private readonly string _name;
        internal static Message _win;
        protected int _maxSpeed;
        protected int _mass;

        public double Position { get; private set; }
        public string Name { get; }

        public Car(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Invalid name.");
            }

            _name = name;
        }

        public void SetPosition(double posistion)
        {
            if (posistion < 0)
            {
                throw new ArgumentException("Invalid position.");
            }

            Position += posistion;
        }

        public string GetPosition()
        {
            return String.Format($"Сurrent position {_name} is {Position} meters");
        }

        public string Winner()
        {
            return String.Format($"Winner {_name} with speed {_maxSpeed}");
        }

        public void Go()
        {
            Random rand = new Random();
            double posit = rand.Next(1, _maxSpeed / 10) + _maxSpeed/_mass + 10;
            SetPosition(posit);

            if (Position >= 100)
            {
                _win += Winner;
            }
        }
    }
}
