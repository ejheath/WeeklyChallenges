using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return (vals.Length % 2 == 0);
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 1)
            {
                return true;
            }
            else if (num % 2 == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            double max, min;
            max = double.MinValue;
            min = double.MaxValue;
            if (numbers != null)
            {
                foreach (var num in numbers)
                {
                    if (num > max)
                    {
                        max = num;
                    }
                    if (num < min)
                    {
                        min = num;
                    }
                }
            }
            return min + max;
        }





        public int GetLengthOfShortestString(string str1, string str2)
        {
            //find min of string.Length

            if (str1.Length < str2.Length)
            {
                return str1.Length;
            } else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            int answer = 0;
            if (numbers == null)
            {
                return 0;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                 answer += numbers[i]; 
            }
            return answer; 
        }

        public int SumEvens(int[] numbers)
        {
            int answer = 0;
            if (numbers == null)
            {
                return 0;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    answer += numbers[i];
                }
            
            }
                return answer;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;

            if (numbers != null && numbers.Count != 0)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    sum += numbers[i];
                }
              
            }
            return sum % 2 == 0 ? false : true;

        }
      

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            int counter = 0;

            //one number is max and odds are counted up until they reach max number

            if (number < 0)
            {
                return counter;
            }
            for(int i = 0; i < number; i++)
            {
                if (i % 2 != 0)
                {
                    counter++;
                }
                
            }
            return counter;
        }
    }

}

