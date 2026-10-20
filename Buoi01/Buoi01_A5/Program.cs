/*
 * Bài: Buoi01_A5 - Từ lưu đồ đến code: hình chữ nhật
 * Sinh viên: Nguyễn Ngọc Yến Nhi
 * MSSV: [31251024414]
 * Ngày: 20/10/2026
 */

using System;

namespace Buoi01_A5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            // NHẬP (tạm gán sẵn giá trị)
            double a = 5, b = 3;
            
            // XỬ LÝ
            double cv = 2 * (a + b);
            double dt = a * b;
            
            // XUẤT
            Console.WriteLine("Chiều dài = " + a);
            Console.WriteLine("Chiều rộng = " + b);
            Console.WriteLine("Chu vi = " + cv);
            Console.WriteLine("Diện tích = " + dt);
        }
    }
}