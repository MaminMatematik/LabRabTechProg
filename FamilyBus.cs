using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    internal class FamilyBus : Car
    {
        private int MaxPassengersCount { get; set; }
        private int CurrentPassngersCount { get; set; }
        public FamilyBus(string Brand, string Model, string CarColor, int EnginePower, int MaxPassengersCount) : base(Brand, Model, CarColor, EnginePower)
        {
            this.MaxPassengersCount = MaxPassengersCount;
            CurrentPassngersCount = 0;
        }
        public void AddPassengerInBus(int passengers)
        {
            if (CurrentPassngersCount < MaxPassengersCount)
            {
                CurrentPassngersCount = +passengers;
                Console.WriteLine("Пассажиры сели в автомобиль. Теперь их внутри: {0} челолвек", CurrentPassngersCount);
            }
            else
            {
                Console.WriteLine("Данное количество не может быть посажено в автомобиль! Усажена лишь часть!");
                CurrentPassngersCount += (MaxPassengersCount - CurrentPassngersCount);
            }
        }
        public void DeletePassengerFromBus(int passengers)
        {
            if (CurrentPassngersCount > 0&&passengers>CurrentPassngersCount)
            {
                Console.WriteLine("Вы ввели число большее, чем количество пассажиров в салоне, поэтому удалены оставшиеся!");
                CurrentPassngersCount -= CurrentPassngersCount;
            }
            else
            {
                CurrentPassngersCount -= passengers;
                Console.WriteLine("Пассажиры высажены! Теперь пассажиров в салоне {0}", CurrentPassngersCount);
            }
        }
        public override string Passport()
        {
            return String.Format("Характеристики автомобиля:\n" +
                "Марка автомобиля: {0}\n"
                + "Модель автомобиля: {1}\n"
                + "Цвет: {2}\n"
                + "Мощность двигателя: {3} км/ч\n" + "Максимальный первозимое число пассажиров {4} человека", Brand, Model, CarColor, EnginePower, MaxPassengersCount);
        }
    }
}
