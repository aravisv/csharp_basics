using System;
using HelloWorld.Math;
using System.Text;

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
            //             int x = 1000;
            //             byte y = (byte)x;
            //             System.Console.WriteLine("{0} {1}", x, y);

            //             var stringNumber = "1234";
            //             var stringToInt = Convert.ToInt32(stringNumber);
            //             System.Console.WriteLine(stringToInt);
            //             try
            //             {
            //                 var stringToByte = Convert.ToByte(stringNumber);
            //                 System.Console.WriteLine(stringToByte);
            //             }
            //             catch (Exception)
            //             {
            //                 System.Console.WriteLine("above string number cant be converted to byte");
            //             }

            //             string str = "false";
            //             System.Console.WriteLine(Convert.ToBoolean(str));

            //             System.Console.WriteLine(10 / (float)3);

            //             Calculator calc = new Calculator();
            //             //calc.add(10, 10); error

            //             System.Console.WriteLine(Calculator.add(3, 4));
            //             System.Console.WriteLine(Calculator.z);

            //             var numbers = new int[] { 1, 2, 3 };
            //             string str1 = string.Format("{0} {1}", 10, 20);
            //             string str2 = string.Join(",", numbers);
            //             System.Console.WriteLine(str1);
            //             System.Console.WriteLine(str2);


            //             string normalString = "first line\nsecond line\nsome path: c\\downloads\\myfolder\n";
            //             System.Console.WriteLine(normalString);

            //             string verbatimString =
            //             @"first line
            // second line
            // some path: c/downloads/myfolder";
            //             System.Console.WriteLine(verbatimString);

            //             System.Console.WriteLine(string.Format("{0} {1}", MailType.Express, (int)MailType.Express));
            //             var method = MailType.Express;
            //             System.Console.WriteLine(string.Format("{0} {1} {2}", method, (int)method, method.ToString()));

            //             var enumString = "Express";
            //             var getEnumFromString = (MailType)Enum.Parse(typeof(MailType), enumString); //hover on the variable

            //             var a = new Int32();
            //             var b = new Int32();
            //             a = 10;
            //             b = a;
            //             b++;
            //             System.Console.WriteLine("{0} {1}", a, b);

            //             var userName = Console.ReadLine();
            //             Console.WriteLine("Username is: " + userName);

            // var random = new Random();
            // var buffer = new char[10];
            // for (int i = 0; i < 10; i++)
            // {
            //     //System.Console.WriteLine(random.Next());
            //     //System.Console.WriteLine(random.Next(1, 10));
            //     buffer[i] = ((char)('a' + random.Next(0, 26)));
            // }
            // System.Console.WriteLine(new string(buffer));

            // int inputNumber = Convert.ToInt32(Console.ReadLine());
            // var factorial = 1;
            // while (inputNumber > 0)
            // {
            //     factorial *= inputNumber;
            //     inputNumber -= 1;
            // }
            // System.Console.WriteLine(factorial);

            // int[] arr = new int[] { 1, 2, 3, 4 };
            // System.Console.WriteLine(arr); //prints System.Int32[]
            // //Array.Clear(arr, 0, 1);  //0234
            // foreach (var item in arr)
            // {
            //     System.Console.Write(item);
            // }
            // System.Console.WriteLine();
            // int[] anotherArray = new int[3];
            // Array.Copy(arr, anotherArray, 2);
            // foreach (var item in anotherArray)
            // {
            //     System.Console.Write(item);
            // }
            // System.Console.WriteLine();

            // var list = new List<int>() { 7, 9 };
            // list.AddRange(new int[] { 1, 2, 3, 4 });
            // list.Add(8);
            // foreach (var item in list)
            // {
            //     System.Console.Write(item);
            // }

            // for (int i = 0; i < list.Count; i++)
            // {
            //     if (list[i] == 2)
            //     {
            //         list.Remove(list[i]);
            //     }
            // }
            // System.Console.WriteLine();
            // foreach (var item in list)
            // {
            //     System.Console.Write(item);
            // }
            // System.Console.WriteLine();
            // list.Sort();
            // foreach (var item in list)
            // {
            //     System.Console.Write(item);
            // }

            // var dateTime = DateTime.Now;
            // System.Console.WriteLine(dateTime.ToString("dd-MMM-yyyy"));

            // var newTime = dateTime.AddMinutes(2);

            // var timeSpan1 = new TimeSpan(1, 2, 3);
            // var timeSpan2 = timeSpan1.Add(TimeSpan.FromHours(1));
            // System.Console.WriteLine("{0} {1}", timeSpan1, timeSpan2);

            // const string name = "";
            // System.Console.WriteLine(String.IsNullOrWhiteSpace(name));

            var builder = new StringBuilder();
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Hello World");
            builder.AppendLine();
            builder.Append('-', 10);
            System.Console.WriteLine(builder);

        }
    }
}
