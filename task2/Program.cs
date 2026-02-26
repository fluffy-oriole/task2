namespace task2
{
    public class Logic
    {
        public static String FindSequenceNumber(List<int> sequence, int n)
        {
            int sequenceNumber = -1;
            int repeatCount = 0;
            int previousNumber = -1;
            String answer = "";
            for (int i = 0; i < sequence.Count; i++)
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
                    for (int j = sequenceNumber; j < sequenceNumber + n; j++)
                    {
                        answer += j.ToString() + " ";
                    }
                    break;
                }
            }
            if (answer != "")
            {
                return answer.Remove(answer.Length - 1);
            }
            else
            {
                return "Такой последовательности нет";
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = new List<int> { };
            Console.WriteLine("Вводите значения (конец ввода - пустая строка)");
            string inputNumber = "";
            while (true)
            {
                Console.Write("Элемент = ");
                inputNumber = Console.ReadLine();
                if (string.IsNullOrEmpty(inputNumber))
                {
                    break;
                }
                sequence.Add(int.Parse(inputNumber));
            }
            Console.Write("Введите длину последовательности чисел для поиска: ");
            int n = int.Parse(Console.ReadLine());
            string number = Logic.FindSequenceNumber(sequence, n);
            Console.WriteLine(number);
        }
    }
}
