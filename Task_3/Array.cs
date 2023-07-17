using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    public interface ICalc2
    {
        public int CountDistinct();
        public int EqualToValue(int valueToCompare);
    }

    internal class MyArray: ICalc, IOutput2, ICalc2
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

        public int CountDistinct()
        {
            int count = 0;
            bool found= false;
            for (int i = 0;i < integ.Length;i++)
            {
                found = false;
                for (int j = 0; j < integ.Length; j++)
                    if (i != j && integ[i] == integ[j])
                    {
                       found=true;
                        break;
                    }
                if (!found) count++;                
            }
            return count;
        }
        public int EqualToValue(int valueToCompare)
        {
            int count = 0;
            foreach (var a in integ)
                if(a==valueToCompare)
                    count++;
            return count;
        }
    }
}
