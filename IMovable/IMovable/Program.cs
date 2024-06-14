using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMovable
{

    // Interface
    interface IMovable
    {
        void Move();
    }

    // Class Car implementing IMovable
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Class Bicycle implementing IMovable
    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Car and Bicycle
            Car car = new Car();
            Bicycle bicycle = new Bicycle();

            // Call the Move() method on each instance
            car.Move(); 
            bicycle.Move(); 

            Console.ReadLine();
        }
    }
}
