//Задание 3
//Создайте интерфейс ICalc2. В нём должно быть два метода:
//■ int CountDistinct() — возвращает количество уникальных значений в контейнере данных;
//■ int EqualToValue(int valueToCompare) — возвращает количество значений равных valueToCompare.
//Класс, созданный ранее в практическом задании Array, должен имплементировать интерфейс ICalc2. 
//Метод CountDistinct — возвращает количество уникальных значений в массиве. 
//Метод EqualToValue — возвращает количество элементов массива равных valueToCompare.
//Напишите код для тестирования полученной функциональности.

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int size = 10;
            MyArray array = new MyArray(size);
            for (int i = 0; i < array.integ.Length; i++)
            {
                array.integ[i] = (rand.Next(0, 10));
            }

            array.Show("All numbers of the array:");
            Console.WriteLine("\n\n");
            int number = 5;
            Console.WriteLine($"Quantity of numbers less than {number}: {array.Less(number)}");
            Console.WriteLine($"Quantity of numbers greater than {number}: {array.Greater(number)}");
            Console.WriteLine("\n\n");
            Console.WriteLine("All Even numbers of the array:");
            array.ShowEven();
            Console.WriteLine("\n");
            Console.WriteLine("All Odd numbers of the array:");
            array.ShowOdd();
            Console.WriteLine("\n\n");
            Console.WriteLine($"Quantity of unique numbers: {array.CountDistinct()}");
            Console.WriteLine($"Quantity of numbers equal to {number}: {array.EqualToValue(number)}");
            Console.WriteLine("\n");
        }
    }
}