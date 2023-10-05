using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string CarColor { get; set; }
        public int EnginePower { get; set; }
        public double Speed { get; set; }
        public bool EngineIsWorking { get; set; }
        public Car(string Brand, string Model, string CarColor, int EnginePower)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.CarColor = CarColor;
            this.EnginePower = EnginePower;
            EngineIsWorking = false;
            Speed = 0;
        }
        public void StartEngine()
        {
            EngineIsWorking = true;
            Console.WriteLine("Двигатель запущен!");
        }
        public void OffEngine()
        {
            EngineIsWorking = false;
            Console.WriteLine("Двигатель заглушен!");
        }
        public void IncreaseSpeed(double newSpeed)
        {
            if(EngineIsWorking==true)
            {
                Speed += newSpeed;
                Console.WriteLine("Скорость автомобиля изменена на {0} км/ч. Теперь скорость автомобиля равна {1} км/ч", newSpeed, Speed);
            }
            else
            {
                Console.WriteLine("Для изменения скорости необходимо завести автомобиль!");
            }
        }
        public void DecreaseSpeed(double newSpeed)
        {
            if (EngineIsWorking == true)
            {
                Speed -= newSpeed;
                Console.WriteLine("Скорость автомобиля изменена на {0} км/ч. Теперь скорость автомобиля равна {1} км/ч", newSpeed, Speed);
            }
            else
            {
                Console.WriteLine("Для изменения скорости необходимо завести автомобиль!");
            }
        }
        public virtual string Passport()
        {
            return String.Format("Характеристики автомобиля:\n"+
                "Марка автомобиля: {0}\n"
                +"Модель автомобиля: {1}\n"
                +"Цвет: {2}\n" 
                + "Мощность двигателя: {3} км/ч\n", Brand,Model,CarColor,EnginePower);
        }
    }
}
