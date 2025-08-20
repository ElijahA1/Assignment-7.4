namespace Assignment_7._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParkingSystem parkingSystem = new(1, 1, 0);

            Console.WriteLine(parkingSystem.AddCar(1));//true
            Console.WriteLine(parkingSystem.AddCar(2));//true
            Console.WriteLine(parkingSystem.AddCar(3));//false
            Console.WriteLine(parkingSystem.AddCar(1));//false

            Console.ReadKey();
        }
    }
}
