using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHinhHoc
{
    enum LoaiHinh
    {
        HinhTron,
        HinhChuNhat,
        HinhVuong
    }

    public enum Menu
    {
        DocTuFile = 1,
        TimHVCoCanhLonNhat,
        TimHVCoCanhNhoNhat,
        TimHCNCoChieuDaiNganNhat,
        TimHCNCoChieuDaiDaiNhat,
        SapXepCacHinhTheoChieuTangCuaDienTich,
        SapXepCacHinhTheoChieuGiamCuaDienTich,
        TongChuViCacHinh,
        TimHinhTronCoChuViNhoNhat,
        TimHinhTronCoChuViLonNhat,
        TimViTriHinhCoDienTichLonNhat,
        TimViTriHinhCoDienTichNhoNhat,
        TimViTriTheoHinh,
        TimViTriTheoDienTich,
        XoaTatCaCacHinhTheoDienTich,
        XoaHinhVuongCoDienTichLaX,
        ChenHinhTaiViTriX,
        XoaHinhTaiViTriX,
        TimLoaiHinhCoSoLuongNhieuNhat,
        TimLoaiHinhCoSoLuongItNhat
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            QuanLyHinhHoc qlhh = new QuanLyHinhHoc();
            while (true)
            {
                float min;
                float max;
                QuanLyHinhHoc dshcn;
                QuanLyHinhHoc dshv;
                QuanLyHinhHoc dsht;
                Console.Clear();
                Console.WriteLine("----------CHỌN CHỨC NĂNG----------");
                Console.WriteLine($"Chon {(int)Menu.DocTuFile} để đọc từ file");
                Console.WriteLine($"Chon {(int)Menu.TimHVCoCanhLonNhat} để tìm hình vuông có cạnh lớn nhất");
                Console.WriteLine($"Chon {(int)Menu.TimHVCoCanhNhoNhat} để tìm hình vuông có cạnh nhỏ nhất");
                Console.WriteLine($"Chon {(int)Menu.TimHCNCoChieuDaiNganNhat} để tìm hình chữ nhật có chiều dài ngắn nhất");
                Console.WriteLine($"Chon {(int)Menu.TimHCNCoChieuDaiDaiNhat} để tìm hình chữ nhật có chiều dài dài nhất");
                Console.WriteLine($"Chon {(int)Menu.SapXepCacHinhTheoChieuTangCuaDienTich} để sắp xếp các hình theo chiều tăng của diện tích");
                Console.WriteLine($"Chon {(int)Menu.SapXepCacHinhTheoChieuGiamCuaDienTich} để sắp xếp các hình theo chiều giảm của diện tích");
                Console.WriteLine($"Chon {(int)Menu.TongChuViCacHinh} để tính tổng chu vi các hình");
                Console.WriteLine($"Chon {(int)Menu.TimHinhTronCoChuViNhoNhat} để tìm hình tròn có chu vi nhỏ nhất");
                Console.WriteLine($"Chon {(int)Menu.TimHinhTronCoChuViLonNhat} để tìm hình tròn có chu vi lớn nhất");
                Console.WriteLine($"Chon {(int)Menu.TimViTriHinhCoDienTichLonNhat} để tìm vị trí hình có diện tích lớn nhất");
                Console.WriteLine($"Chon {(int)Menu.TimViTriHinhCoDienTichNhoNhat} để tìm vị trí hình có diện tích nhỏ nhất");
                Console.WriteLine($"Chon {(int)Menu.TimViTriTheoHinh} để tìm vị trí theo hình ");
                Console.WriteLine($"Chon {(int)Menu.TimViTriTheoDienTich} để tìm vị trí theo diện tích ");
                Console.WriteLine($"Chon {(int)Menu.XoaTatCaCacHinhTheoDienTich} để xóa các hình theo diện tích ");
                Console.WriteLine($"Chon {(int)Menu.XoaHinhVuongCoDienTichLaX} để xóa hình vuông có diện tích là  ... ");
                Console.WriteLine($"Chon {(int)Menu.ChenHinhTaiViTriX} để chèn hình tại vị trí ... ");
                Console.WriteLine($"Chon {(int)Menu.XoaHinhTaiViTriX} để xóa hình tại vị trí ... ");
                Console.WriteLine($"Chon {(int)Menu.TimLoaiHinhCoSoLuongNhieuNhat} để tìm loại hình có số lượng nhiều nhất ");
                Console.WriteLine($"Chon {(int)Menu.TimLoaiHinhCoSoLuongItNhat} để tìm loại hình có số lượng ít nhất ");
                Console.WriteLine("-----------------------------------");
                Console.Write("Chọn chức năng : ");
                Menu chon = (Menu)int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case Menu.DocTuFile:
                        Console.Clear();
                        qlhh.DocTuFile("Data.txt");
                        Console.WriteLine(qlhh);
                        break;
                    case Menu.TimHVCoCanhLonNhat:
                        Console.Clear();
                        Console.WriteLine(qlhh.ToString());
                        dshv = qlhh.TimHinh(hh => hh is HinhVuong);
                        max = dshv.Max(hv => hv.Canh);
                        Console.WriteLine("Hinh vuong co canh lon nhat la : ");
                        Console.WriteLine(dshv.TimHinh(h => ((HinhVuong)h).Canh == max));
                        break;
                    case Menu.TimHVCoCanhNhoNhat:
                        Console.Clear();
                        Console.WriteLine(qlhh.ToString());
                        dshv = qlhh.TimHinh(hh => hh is HinhVuong);
                        min = dshv.Min(hv => hv.Canh);
                        Console.WriteLine("Hinh vuong co canh nho nhat la : ");
                        Console.WriteLine(dshv.TimHinh(h => ((HinhVuong)h).Canh == min));
                        break;
                    case Menu.TimHCNCoChieuDaiNganNhat:
                        Console.Clear();
                        Console.WriteLine(qlhh.ToString());
                        dshcn = qlhh.TimHinh(hh => hh is HinhChuNhat);
                        min = dshcn.Min(hcn => ((HinhChuNhat)hcn).ChieuDai);
                        Console.WriteLine("Hinh chu nhat co chieu dai ngan nhat la : ");
                        Console.WriteLine(dshcn.TimHinh(h => ((HinhChuNhat)h).ChieuDai == min));
                        break;
                    case Menu.TimHCNCoChieuDaiDaiNhat:
                        Console.Clear();
                        Console.WriteLine(qlhh.ToString());
                        dshcn = qlhh.TimHinh(hh => hh is HinhChuNhat);
                        max = dshcn.Max(hcn => ((HinhChuNhat)hcn).ChieuDai);
                        Console.WriteLine("Hinh chu nhat co chieu dai dai nhat la : ");
                        Console.WriteLine(dshcn.TimHinh(h => ((HinhChuNhat)h).ChieuDai == max));
                        break;
                    case Menu.SapXepCacHinhTheoChieuTangCuaDienTich:
                        Console.Clear();
                        Console.WriteLine(qlhh.ToString());
                        Console.WriteLine("Sap xep cac hinh theo chieu tang cua dien tich la : ");
                        qlhh.SapXepDanhSach((hh1, hh2) => hh1.TinhDienTich() > hh2.TinhDienTich());
                        qlhh.Xuat();
                        break;
                    case Menu.SapXepCacHinhTheoChieuGiamCuaDienTich:
                        Console.Clear();
                        Console.WriteLine(qlhh.ToString());
                        Console.WriteLine("Sap xep cac hinh theo chieu giam cua dien tich la : ");
                        qlhh.SapXepDanhSach((hh1, hh2) => hh1.TinhDienTich() < hh2.TinhDienTich());
                        qlhh.Xuat();
                        break;
                    case Menu.TongChuViCacHinh:
                        Console.Clear();
                        Console.WriteLine(qlhh.ToString());
                        Console.WriteLine("Tong chu vi cac hinh");
                        Console.WriteLine(qlhh.Tong((hh) => hh.TinhChuVi()));
                        break;
                    case Menu.TimHinhTronCoChuViNhoNhat:
                        Console.Clear();
                        Console.WriteLine(qlhh.ToString());
                        dsht = qlhh.TimHinh(hh => hh is HinhTron);
                        min = dsht.Min(ht => ((HinhTron)ht).TinhChuVi());
                        Console.WriteLine("Hinh tron co chu vi nho nhat la : ");
                        Console.WriteLine(dsht.TimHinh(h => ((HinhTron)h).TinhChuVi() == min));
                        break;
                    case Menu.TimHinhTronCoChuViLonNhat:
                        Console.Clear();
                        Console.WriteLine(qlhh.ToString());
                        dsht = qlhh.TimHinh(hh => hh is HinhTron);
                        max = dsht.Max(ht => ((HinhTron)ht).TinhChuVi());
                        Console.WriteLine("Hinh tron co chu vi lon nhat la : ");
                        Console.WriteLine(dsht.TimHinh(h => ((HinhTron)h).TinhChuVi() == max));
                        break;
                    case Menu.TimViTriHinhCoDienTichLonNhat:
                        Console.Clear();
                        Console.WriteLine(qlhh.ToString());                       
                        max = qlhh.Max(hh => ((HinhHoc)hh).TinhDienTich());
                        List<int> kq2 = new List<int>();
                        kq2 = qlhh.TimViTriHinh(h => h.TinhDienTich() == max);
                        Console.Write($"Vị trí của hình có diện tích lớn nhất là: ");
                        foreach (int i in kq2)
                        {
                            Console.WriteLine(i + "\t");
                        }
                        break;
                    case Menu.TimViTriHinhCoDienTichNhoNhat:
                        Console.Clear();
                        Console.WriteLine(qlhh.ToString());                       
                        min = qlhh.Min(hh => ((HinhHoc)hh).TinhDienTich());
                        List<int> kq3 = new List<int>();
                        kq3 = qlhh.TimViTriHinh(h => h.TinhDienTich() == min);
                        Console.Write($"Vị trí của hình có diện tích nhỏ nhất là: ");
                        foreach (int i in kq3)
                        {
                            Console.WriteLine(i + "\t");
                        }
                        break;
                    case Menu.TimViTriTheoHinh:
                        Console.Clear();
                        Console.Write("Nhập hình: ");
                        string NhapLoaiHinh = Console.ReadLine();
                        List<int> kq = new List<int>();
                        switch (NhapLoaiHinh)
                        {
                            case "HV":
                                kq = qlhh.TimViTriHinh(h => h is HinhVuong);
                                break;
                            case "HCN":
                                kq = qlhh.TimViTriHinh(h => h is HinhChuNhat);
                                break;
                            case "HT":
                                kq = qlhh.TimViTriHinh(h => h is HinhTron);
                                break;
                        }
                        Console.WriteLine(qlhh.ToString());
                        Console.WriteLine($"Vị trí của {NhapLoaiHinh} là: ");
                        foreach (int i in kq)
                        {
                            Console.Write(i + " ");
                        }
                        break;
                    case Menu.TimViTriTheoDienTich:
                        Console.Clear();
                        Console.WriteLine(qlhh.ToString());
                        Console.Write("Nhập diện tích của hình: ");
                        List<int> kq1 = new List<int>();
                        float dt = float.Parse(Console.ReadLine());
                        kq1 = qlhh.TimViTriHinh(h => h.TinhDienTich() == dt);
                        Console.Write($"Vị trí của hình theo diện tích là: ");
                        foreach (int i in kq1)
                        {
                            Console.WriteLine(i + "\t");
                        }
                        break;
                    case Menu.XoaTatCaCacHinhTheoDienTich:
                        Console.Clear();
                        Console.WriteLine(qlhh.ToString());
                        Console.WriteLine("Nhập diện tích của hình: ");
                        float dt1 = float.Parse(Console.ReadLine());
                        qlhh.XoaTatCa(h => h.TinhDienTich() == dt1);
                        qlhh.Xuat();
                        break;
                    case Menu.XoaHinhVuongCoDienTichLaX:
                        Console.Clear();
                        dshv = qlhh.TimHinh(hh => hh is HinhVuong);
                        Console.WriteLine(dshv.ToString());
                        Console.WriteLine("Nhập diện tích của hình vuông muốn xóa: ");
                        float dt2 = float.Parse(Console.ReadLine());
                        qlhh.XoaTatCa(h => h.TinhDienTich() == dt2);
                        qlhh.Xuat();
                        break;
                    case Menu.ChenHinhTaiViTriX:
                        break;
                    case Menu.XoaHinhTaiViTriX:
                        break;
                    case Menu.TimLoaiHinhCoSoLuongNhieuNhat:
                        qlhh.SoLanXuatHien();
                        break;
                    case Menu.TimLoaiHinhCoSoLuongItNhat:
                        qlhh.SoLanXuatHien();
                        break;
                }
                Console.WriteLine("Bấm phím bất kỳ để tiếp tục");
                Console.ReadKey();
            }
        }
    }
}
