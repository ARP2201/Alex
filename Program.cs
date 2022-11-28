using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_mass_from_old
{
    class Program
    {
        static void Main(string[] args)
        {
            //Инициализация наших массивов
            string[] old_mass = new string[5] { "red", "blue", "hype", "ip", "repoz" };
            string[] new_mass = new string[old_mass.Length];
            
            //Старый массив из строк
            Console.WriteLine("Старый массив из строк:");
            for (int i = 0; i < old_mass.Length; i++)
                Console.Write(old_mass[i] + " ");
            Console.WriteLine();

            //Формирование нового массива строк
            int count = 0;
            for (int i = 0; i < old_mass.Length; i++)
            {
                if (old_mass[i].Length <= 3)
                {
                    new_mass[count] = old_mass[i];
                    count++;
                }
            }

            //Вывод созданного массива строк
            Console.WriteLine("Новый массив из строк:");
            for (int i = 0; i < new_mass.Length; i++)
                Console.Write(new_mass[i] + " ");
            Console.ReadKey();
        }
    }
}


