using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeros
{   
    public class Person
    {
        public override string ToString()
        {
            return Name;
        }
       public String  Name { get; set; }
       public String NickName { get; set; }
       public Person(string name, string nickname)
        {
            Name = name;
            NickName = nickname;
        }
        public virtual void PrintGreeting()
        {
            Console.WriteLine($"Hi my name is { Name }, but you can call me {NickName}.");
        }
    }
    public class SuperHero : Person
    {
        public string RealName { get; set; }
        public string SuperPower { get; set; }
        public SuperHero(string name, string realName, string superPower) : base(name, null)
        {
            RealName = realName;
            SuperPower = superPower;
        }
        public override void PrintGreeting()
        {
            Console.WriteLine($"I am {RealName}. When I am {Name}, my super power is {SuperPower}.");
        }
    }
    public class Villain : Person
    {
        public string Nemesis { get; set; }
        public Villain (string name, string nemesis) : base(name, null)
        {
            Nemesis = nemesis;
        }
        public override void PrintGreeting()
        {
            Console.WriteLine($"I am {Name}. Have you seen {Nemesis}.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person("William", "Bill"));
            people.Add(new SuperHero("Batman", "Bruce Wayne", "Rich"));
            people.Add(new Villain("Joker", "Batman"));
            foreach(Person person in people)
            {
                person.PrintGreeting();
            }
            Console.ReadLine();
        }
    }
}
