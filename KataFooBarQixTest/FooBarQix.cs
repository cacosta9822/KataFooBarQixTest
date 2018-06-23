using System;

namespace KataFooBarQixTest
{
    internal class FooBarQix
    {
        internal string compute(string v)
        {
            var result = String.Empty; ;
            var val = int.Parse(v);

            if (!(val % 3 == 0) && !(val % 5 == 0) && !(val % 7 == 0))
            {
                result = val.ToString().Replace('0','*');
            }
            else
            {
                if (val % 3 == 0)
                {
                    result += "Foo";
                }

                if (val % 5 == 0)
                {
                    result += "Bar";
                }

                if (val % 7 == 0)
                {
                    result += "Qix";
                }

                foreach (var item in v.ToCharArray())
                {
                    if (item == '0') result += '*';
                    if (item == '3') result = result + "Foo";
                    if (item == '5') result = result + "Bar";
                    if (item == '7') result = result + "Qix";

                }
            }

            //result = (val % 3 == 0) ? "Foo" : (val == 5 )? "Bar":val.ToString();
            return result;
        }
    }
}