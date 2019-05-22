using System;

namespace RomanToInt
{
    class Program
    {
        static int RomanToInt(string s)
        {
            int val = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'I')
                {
                    if (i < s.Length - 1 && s[i + 1] == 'V')
                    {
                        val += 4;
                        i++;
                        continue;
                    }
                    else if (i < s.Length - 1 && s[i + 1] == 'X')
                    {
                        val += 9;
                        i++;
                        continue;
                    }
                    else
                    {
                        val += 1;
                    }
                }

                if (s[i] == 'X')
                {
                    if (i < s.Length - 1 && s[i + 1] == 'L')
                    {
                        val += 40;
                        i++;
                        continue;
                    }
                    else if (i < s.Length - 1 && s[i + 1] == 'C')
                    {
                        val += 90;
                        i++;
                        continue;
                    }
                    else
                    {
                        val += 10;
                    }
                }

                if (s[i] == 'C')
                {
                    if (i < s.Length - 1 && s[i + 1] == 'D')
                    {
                        val += 400;
                        i++;
                        continue;
                    }
                    else if (i < s.Length - 1 && s[i + 1] == 'M')
                    {
                        val += 900;
                        i++;
                        continue;
                    }
                    else
                    {
                        val += 100;
                    }
                }

                if (s[i] == 'V')
                {
                    val += 5;
                }
                if (s[i] == 'L')
                {
                    val += 50;
                }
                if (s[i] == 'D')
                {
                    val += 500;
                }
                if (s[i] == 'M')
                {
                    val += 1000;
                }
            }

            return val;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("MCMXCIV"));
        }
    }
}
