namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        var car = new Car
        {
            Brand = "BMW",
            Speed = 120,
            Seat = "Leather"
        };

        car.DisplayInfo();

        var bike = new Motorcycle
        {
            Brand = "DUKE",
            Speed = 150,
            Engine = "250cc"
        };

        bike.DisplayInfo();

    }
}