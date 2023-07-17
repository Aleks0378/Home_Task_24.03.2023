using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public interface ICalc
    {
        public int Less(int valueToCompare);
        public int Greater(int valueToCompare);
    }
    public interface IOutput2
    {
        public void ShowEven();
        public void ShowOdd();
    }

    internal class MyArray: ICalc, IOutput2
    {
        public int[] integ;

        public MyArray(int s) 
        {
            integ = new int[s];
        }
       
        public void Show()
        {
            for (int i=0; i<integ.Length; i++)
            {
                Console.Write($"\t{integ[i]}");
            }
        }
        public void Show(string info)
        {
            Console.WriteLine(info);
            for (int i = 0; i < integ.Length; i++)
            {
                Console.Write($"\t{integ[i]}");
            }
        }

        public int Less(int valueToCompare)
        {
            int count = 0;
            for (int i = 0; i < integ.Length; i++)
                if (integ[i] < valueToCompare)
                    count++;
            return count;
        }
        public int Greater(int valueToCompare)
        {
            int count = 0;
            for (int i = 0; i < integ.Length; i++)
                if (integ[i] > valueToCompare)
                    count++;
            return count;
        }
        public void ShowEven()
        {
            foreach (var a in integ)
                if (a % 2 == 0)
                    Console.Write($"\t{a}");
        }
        public void ShowOdd()
        {
            foreach (var a in integ)
                if (a % 2 != 0)
                    Console.Write($"\t{a}");
        }
    }
}
