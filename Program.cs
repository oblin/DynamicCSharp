using System;

using static System.Console;

namespace CsharpDynamic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            OutputTimeStaticBinding();
            OutputTimeDynamicBinding();
            OutputTimeDynamicBindingRunTimeError();
            
            WriteLine("\n Press enter to leave...");
            ReadLine();
        }
        public static void OutputTimeStaticBinding()
        {
            DateTime dt = DateTime.Now;
            string time = dt.ToString("yyyy-MM-dd");

            WriteLine(time);
        }
        public static void OutputTimeDynamicBinding()
        {
            dynamic dt = DateTime.Now;
            string time = dt.ToString("yyyy-MM-dd");

            WriteLine(time);
        }

        public static void OutputTimeDynamicBindingRunTimeError()
        {
            dynamic dt = DateTime.Now;
            string time = dt.IsCoffeeTime();
        }
    }
}
