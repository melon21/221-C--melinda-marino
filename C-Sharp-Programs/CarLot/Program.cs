using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLot
{
    public abstract class Vehicle
    {
        public string LicenseNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public string GetDescription()
        {
            return $" {LicenseNumber}, {Make}, {Model}, {Price}";
        }
    } 
    public class Truck : Vehicle
    {
        public float BedSize { get; set; }

    }
    public class Car : Vehicle
    {
       public string Type { get; set; }
        public int Doors { get; set; }

        
    }
    public class CarLot
    {
        public string Name { get; set; }
        public List<Vehicle> Vehicles { get; set; }
        public void AddVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);

        }
        public CarLot()
            {
            Vehicles = new List<Vehicle>();
            }
        public void PrintInventory()
        {
            Console.WriteLine(Name);
            foreach(Vehicle vehicle in Vehicles)
            {
                Console.WriteLine(vehicle.GetDescription());
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CarLot lot1 = new CarLot();
            CarLot lot2 = new CarLot();
            lot1.Name = "McGavock";
            lot2.Name = "Frank Brown";
            lot1.AddVehicle(new Car {LicenseNumber = "12345", Make = "Nissan", Model = "New", Price = 12000 });
            lot1.AddVehicle(new Truck { LicenseNumber = "23456", Make = "Ford", Model = "old", Price = 30000 });
            lot2.AddVehicle(new Car { LicenseNumber = "54321", Make = "VW", Model = "New", Price = 13000 });
           lot2.AddVehicle(new Truck { LicenseNumber = "23476", Make = "Chevy", Model = "New", Price = 40000 });
            lot1.PrintInventory();
            lot2.PrintInventory();
            Console.ReadLine();
        }
    }
}
