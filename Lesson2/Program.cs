namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UpToMultiply(421);
            SumOfNum(321);
            SimpleAndComplexNumbers(323);
        }
        //Task1
        public static void UpToMultiply(int InputNumber)
        {
            
            int startNum = 2;
            int caunt = 1;
            while (InputNumber > startNum)
            {
                startNum *= 2;
                caunt++;
                
            }
            int first = InputNumber - startNum/2;
            int second = startNum - InputNumber;
            if (first <= second)
            {
                Console.WriteLine("Task1");
                Console.WriteLine(--caunt);

            }
            else
            {
                Console.WriteLine("Task1");
                Console.WriteLine(caunt);
            }
        }

        //Task2
        public static void SumOfNum(int input)
        {
            
            int res = 0;
            while (input > 0)
            {
                int value = input % 10;
                input /= 10;
                res += value;
                
            }
            Console.WriteLine("Task2");
            Console.WriteLine(res);
        }

        //Task2
        public static void SimpleAndComplexNumbers(int num)
        {
            int count = 0;
            if (num > 0 && num != 0)
            {
                
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                        
                        
                    }

                }
                if (count > 2)
                {
                    Console.WriteLine("Task3");
                    Console.WriteLine("murekkebdi");
                }
                else
                {
                    Console.WriteLine("Task3");
                    Console.WriteLine("sadedi");
                }
            }
            else
            {
                Console.WriteLine("Task3");
                Console.WriteLine("incorrect input");
            }
            
            
        }

    }
}