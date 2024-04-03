/*Створити об'єкт класу Автомобіль, використовуючи класи 
 * Грузовий, Легковий. Методи: змінення марки, грузопідйомності, кольору.*/

using System;

namespace ConsoleApp1
{
    public class Car
    {
        public string Brand { get; set; }
        public int PassengerCapacity { get; set; }  //грузопідйомність
        public string Color { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"brand = {Brand}, PassengerCapacity = {PassengerCapacity}, color = {Color}, year = {Year}";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (obj is Car car)
                return Brand == car.Brand && PassengerCapacity == car.PassengerCapacity && Color == car.Color && Year == car.Year;
            return false;
        }
    }
    public class Truck : Car //Грузовий
    {
        public int Weight { get; set; }
        public float Height { get; set; }
        public int Price { get; internal set; }

        public override string ToString()
        {
            return $"brand = {Brand}, PassengerCapacity = {PassengerCapacity}, color = {Color}, year = {Year}, weight = {Weight}, height = {Height}, price = {Price}";
        }
        public override bool Equals(object? obj)
        {
            if (obj is Truck car)
                return Brand == car.Brand && PassengerCapacity == car.PassengerCapacity && Color == car.Color && Year == car.Year
                    && Weight == car.Weight && Height == car.Height && Price == car.Price;
            return false;
        }
    }

    public class Passenger_Car : Car //Легковий
    {
        public int Weight { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"brand = {Brand}, PassengerCapacity = {PassengerCapacity}, color = {Color}, year = {Year}, weight = {Weight}, price = {Price}";
        }
        public override bool Equals(object? obj)
        {
            if (obj is Passenger_Car car)
                return Brand == car.Brand && PassengerCapacity == car.PassengerCapacity && Color == car.Color && Year == car.Year
                    && Weight == car.Weight && Price == car.Price;
            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car { PassengerCapacity = 5, Year = 2004 };
            Console.Write("Введіть марку: ");
            car.Brand = Console.ReadLine();
            Console.Write("Введіть колір: ");
            car.Color = Console.ReadLine();
            Console.WriteLine(car);

            Truck truck = new Truck { PassengerCapacity = 25, Year = 2015, Weight = 10000, Height = 4, Price = 17000};
            Console.Write("Введіть марку грузового автомобіля: ");
            truck.Brand = Console.ReadLine();
            Console.Write("Введіть колір: ");
            truck.Color = Console.ReadLine();
            Console.WriteLine(truck);

            Passenger_Car passenger_car = new Passenger_Car { PassengerCapacity = 4, Year = 2020, Weight = 5000, Price = 25000 };
            Console.Write("Введіть марку легкового автомобіля: ");
            passenger_car.Brand = Console.ReadLine();
            Console.Write("Введіть колір: ");
            passenger_car.Color = Console.ReadLine();
            Console.WriteLine(passenger_car);
        }
    }
}