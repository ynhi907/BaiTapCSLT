/*
 * Bài: Buoi01_B2 - Thiệp chúc mừng Ngày Nhà giáo Việt Nam 20/11
 * Sinh viên: [Nguyễn Ngọc Yến Nhi] - MSSV: [31251024414]
 * Ngày: 20/10/2026
 */

namespace Buoi01_B2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Mỗi dòng dài đúng 40 ký tự: 1 dấu * + 38 ký tự bên trong + 1 dấu *
            // Dấu nháy kép trong chuỗi phải viết \" (ký tự escape)
            Console.WriteLine("****************************************");
            Console.WriteLine("*                                      *");
            Console.WriteLine("*       CHÚC MỪNG NGÀY NHÀ GIÁO        *");
            Console.WriteLine("*            VIỆT NAM 20/11            *");
            Console.WriteLine("*                                      *");
            Console.WriteLine("*          Học trò kính chúc:          *");
            Console.WriteLine("*      \"Thầy cô luôn mạnh khỏe!\"       *");
            Console.WriteLine("*                                      *");
            Console.WriteLine("*   Sinh viên: [Nguyễn Ngọc Yến Nhi]   *");
            Console.WriteLine("*                                      *");
            Console.WriteLine("****************************************");
        }
    }
}