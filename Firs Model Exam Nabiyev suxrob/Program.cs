namespace firstModulExam
{
    public class Program
    {
        //1-variant
        static void Main(string[] args)
        {
           
        }

        //1-savol
        public static int EvenNumberscounter(List<int> numbers)
        {
            var evenCounter = 0;
            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 ==0)
                {
                    evenCounter++;
                }
            }
            return evenCounter;
        }

        //2-savol
        public static bool TextLength(List<string> texts)
        {
            foreach (var text in texts)
            {
                if (text.Length>5)
                {
                    return true;
                }
            }
            return false;
        }

        //3-savol
        public static string StartTreeWord(string text)
        {
            if (text.Length>2)
            {
                return text.Substring(0, 3);
            }

            return text;
        }
        //4-savol
        public static bool StartPdpWord(string text)
        {
            if (text.Length>2)
            {
                return text.StartsWith("PDP");
            }
            return false;
        }

    }
}
