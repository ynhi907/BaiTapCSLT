/*
 * Bài: Buoi01_B3 - Sửa lỗi chương trình cho sẵn
 * Sinh viên: [Nguyễn Ngọc Yến Nhi] - MSSV: [31251024414]
 * Ngày: 20/10/2026
 */

namespace Buoi01_B3
{
    internal class program // giữ nguyên: tên lớp viết thường vẫn hợp lệ
    {
        static void Main(string[] args) // sửa: main -> Main (C# phân biệt hoa thường, lỗi CS5001)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // sửa: thiếu dấu ; cuối dòng
            Console.WriteLine("Chương trình có lỗi"); // sửa: console -> Console; thiếu dấu " đóng chuỗi
            Console.WriteLine("Đường dẫn: C:\\Temp\\new"); // sửa: Writeline -> WriteLine; \T sai escape và \n là xuống dòng nên phải viết \\
            Console.WriteLine("Kết thúc"); // sửa: nháy đơn ' ' chỉ dành cho 1 ký tự, chuỗi phải dùng nháy kép " "
        }
    }
} // sửa: thiếu một dấu } đóng namespace