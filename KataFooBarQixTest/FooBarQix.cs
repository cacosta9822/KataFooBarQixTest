using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace KataFooBarQixTest
{
    internal class FooBarQix
    {
        internal string compute(string v)
        {
            var result = String.Empty; ;
            var val = int.Parse(v);

            if (!ValidateNumberDivisibilityAble(val))
            {
                result = val.ToString().Replace('0','*');
            }
            else
            {
                if (IsDivisble(val, 3)) result += "Foo";
                if (IsDivisble(val, 5)) result += "Bar";
                if (IsDivisble(val, 7)) result += "Qix";

                result+=ReplaceChars(v);
            }

            return result;
        }

        private bool ValidateNumberDivisibilityAble(int number)
        {
            return (!IsDivisble(number, 3) && !(IsDivisble(number, 5)) && !(IsDivisble(number, 7))) ? false:true;
        }

        public bool IsDivisble(int x, int n)
        {
            return (x % n) == 0;
        }

        private string ReplaceChars(string lParameter)
        {
            StringBuilder sb = new StringBuilder(lParameter);
            sb.Replace("0", "*");
            sb.Replace("3", "Foo");
            sb.Replace("5", "Bar");
            sb.Replace("7", "Qix");

            return Regex.Replace(sb.ToString(), @"[\d-]", string.Empty);
        }        
    }
}