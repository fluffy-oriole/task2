namespace task2
{
    public class Logic
    {
        public static int FindSequenceNumber(List<int> sequence, int count, int n)
        {
            int sequenceNumber = -1;
            int repeatCount = 0;
            int previousNumber = -1;
            for (int i = 0; i < count; i++)
            {
                if (sequence[i] == previousNumber)
                {
                    repeatCount++;
                }
                else
                {
                    repeatCount = 1;
                    previousNumber = sequence[i];
                    sequenceNumber = i;
                }
                if (repeatCount == n)
                {
                    return sequenceNumber;
                }
            }
            return -1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            List<int> sequence = new List<int> { };
            Console.WriteLine("Вводите значения (конец ввода - пустая строка)");
            string inputNumber = "";
            while (true)
            { 
                Console.Write((count + 1).ToString() + " элемент = ");
                inputNumber = Console.ReadLine();
                if  (string.IsNullOrEmpty(inputNumber))
                {
                    break;
                }
                sequence.Add(int.Parse(inputNumber));
                count++;
            }
            Console.Write("Введите длину последовательности чисел для поиска: ");
            int n = int.Parse(Console.ReadLine());
            int number = Logic.FindSequenceNumber(sequence, count, n);
            if (number != -1)
            {
                Console.WriteLine("Номер первого элемента подпоследовательности такой длины - " + number);
            }
            else
            {
                Console.WriteLine("Подпоследовательности такой длины нет");
            }
        }
    }
}
