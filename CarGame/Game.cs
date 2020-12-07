using System;

namespace CarGame
{
    delegate void SetStart(double startPosition);
    delegate void GoCart();
    delegate string Message();
    internal class Game
    {
        private SetStart _setStart;
        private GoCart _go;
        private Message _win;

        public Game() { }

        public void AddToRace(Car car)
        {
            _setStart += car.SetPosition;
            _go += car.Go;
        }

        public void OnStart()
        {
            _setStart(0);
        }

        public void Go()
        {
            while (true)
            {
                _go();
                _win = Car._win;

                if (_win != null)
                {
                    Console.WriteLine(_win());
                    break;
                }
            }

        }
    }
}
