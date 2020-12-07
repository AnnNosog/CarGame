using System;

namespace CarGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Sportcar sport = new Sportcar("BMW", 250, 650);
            Bus bus = new Bus("MAZ", 155, 4500);
            Truck truck = new Truck("MAN", 240, 6000);
            PassengerCar passCar = new PassengerCar("Opel", 200, 2500);

            Game game = new Game();
            game.AddToRace(sport);
            game.AddToRace(bus);
            game.AddToRace(truck);
            game.AddToRace(passCar);
            game.OnStart();
            game.Go();

            Console.ReadKey();
        }
    }
}
