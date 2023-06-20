using MyLibrary;


namespace Practice_Class_Libraries
{
    internal class Program
    {
        static List<Vehicle> vehicles = new List<Vehicle>();
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("red");
            Air air = new Air("pink");
            Helicopter helicopter = new Helicopter("green", 4);
            Plane plane = new Plane("brown", 2);
            Sea sea = new Sea("white", "submarine");
            Land land = new Land("orange", 3);

            vehicles.Add(vehicle);
            vehicles.Add(air);
            vehicles.Add(helicopter);
            vehicles.Add(plane);
            vehicles.Add(sea);
            vehicles.Add(land);

            foreach (Vehicle v in vehicles)
            {
                Console.WriteLine(v);
            }

        }
    }
}