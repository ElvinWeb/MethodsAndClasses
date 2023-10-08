using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndClasses
{
    public class Car
    {
        public string Brand;
        public string Model;
        public double CurrentFuel;
        public double FuelFor1Km;
        public double Millage;

        public Car(string brand, string model, double currentFuel, double fuelFor1Km, double millage)
        {
            this.Brand = brand;
            this.Model = model;
            this.CurrentFuel = currentFuel;
            this.FuelFor1Km = fuelFor1Km;
            this.Millage = millage;
        }

        public void Drive(int distance)
        {
            double requiredFuel = distance * FuelFor1Km;
            if (requiredFuel <= CurrentFuel)
            {
                Millage += distance;
                CurrentFuel -= requiredFuel;
                Console.WriteLine($"Sürüş başa çatdı. Millage: {Millage} km, Benzin miqdarı: {CurrentFuel} l.");
            }
            else
            {
                Console.WriteLine("Sürüş üçün Benzin yeterli deyil!!");
            }
        }
    }
}
