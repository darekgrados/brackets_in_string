namespace brackets_in_string
{
    internal class Program
    {
        public static bool Solution(string input)
        {
            //deklaracja stosu do odkładania/zdejmowania znaków
            Stack<char> brackets = new Stack<char>();
            Dictionary<char, char> bracketPairs = new Dictionary<char, char>()
            {
                {'(', ')' },
                {'[', ']' },
                {'{', '}' },
                {'<', '>' },
            };

            try
            {
                foreach (var mark in input)
                {
                    if (bracketPairs.Keys.Contains(mark))
                        brackets.Push(mark);
                    else if (bracketPairs.Values.Contains(mark))
                    {
                        if (mark == bracketPairs[brackets.First()])
                            brackets.Pop();
                        else
                            return false;
                    }
                    else
                        continue;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return brackets.Count() == 0 ? true : false;
        }


        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string expresion = Console.ReadLine();
            Console.WriteLine(Solution(expresion));
        }
    }
}