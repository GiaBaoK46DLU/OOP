using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;

namespace QuanLyDanhBa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DanhBa db = new DanhBa();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("----------CHON CHUC NANG----------");
                Console.WriteLine($"Chon {(int)Menu.NhapBangTay} de them thue bao bang tay");
                Console.WriteLine($"Chon {(int)Menu.NhapTuFile} de nhap tu file");
                Console.WriteLine($"Chon {(int)Menu.Xuat} de xem danh ba");
                Console.WriteLine($"Chon {(int)Menu.TimDanhSachCacTP} de xem danh sach cac thanh pho");
                Console.WriteLine($"Chon {(int)Menu.DemSoTBTheoTP} de dem so thue bao theo thanh pho");
                Console.WriteLine($"Chon {(int)Menu.TimTPCoNhieuThueBaoNhat} de tim thanh pho co nhieu thue bao nhat");
                Console.WriteLine($"Chon {(int)Menu.TimTatCaTPCoSoTBLaX} de tim thanh pho co so thue bao la x");
                Console.WriteLine($"Chon {(int)Menu.TimTPCoItThueBaoNhat} de tim thanh pho co it thue bao nhat");
                Console.WriteLine($"Chon {(int)Menu.TimThueBaoCoItSDT} de tim thue bao co it sdt nhat");
                Console.WriteLine($"Chon {(int)Menu.Thoat} de thoat");
                Console.WriteLine("-----------------------------------");
                Console.Write("Chon chuc nang : ");
                Menu chon = (Menu)int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case Menu.NhapBangTay:
                        Console.Clear();
                        Console.Write("Nhap so thue bao can them: ");
                        int x = int.Parse(Console.ReadLine());
                        for (int i = 0; i < x; i++)
                        {
                            db.Nhap();
                        }
                        break;
                    case Menu.NhapTuFile:
                        Console.Clear();
                        db.NhapTuFile();
                        break;
                    case Menu.Xuat:
                        Console.Clear();
                        db.Xuat();
                        break;
                    case Menu.TimDanhSachCacTP:
                        Console.Clear();
                        db.Xuat();
                        List<string> kq = db.TimDSCacThanhPho();
                        Console.WriteLine("Danh sach cac thanh pho :");
                        foreach (var item in kq)
                        {
                            Console.WriteLine($"Thanh pho {item}");
                            Console.WriteLine("---------------------");
                        }
                        break;
                    case Menu.DemSoTBTheoTP:
                        Console.Clear();
                        db.Xuat();
                        List<string> kq1 = db.TimDSCacThanhPho();
                        Console.WriteLine("So thue bao theo tung thanh pho :");
                        foreach (var item in kq1)
                        {
                            Console.WriteLine(item + " co so thue bao la: " + db.DemSoThueBaoTheoTP(item));
                        }
                        break;
                    case Menu.TimTPCoNhieuThueBaoNhat:
                        Console.Clear();
                        List<string> kq2 = db.TimTPCoNhieuThueBaoNhat();
                        foreach (var item in kq2)
                        {
                            Console.WriteLine(item + " co nhieu thue bao nhat voi " + db.DemSoThueBaoTheoTP(item) + " thue bao");
                        }
                        break;
                    case Menu.TimTatCaTPCoSoTBLaX:
                        Console.Clear();
                        Console.Write("Nhap so luong thue bao can tim: ");
                        int soTB = int.Parse(Console.ReadLine());
                        List<string> kq3 = db.TimTatCaTPCoSoTBLaX(soTB);
                        foreach (var item in kq3)
                        {
                            Console.WriteLine(item + " co so thue bao la " + soTB);
                        }
                        break;
                    case Menu.TimTPCoItThueBaoNhat:
                        Console.Clear();
                        List<string> kq4 = db.TimTPCoItThueBaoNhat();
                        foreach (var item in kq4)
                        {
                            Console.WriteLine(item + " co it thue bao nhat voi " + db.DemSoThueBaoTheoTP(item) + " thue bao");
                        }
                        break;
                    case Menu.TimThueBaoCoItSDT:
                        Console.Clear();
                        List<string> kq5 = db.TimThueBaoCoItSDT();
                        foreach (var item in kq5)
                        {
                            Console.WriteLine(item + " co it sdt nhat voi " + db.DemSoSDTTheoThueBao(item) + " sdt");
                        }
                        break;
                    default:
                        return;
                }
                Console.WriteLine("Bam phim bat ki de tiep tuc");
                Console.ReadKey();
            }
        }
        public enum Menu
        {
            NhapBangTay = 1,
            NhapTuFile,
            Xuat,
            TimDanhSachCacTP,
            DemSoTBTheoTP,  
            TimTPCoNhieuThueBaoNhat,
            TimTatCaTPCoSoTBLaX,
            TimTPCoItThueBaoNhat,
            TimThueBaoCoItSDT,
            Thoat
        }
    }
}