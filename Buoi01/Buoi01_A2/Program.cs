/*
 * Bài: Buoi01_A2 - Thẻ giới thiệu bản thân
 * Sinh viên: Nguyễn Ngọc Yến Nhi
 * MSSV: [31251024414]
 * Ngày: 20/10/2026
 */

using System;

namespace Buoi01_A2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            // Phần đầu thẻ
            Console.WriteLine("==============================");
            Console.WriteLine("        THẺ SINH VIÊN         ");
            Console.WriteLine("==============================");

            // Nhãn in bằng Write (không xuống dòng), giá trị in bằng WriteLine
            Console.Write("Họ tên  : ");
            Console.WriteLine("Nguyễn Ngọc Yến Nhi");
            Console.Write("MSSV    : ");
            Console.WriteLine("[31251024414]"); // Bạn hãy thay [mã số] bằng mã sinh viên thật
            Console.Write("Lớp     : ");
            Console.WriteLine("EE0001");
            Console.Write("Sở thích: ");
            Console.WriteLine("xem phim, đọc sách");

            // Phần cuối thẻ
            Console.WriteLine("==============================");
        }
    }
}