using System;
using System.Collections.Generic;

namespace TechReturners.Exercises
{
    public class Exercise001
    {
        public static String CapitalizeWord(String word) 
        {
            return word.Length > 0 ? char.ToUpper(word[0]) + word.Substring(1) : "";
           
        }

        public static String GenerateInitials(String firstName, String lastName) 
        {
            return (firstName[0].ToString() + "." + lastName[0].ToString()).ToUpper();
           
        }

        public static double AddVat(double originalPrice, double vatRate) 
        {
            return Math.Round((originalPrice * ((vatRate + 100) / 100)),2);
           
        }

        public static String Reverse(String sentence) 
        {
           char[] arr = sentence.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
           
        }

        public static int CountLinuxUsers(List<User> users) 
        {
            int count = 0;
            for(int i=0; i<users.Count; i++)
            {
                var user = users[i];
                if(user.Type == "Linux")
                {
                    count += 1;
                }
            }
            return count;
            
        }
    }
}
