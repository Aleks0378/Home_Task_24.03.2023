namespace Task_1
{
    internal class Program
    { 
       
        static void Main(string[] args)
        {
            Random rand = new Random();
            int size = 20;
            MyArray array = new MyArray(size);
            for (int i = 0;i<array.integ.Length;i++)
            {
                array.integ[i]=(rand.Next(0,20));
            }

            array.Show("All numbers of the array:");
            Console.WriteLine("\n\n");
            int number = 10;
            Console.WriteLine($"Quantity of numbers less than {number}: {array.Less(number)}");
            Console.WriteLine($"Quantity of numbers greater than {number}: {array.Greater(number)}");
        }
    }
}