// CarApp with manual dependency Management
namespace CarAppIOC
{
    class Program
    {
        static void Main(string[] args)
        {
            var log = new ConsoleLog();

            var tires = new Tires(log);

            var engine = new Engine(tires, log);

            var car = new Car(engine, log);

            car.Go();
        }
    }
}
