using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory

{
    
    public class Inventory
    {
        public Inventory(int dr, int hr, int wr)
        {
            dailyRate = dr;
            hourlyRate = hr;
            weeklyRate = wr;
        }
        public int dailyRate { get; set; }
        public int hourlyRate { get; set; }
        public int weeklyRate { get; set; }

    }
    public interface IRentable
    {
        int GetDailyRate();
        string GetDescription();
    }

    public class Boat : IRentable
    { 
        public Boat(int Price)
        {
            HourlyPrice = Price;
        }
        private int HourlyPrice { get; set; }
        public int GetDailyRate()
        {
            return HourlyPrice * 24;
            
        }

        public string GetDescription()
        {
            return "Expinsive Boat";
        }
    }

    public class House : IRentable
    {
        public House(int Price)
        {
            WeeklyPrice = Price;
        }
        private int WeeklyPrice { get; set; }
        public int GetDailyRate()
        {
            return WeeklyPrice / 7;
        }

        public string GetDescription()
        {
          return "Large House";
        }
    }
    public class Car : IRentable
    {
        public Car(int Price)
        {
            DailyPrice = Price;
        }
        private int DailyPrice { get; set; }
        public int GetDailyRate()
        {
            return DailyPrice;
        }

        public string GetDescription()
        {
            return "4 door car";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<IRentable> Inventory = new List<IRentable>();
            Inventory.Add(new Boat(124));
            Inventory.Add(new House(820));
            Inventory.Add(new Car(380));
            foreach(IRentable item in Inventory)
            {             
                Console.WriteLine($"{item.GetDescription()} {item.GetDailyRate()}"); 
            }
            Console.ReadLine();
        }
    }
}
