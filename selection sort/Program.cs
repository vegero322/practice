namespace practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину списка: ");
            int lenght = int.Parse(Console.ReadLine());

            Random random = new Random();
            byte[] numbers = new byte[lenght];

            random.NextBytes(numbers);
            Console.WriteLine("Изначальный список: ");
            ShowArray(numbers);

            SorttingArray(numbers);
            Console.WriteLine("Отсортированный список: ");
            ShowArray(numbers);
        }

        static void ShowArray(byte[] numbers)
        {
            foreach (byte number in numbers)
            {
                Console.Write(number + "\t");
            }
            Console.WriteLine();
        }

        static byte[] SorttingArray(byte[] numbers)
        {
            
            for (int i = 0; i < numbers.Length - 1; ++i)
            {
                byte minValue = numbers[i];
                int minIterValue = i;

                for (int j = i + 1; j < numbers.Length; ++j)
                {                    
                    if (numbers[j] < minValue)
                    {
                        minValue = numbers[j];
                        minIterValue = j;
                    }                       
                }

                var temp = numbers[i];
                numbers[i] = numbers[minIterValue];
                numbers[minIterValue] = temp;
            }
            
            return numbers;
        }
    }
}