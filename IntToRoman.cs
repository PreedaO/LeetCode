using System;
using System.Text;

namespace IntToRoman
{
    class Program
    {
        static string IntToRoman(int num)
        {
            StringBuilder sb = new StringBuilder();

            StringBuilder s = new StringBuilder(Convert.ToString(num));

            if (s.Length == 4)
            {
                if (s[0] == '3') { sb.Append("MMM"); }
                if (s[0] == '2') { sb.Append("MM"); }
                if (s[0] == '1') { sb.Append("M"); }

                s.Remove(0, 1);
            }

            if (s.Length == 3)
            {
                if (s[0] == '9') { sb.Append("CM"); }
                if (s[0] == '8') { sb.Append("DCCC"); }
                if (s[0] == '7') { sb.Append("DCC"); }
                if (s[0] == '6') { sb.Append("DC"); }
                if (s[0] == '5') { sb.Append("D"); }
                if (s[0] == '4') { sb.Append("CD"); }
                if (s[0] == '3') { sb.Append("CCC"); }
                if (s[0] == '2') { sb.Append("CC"); }
                if (s[0] == '1') { sb.Append("C"); }

                s.Remove(0, 1);
            }

            if (s.Length == 2)
            {
                if (s[0] == '9') { sb.Append("XC"); }
                if (s[0] == '8') { sb.Append("LXXX"); }
                if (s[0] == '7') { sb.Append("LXX"); }
                if (s[0] == '6') { sb.Append("LX"); }
                if (s[0] == '5') { sb.Append("L"); }
                if (s[0] == '4') { sb.Append("XL"); }
                if (s[0] == '3') { sb.Append("XXX"); }
                if (s[0] == '2') { sb.Append("XX"); }
                if (s[0] == '1') { sb.Append("X"); }

                s.Remove(0, 1);
            }

            if (s.Length == 1)
            {
                if (s[0] == '9') { sb.Append("IX"); }
                if (s[0] == '8') { sb.Append("VIII"); }
                if (s[0] == '7') { sb.Append("VII"); }
                if (s[0] == '6') { sb.Append("VI"); }
                if (s[0] == '5') { sb.Append("V"); }
                if (s[0] == '4') { sb.Append("IV"); }
                if (s[0] == '3') { sb.Append("III"); }
                if (s[0] == '2') { sb.Append("II"); }
                if (s[0] == '1') { sb.Append("I"); }
            }

            return sb.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IntToRoman(3999));
        }
    }
}
