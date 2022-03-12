using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals.Contains(false))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }

            var sum = numbers.Sum();

            if (sum % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

            public bool PasswordContainsUpperLowerAndNumber(string password)
            {

            bool IsUpper = false;
            bool IsLower = false;
            bool IsNumber = false;

            for(int i = 0; i < password.Length; i++)
            {
                if (Char.IsUpper(password[i]))
                {
                    IsUpper = true;
                }
                if (Char.IsLower(password[i]))
                {
                    IsLower = true;
                }
                if (Char.IsNumber(password[i]))
                {
                    IsNumber = true;
                }
            }

            if (IsUpper == true && IsLower == true && IsNumber == true)
            {
                return true;
            }
            return false;
        }
     

        public char GetFirstLetterOfString(string val)
        {
            char charAt = val[0];
            return charAt;
        }

        public char GetLastLetterOfString(string val)
        {

            char lastCharacter = val[val.Length - 1];
            return lastCharacter;

        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
                return 0;
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var odds = new List<int>(); 

            for(int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    odds.Add(i);
                }
                
            }
            return odds.ToArray();
        }
        
        public void ChangeAllElementsToUppercase(string[] words)
        {
            
            for(int i = 0; i < words.Length; i++)
            {
                
                words[i] = words[i].ToUpper();
            }
        }
    }
}
