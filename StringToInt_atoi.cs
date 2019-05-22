using System;
using System.Text;

namespace StringToInt_atoi
{
    class Program
    {
        static int MyAtoi(string str)
        {
            if (String.IsNullOrEmpty(str))
            {
                return 0;
            }

            bool isMinusSign = false;
            bool isPlusSign = false;
            bool isTrailingSpace = false;
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if (c == ' ')
                {
                    if (sb.Length > 0)
                    {
                        isTrailingSpace = true;
                    }

                    if (isPlusSign)
                    {
                        break;
                    }
                    continue;
                }

                if (isTrailingSpace == true)
                {
                    break;
                }

                // Handle double minus sign
                if (c == '-' && isMinusSign)
                {
                    break;
                }

                if (c == '-' && isMinusSign == false)
                {
                    isMinusSign = true;

                    if (sb.Length == 0)
                    {
                        sb.Append("-");
                    }
                    else
                    {
                        break;
                    }
                }

                if (c == '+')
                {
                    // Handle double plus signs
                    if (isPlusSign)
                    {
                        break;
                    }

                    isPlusSign = true;

                    if (sb.Length == 0)
                    {
                        sb.Append("+");
                    }
                    continue;
                }

                if (isPlusSign && isMinusSign)
                {
                    break;
                }

                if (Char.IsDigit(c))
                {
                    sb.Append(c);
                }

                if ((c != '-') && !Char.IsDigit(c))
                {
                    break;
                }
            }

            if (sb.Length == 0)
            {
                return 0;
            }

            if (sb.Length == 1 && (sb[0] == '-' || sb[0] == '+'))
            {
                return 0;
            }

            int result = 0;
            try
            {
                result = Int32.Parse(sb.ToString());
            }
            catch (OverflowException)
            {
                return (isMinusSign) ? Int32.MinValue : Int32.MaxValue;
            }

            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MyAtoi("42"));
            Console.WriteLine(MyAtoi("-42"));
            Console.WriteLine(MyAtoi("4193 with words"));
            Console.WriteLine(MyAtoi("words and 987"));
            Console.WriteLine(MyAtoi("-91283472332"));
        }
    }
}
