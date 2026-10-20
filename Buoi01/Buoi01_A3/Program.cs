/*
 * Bài: Buoi01_A3 - Vẽ hình bằng ký tự
 * Sinh viên: Nguyễn Ngọc Yến Nhi
 * MSSV: [31251024414]
 * Ngày: 20/10/2026
 */

using System;

namespace Buoi01_A3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- CÁCH 1: Vẽ tam giác (mỗi dòng một lệnh WriteLine) ---");
            Console.WriteLine("   *");
            Console.WriteLine("  ***");
            Console.WriteLine(" *****");
            Console.WriteLine("*******");
            Console.WriteLine();

            Console.WriteLine("--- CÁCH 2: Vẽ tam giác (gộp một lệnh dùng \\n) ---");
            Console.WriteLine("   *\n  ***\n *****\n*******");
            Console.WriteLine();

            Console.WriteLine("--- CÁCH 3: Vẽ ngôi nhà (dùng ký tự escape \\\\) ---");
            Console.WriteLine("   /\\");
            Console.WriteLine("  /  \\");
            Console.WriteLine(" /____\\");
            Console.WriteLine(" |    |");
            Console.WriteLine(" |_[]_|");
            Console.WriteLine();

            Console.WriteLine("--- CÁCH 4: Vẽ ngôi nhà (dùng chuỗi nguyên văn @) ---");
            Console.WriteLine(@"   /\
  /  \
 /____\
 |    |
 |_[]_|");
        }
    }
}