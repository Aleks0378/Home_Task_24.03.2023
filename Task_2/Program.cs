
//Задание 2
//Создайте интерфейс IOutput2. В нём должно быть два метода:
//■ void ShowEven() — отображает четные значения из 
//контейнера с данными;
//■ void ShowOdd() — отображает нечетные значения из 
//контейнера с данными.
//Класс, созданный ранее в практическом задании Array, должен имплементировать интерфейс IOutput2. 
//Метод ShowEven — отображает четные значения из массива.
//Метод ShowOdd — отображает нечетные значения из массива.
//Напишите код для тестирования полученной функциональности.

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int size = 20;
            MyArray array = new MyArray(size);
            for (int i = 0; i < array.integ.Length; i++)
            {
                array.integ[i] = (rand.Next(0, 20));
            }

            array.Show("All numbers of the array:");
            Console.WriteLine("\n\n");
            int number = 10;
            Console.WriteLine($"Quantity of numbers less than {number}: {array.Less(number)}");
            Console.WriteLine($"Quantity of numbers greater than {number}: {array.Greater(number)}");
            Console.WriteLine("\n\n");
            Console.WriteLine("All Even numbers of the array:");
            array.ShowEven();
            Console.WriteLine("\n");
            Console.WriteLine("All Odd numbers of the array:");
            array.ShowOdd();
            Console.WriteLine("\n");
        }
    }
}