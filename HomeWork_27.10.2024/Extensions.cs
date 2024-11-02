using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_27._10._2024
{
    internal static class Extensions
    {
        public static List<int> Random (this List<int> list)
        {
            List<int> shuffledList = new List<int>(list); // Создаем копию оригинального списка
            Random rnd = new Random();

            for (int i = 0; i < shuffledList.Count; i++)
            {
                int j = rnd.Next(i, shuffledList.Count); // случайный индекс. Метод Next()  у объекта rnd выбирает случайное число в заданном диапазоне
                int temp = shuffledList[i];
                shuffledList[i] = shuffledList[j];
                shuffledList[j] = temp;
            }

            return shuffledList; // Возвращаем новый перемешанный список
        }

        public static bool Invert (this bool item)
        {
            bool reverseItem = !item;
            return reverseItem;
        }
    }
}
