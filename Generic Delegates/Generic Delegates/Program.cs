using System;

namespace Generic_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericDelegates genericDelegates = new GenericDelegates();

            #region Qst 01
            //genericDelegates.smallestNum(25,37,29);
            #endregion

            #region Qst 02
            //genericDelegates.avgNum(25,45,65);
            #endregion

            #region Qst 03
            //genericDelegates.print("350");
            #endregion

            #region Qst 04
            //Console.WriteLine(genericDelegates.vowels("w3resource"));
            #endregion

            #region Qst 05
            //Console.WriteLine(genericDelegates.countWords("The quick brown fox jumps over the lazy dog"));
            #endregion

            #region Qst 06
            //genericDelegates.sumNum("25");
            #endregion
        }
    }

    class GenericDelegates
    {
        #region Qst 01
        public Action<int, int, int> smallestNum = (num1, num2, num3) =>
        {
            FindSmallestNum(num1, num2, num3);
        };
        private static void FindSmallestNum(int num1, int num2, int num3)
        {
            if (num1 < num2 && num1 < num3) //3,2,1
            {
                Console.WriteLine($"{num1} is the num1 and his smallest one");
            }
            else if (num2 < num3)
            {
                Console.WriteLine($"{num2} is the num2 and his smallest one");
            }
            else
            {
                Console.WriteLine($"{num3} is the num3 and his smallest one");
            }
        }
        #endregion

        #region Qst 02
        public Action<int, int, int> avgNum = (num1, num2, num3) =>
        {
            GetAvgNum(num1, num2, num3);
        };

        private static void GetAvgNum(int num1, int num2, int num3)
        {
            int result = num1 + num2 + num3;
            Console.WriteLine(result / 3);
        }
        #endregion

        #region Qst 03
        public Func<string, string> print = (name) =>
       {
           string middle;
           if (name.Length % 2 == 0)
           {
               //Here if my [name.Length] is (4) for example (3540).So we do [name.Length / 2] will be [Equal / (=)] To (2) But we want to print only (1) So we do (-1).Continue DownVV.
               middle = (name[name.Length / 2] - 1).ToString(); ;
           }
           else
           {
               //Here my [name.Length] is (3) because we [Pass] in (350). So we do [name.Length / 2] will be [Equal / (=)] To (1). Continue Down VV.
               //So now instead of having (name[name.Length / 2]) it will be (name[1]) Which is The [Second] [Positin] in (array[]).And the [Second] [Positin] in this case will be (5). 
               middle = (name[name.Length / 2]).ToString();
           }
           Console.WriteLine(middle);
           return middle;
       };

        #endregion

        #region Qst 04
        public Func<string, int> vowels = (name) =>
        {
            int count = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if (name.ToLower()[i] == 'a' || name.ToLower()[i] == 'e' || name.ToLower()[i] == 'i' || name.ToLower()[i] == 'o' || name.ToLower()[i] == 'u' || name.ToLower()[i] == 'y')
                {
                    count++;
                }
            }
            return count;
        };
        #endregion

        #region Qst 05
        public Func<string, int> countWords = (wordsCounter) =>
       {
           int count = 1;
           for (int i = 0; i < wordsCounter.Length; i++)
           {
               if (wordsCounter[i].ToString() == " ")
               {
                   if (wordsCounter[i + 1].ToString() == " ")
                   {
                       continue;
                   }
                   count++;
               }
           }
           return count;
       };
        #endregion

        #region Qst 06
        public Action<string> sumNum = (num1) =>
         {
             GetSum(num1);
         };
        private static void GetSum(string num1)
        {
            int sum = 0;
            int result = 0;
            for (int i = 0; i < num1.Length; i++)
            {
                sum = Convert.ToInt32(num1[i].ToString());
                result += sum;
            }
            Console.WriteLine(result);
        }
        #endregion
    }
}
