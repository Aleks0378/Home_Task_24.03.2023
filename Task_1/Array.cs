using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{

    public interface ICalc
    {
        public int Less(int valueToCompare);
        public int Greater(int valueToCompare);
    }

    internal class MyArray: ICalc
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
    }
}
