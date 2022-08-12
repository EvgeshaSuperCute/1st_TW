using System;

namespace _1st_TW_App
{
    class Program
    {
        static void Print(String[] strs)
        {
            Console.Write("[");
            foreach (var i in strs)
            {
                Console.Write("{0}   ", i);
            }
            Console.WriteLine("]");
        }

        static String[] FormOutString(String[] strs)
        {
            int pos = 0;

            String[] res_str = new String[0];

            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i].Length <= 3)
                {
                    Array.Resize(ref res_str, res_str.Length + 1);
                    res_str[pos] = strs[i];
                    pos++;
                }
            }

            return res_str;

        }

        static String[] RandomString()
        {
            var r = new Random();
            String[] str = new string[0];

            for (int i = 0; i < r.Next(3, 20); i++)
            {
                Array.Resize(ref str, str.Length + 1);

                for (int j = 0; j < r.Next(1, 9); j++)
                {
                    str[i] += (char)(r.Next(32, 127));
                }
            }


            return str;
        }

        static void Main(string[] args)
        {

            String[] str = RandomString();
            Print(str);

            Print(FormOutString(str));

        }
    }
}
