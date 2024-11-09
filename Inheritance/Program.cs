using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Brand = "Mersedes";
            car.Color = "Black";
            car.EngineVolume = 450;
            car.NumberOfPlace = 5;
            Console.WriteLine("Характеристики машины: ");
            Console.WriteLine($"Название: {car.Brand}    Цвет: {car.Color}    Объем двигателя: {car.EngineVolume}    Количество мест: {car.NumberOfPlace}");

            Console.WriteLine();
            Bicycle bicycle = new Bicycle();
            bicycle.Brand = "Stinger";
            bicycle.Color = "Green";
            bicycle.MinAge = 12;
            bicycle.NumberOfSpeed = 21;
            Console.WriteLine("Характеристики велосипеда: ");
            Console.WriteLine($"Название: {bicycle.Brand}    Цвет: {bicycle.Color}    Возрастное ограничение: {bicycle.MinAge} лет    Количество скоростей: {bicycle.NumberOfSpeed}");

            Console.ReadLine();
        }
    }
}
