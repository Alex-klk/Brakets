using System;

namespace Clear_BracketsL
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Brackets("(a*(b-c)..... )") ➞ true
                
                Brackets(")(a-b-45/7*(a-34))") ➞ false
                
                Brackets("sin(90...)+.............cos1)") ➞ false
             */
            Console.WriteLine(Brackets(""));
        }
        public static bool Brackets(string memo)
        {
            var first = CountBrackets(memo, '(');
            var second = CountBrackets(memo, ')');
            return first == second ? true : false;
        }
        public static int CountBrackets(string memo, char brakect)
        {
            int count = 0;
            foreach (var charM in memo)
            {
                count += charM == brakect ? 1 : 0;
            }
            return count;
        }
    }
}
