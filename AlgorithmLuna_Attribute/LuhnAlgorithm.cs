using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmLuna_Attribute
{
    public class LuhnAlgorithm
    {
        public bool IsValid(object value)
        {
            long number;
            string code = value.ToString();
            if (value != null && long.TryParse(code, out number))
            {
                int digitCount = (int)Math.Log10(number) + 1;
                if (digitCount == 16)
                {
                    long[] array = new long[digitCount];
                    long sum = 0, p = 0;
                    for (int i = 0; i < digitCount; i++)
                    {
                        array[i] = number % 10;
                        number /= 10;
                    }

                    for (int i = 0; i < digitCount; i++)
                    {
                        p = array[digitCount - 1 - i];
                        if (i % 2 == 0)
                        {
                            p = 2 * p;
                            if (p > 9)
                                p = p - 9;
                        }
                        sum = sum + p;
                    }

                    if (sum % 10 == 0)
                    {
                        return true;
                    }

                    return false;
                }
                return false;
            }
            return false;
        }
    }
}
