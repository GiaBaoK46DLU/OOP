using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiOnTapHK2
{
    class Program
    {
        public enum Menu
        {
            Thoat = 1,
            DocTuFile,
            XuatDanhSach,
            TimNhanVienLonTuoiNhat,
            SapXepDanhSachTangTheoNamSinh,
            XoaNVTheoTenChoTruoc,
            TimTenNhanVienCoNguoiThanLamCung,
            LietKe
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DanhSachNhanVien dsnv = new DanhSachNhanVien();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("----------CHỌN CHỨC NĂNG----------");
                Console.WriteLine("1.Thoát khỏi chương trình ");
                Console.WriteLine("2.Nhập danh sách nhân viên từ file ");
                Console.WriteLine("3.Xuất danh sách nhân viên ");
                Console.WriteLine("4.Tìm những nhân viên lớn tuổi nhất ");
                Console.WriteLine("5.Sắp xếp danh sách nhân viên tăng theo năm sinh ");
                Console.WriteLine("6.Xóa nhân viên theo tên cho trước ");
                Console.WriteLine("7.Tìm những tên nhân viên có người thân làm cùng ");
                Console.WriteLine("8.Liệt kê danh sách năm sinh và số nhân viên tương ứng ");
                Console.WriteLine("-----------------------------------");
                Console.Write("Chọn chức năng : ");
                Menu chon = (Menu)int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case Menu.Thoat:
                        Console.WriteLine("1.Thoát khỏi chương trình ");
                        break;
                    case Menu.DocTuFile:
                        Console.Clear();
                        Console.WriteLine("2.Nhập danh sách nhân viên từ file ");
                        dsnv.NhapTuFile("dsnhanvien.txt");
                        break;
                    case Menu.XuatDanhSach:
                        Console.Clear();
                        Console.WriteLine("3.Xuất danh sách nhân viên ");
                        Console.WriteLine(dsnv);
                        break;
                    case Menu.TimNhanVienLonTuoiNhat:
                        Console.Clear();
                        Console.WriteLine("4.Tìm những nhân viên lớn tuổi nhất ");
                        Console.WriteLine(dsnv.NVLonTuoiNhat());
                        break;
                    case Menu.SapXepDanhSachTangTheoNamSinh:
                        Console.Clear();
                        Console.WriteLine("5.Sắp xếp danh sách nhân viên tăng theo năm sinh ");
                        dsnv.SapXepDanhSach(Program.TangTheoNam);
                        Console.WriteLine(dsnv);
                        break;
                    case Menu.XoaNVTheoTenChoTruoc:
                        Console.Clear();
                        Console.WriteLine(dsnv);
                        Console.WriteLine("6.Xóa nhân viên theo tên cho trước ");
                        Console.WriteLine("Nhập tên nhân viên muốn xóa: ");
                        string t = Console.ReadLine();
                        dsnv.XoaNV(t);
                        Console.WriteLine(dsnv);
                        break;
                    case Menu.TimTenNhanVienCoNguoiThanLamCung:
                        Console.Clear();
                        Console.WriteLine("7.Tìm những tên nhân viên có người thân làm cùng ");
                        Console.WriteLine(dsnv.TimTenNVCoNguoiThanLamCung());
                        break;
                    case Menu.LietKe:
                        Console.Clear();
                        Console.WriteLine("8.Liệt kê danh sách năm sinh và số nhân viên tương ứng ");
                        break;
                }
                Console.WriteLine("Bấm phím bất kỳ để tiếp tục");
                Console.ReadKey();
            }
        }
        static int TangTheoNam(object a, object b)
        {
            iNhanVien x = (iNhanVien)a;
            iNhanVien y = (iNhanVien)b;
            return -x.NamSinh.CompareTo(y.NamSinh);
        }
    }
}
