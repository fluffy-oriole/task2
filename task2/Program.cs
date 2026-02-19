namespace task2
{
    public class Logic
    {
        public static int FindSequenceNumber(int[] sequence, int count, int n)
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
            Console.Write("Введите количество чисел последовательности: ");
            int count = int.Parse(Console.ReadLine());
            int[] sequence = new int[count];
            for (int i = 0; i < count; i++)
            {
                Console.Write((i + 1).ToString() + " элемент = ");
                sequence[i] = int.Parse(Console.ReadLine());
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
