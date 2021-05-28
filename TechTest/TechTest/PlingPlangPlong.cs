using System;

namespace TechTest
{
    static public class TechTestClass
    {
        public static string PlingPlangPlong(int x)
        {
            string result = "";
            if (x % 3 == 0)
            {
                result +="Pling";
            }
            if (x % 5 == 0)
            {
                result += "Plang";
            }
            if (x % 7 == 0)
            {
                result += "Plong";
            }
            
            return result == ""?x.ToString():result;
        }
    }
}
