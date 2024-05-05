using System;
using HelloWorld.Math;

namespace HelloWorld
{

    public enum MailType
    {
        Normal,
        Registered,
        Express
    }

    class Program
    {
        static void Main(string[] args)
        {
            int x = 1000;
            byte y = (byte)x;
            System.Console.WriteLine("{0} {1}", x, y);

            var stringNumber = "1234";
            var stringToInt = Convert.ToInt32(stringNumber);
            System.Console.WriteLine(stringToInt);
            try
            {
                var stringToByte = Convert.ToByte(stringNumber);
                System.Console.WriteLine(stringToByte);
            }
            catch (Exception)
            {
                System.Console.WriteLine("above string number cant be converted to byte");
            }

            string str = "false";
            System.Console.WriteLine(Convert.ToBoolean(str));

            System.Console.WriteLine(10 / (float)3);

            Calculator calc = new Calculator();
            //calc.add(10, 10); error

            System.Console.WriteLine(Calculator.add(3, 4));
            System.Console.WriteLine(Calculator.z);

            var numbers = new int[] { 1, 2, 3 };
            string str1 = string.Format("{0} {1}", 10, 20);
            string str2 = string.Join(",", numbers);
            System.Console.WriteLine(str1);
            System.Console.WriteLine(str2);


            string normalString = "first line\nsecond line\nsome path: c\\downloads\\myfolder\n";
            System.Console.WriteLine(normalString);

            string verbatimString =
            @"first line
second line
some path: c/downloads/myfolder";
            System.Console.WriteLine(verbatimString);

            System.Console.WriteLine(string.Format("{0} {1}", MailType.Express, (int)MailType.Express));
            var method = MailType.Express;
            System.Console.WriteLine(string.Format("{0} {1} {2}", method, (int)method, method.ToString()));

            var enumString = "Express";
            var getEnumFromString = (MailType)Enum.Parse(typeof(MailType), enumString); //hover on the variable

            var a = new Int32();
            var b = new Int32();
            a = 10;
            b = a;
            b++;
            System.Console.WriteLine("{0} {1}", a, b);
        }
    }
}
