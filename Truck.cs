using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class Truck : Car
    {
        private int MaxTruckWeight { get; set; }
        private int CurrentTruckCargoWeight { get; set; }
        public Truck(string Brand, string Model, string CarColor, int EnginePower, int MaxTruckWeight):base(Brand, Model, CarColor,EnginePower)
        {
            this.MaxTruckWeight = MaxTruckWeight;
            CurrentTruckCargoWeight = 0;
        }
        public void LoadTruck(int CargoWeight)
        {
            if(CurrentTruckCargoWeight<MaxTruckWeight)
            {
                CurrentTruckCargoWeight += CargoWeight;
                Console.WriteLine("Текущая загрузка грузовика равна {0}", CurrentTruckCargoWeight);
            }
            else
            {
                Console.WriteLine("Вес груза для погрузки велик и превышает допустимую вместимость!");
            }
        }
        public void UnloadTruck(int CargoWeight)
        {
            CurrentTruckCargoWeight -= CargoWeight;
            Console.WriteLine("Грузовик разгружен, теперь вес текущего груза равен{0}", CurrentTruckCargoWeight);
        }
        public override string Passport()
        {
            return String.Format("Характеристики автомобиля:\n" +
                "Марка автомобиля: {0}\n"
                + "Модель автомобиля: {1}\n"
                + "Цвет: {2}\n"
                + "Мощность двигателя: {3} км/ч\n"+"Максимальный первозимый вес {4} кг", Brand, Model, CarColor, EnginePower, MaxTruckWeight);
        }
    }
}
