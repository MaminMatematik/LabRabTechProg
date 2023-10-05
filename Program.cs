using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4TechProg
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu1 = 0;
            while(menu1!=4)
            {
                Console.WriteLine("Что вы хотите сделать?");
                Console.WriteLine("1) Создать легковой автомобиль\n"+
                    "2) Создать грузовик\n"+
                    "3) Создать семейный автобус\n");
                switch (menu1)
                {
                    case 1:
                        Console.WriteLine("");
                        Car car = new Car();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
                }
            int menu2 = 0;
            while(menu2!=9)
            {
                Console.WriteLine("Что вы хотите сделать?");
                Console.WriteLine("1)");
                switch (menu2)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                }
            }
        }
    }
}
