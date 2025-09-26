using System;
using System.IO;
using System.Text;
namespace cwaciklama
{
    internal class Program
    {
        static void Main(string[] args)
        {//Console.Writeline kopyası (copy of Console.WriteLine)
            MyConsole.WriteLine("Merhab Dünya!");
            MyConsole.WriteLine("console writeline aciklamasi");
        }
    }
    internal static class MyConsole
    {
        //String için overload
        public static void WriteLine(string value)
        {
            Write(value);
            WriteLine(Environment.NewLine); // satır sonu yeni line
        }
        //Int için overload
        public static void WriteLine(int value)
        {
            Write(value.ToString());
            Write(Environment.NewLine);
        }
        // Bool için overload
        public static void WriteLine(bool value)
        {
            Write(value.ToString());
            Write(Environment.NewLine);
        }
        //Asil işi yapan kisim: 
        private static void Write(string value)
        {
            //Encoding UTF-8 ile string > byte[]
            byte[] buffer = Encoding.UTF8.GetBytes(value);
            //stdout = 1 > işletim sisteminde standart çıktı.
            using var stdout = Console.OpenStandardOutput();
            stdout.Write(buffer, 0, buffer.Length);
            stdout.Flush(); //buffer temizlenip hemen yazılır.
        }
    }
}
