/*
 * Bài: Buoi01_B1 - Thời khóa biểu canh cột
 * Sinh viên: [Nguyễn Ngọc Yến Nhi] - MSSV: [31251024414]
 * Ngày: 20/10/2026
 */

namespace Buoi01_B1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Toàn bộ bảng chỉ dùng MỘT lệnh WriteLine:
            // \n xuống dòng, \t nhảy tới điểm dừng tab kế tiếp (mỗi 8 ký tự).
            // Cột Sáng: nội dung < 8 ký tự dùng 2 tab, nội dung từ 8 đến 15 ký tự dùng 1 tab.
            Console.WriteLine(
                "THỜI KHÓA BIỂU TUẦN 1\n" +
                "Thứ\tSáng\t\tChiều\n" +
                "Hai\tCSLT\t\t(trống)\n" +
                "Ba\t(trống)\t(trống)\n" +
                "Tư\tKinh tế vi mô\t(trống)\n" +
                "Năm\tCSLT\t\t(trống)\n" +
                "Sáu\t(trống)\t\tToán CC");
        }
    }
}