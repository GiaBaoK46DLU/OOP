using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuanLyHinhHoc
{
    class QuanLyHinhHoc
    {
        private List<HinhHoc> dsHH;

        public int SoLuong
        {
            get
            {
                return dsHH.Count;
            }
        }

        public QuanLyHinhHoc()
        {
            dsHH = new List<HinhHoc>();
        }

        public HinhHoc this[int i]
        {
            get { return dsHH[i]; }
            set { dsHH[i] = value; }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (HinhHoc h in dsHH)
                stringBuilder.AppendLine(h.ToString());
            return stringBuilder.ToString();
        }

        public void Add(HinhHoc hinhHoc)
        {
            dsHH.Add(hinhHoc);
        }

        public void Insert(int vitri, HinhHoc hinhHoc)
        {
            dsHH.Insert(vitri, hinhHoc);
        }

        public void Remove(HinhHoc hinhHoc)
        {
            dsHH.Remove(hinhHoc);
        }

        public void RemoveAt(int vitri)
        {
            dsHH.RemoveAt(vitri);
        }

        public void Clear()
        {
            dsHH.Clear();
        }

        public void DocTuFile(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                var data = line.Split(',');
                if (data.Length > 0)
                {
                    float a, b, c;
                    switch (data[0])
                    {
                        case "HT":
                            a = float.Parse(data[1]);
                            Add(new HinhTron(a));
                            break;
                        case "HV":
                            b = float.Parse(data[1]);
                            Add(new HinhVuong(b));
                            break;
                        case "HCN":
                            a = float.Parse(data[1]);
                            b = float.Parse(data[2]);
                            Add(new HinhChuNhat(a, b));
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        //Xuất danh sách hình học ra file
        public void XuatRaFile(string filename)
        {
            StreamWriter sw = new StreamWriter(filename, false, Encoding.UTF8);
            foreach (HinhHoc hinhhoc in dsHH)
            {
                sw.WriteLine(hinhhoc);
            }
        }
        public void Xuat()
        {
            Console.WriteLine(this);
        }

        //Tìm hình theo điều kiện
        public QuanLyHinhHoc TimHinh(Func<HinhHoc, bool> dk)
        {
            QuanLyHinhHoc kq = new QuanLyHinhHoc();
            foreach (HinhHoc hinhHoc in dsHH)
            {
                if (dk(hinhHoc))
                {
                    kq.Add(hinhHoc);
                }
            }
            return kq;
        }
        public List<int> TimViTriHinh(Func<HinhHoc, bool> dk)
        {
            List<int> kq = new List<int>();
            for (int i = 0; i < dsHH.Count; i++)
            {
                if (dk(dsHH[i]))
                {
                    kq.Add(i);
                }
            }
            return kq;
        }


        //Sắp xếp danh sách
        public void SapXepDanhSach(Func<HinhHoc, HinhHoc, bool> dk1)
        {
            for (int i = 0; i < SoLuong - 1; i++)
            {
                for (int j = i + 1; j < SoLuong; j++)
                {
                    if (dk1(this[i], this[j]))
                    {
                        (this[j], this[i]) = (this[i], this[j]);
                    }
                }
            }
        }

        //Tìm giá trị lớn nhất
        public float Max(Func<HinhHoc, float> giatri)
        {
            if (SoLuong > 0)
            {
                float max = giatri(this[0]);
                for (int i = 1; i < SoLuong; i++)
                {
                    if (max < giatri(this[i]))
                        max = giatri(this[i]);
                }
                return max;
            }
            return 0;
        }

        //Tìm giá trị nhỏ nhất
        public float Min(Func<HinhHoc, float> giatri)
        {
            if (SoLuong > 0)
            {
                float min = giatri(this[0]);
                for (int i = 1; i < SoLuong; i++)
                {
                    if (min > giatri(this[i]))
                        min = giatri(this[i]);
                }
                return min;
            }
            return 0;
        }

        //Tính tổng
        public float Tong(Func<HinhHoc, float> giatri1)
        {
            float tong = 0;
            foreach (HinhHoc hinhHoc in dsHH)
            {
                tong += giatri1(hinhHoc);
            }
            return tong;
        }

        //Tìm vị trí đầu tiên
        public int TimViTriDauTien(Func<HinhHoc, bool> dktim)
        {
            for (int i = 0; i < SoLuong; i++)
            {
                if (dktim(dsHH[i]))
                    return i;
            }
            return -1;
        }

        //Tìm vị trí cuối cùng
        public int TimViTriCuoiCung(Func<HinhHoc, bool> dktim2)
        {
            for (int i = SoLuong - 1; i >= 0; i--)
            {
                if (dktim2(dsHH[i]))
                    return i;
            }
            return -1;
        }

        //Xóa tất cả các hình theo điều kiện
        public void XoaTatCa(Func<HinhHoc, bool> dieukien)
        {
            for (int i = SoLuong - 1; i >= 0; i--)
            {
                if (dieukien(dsHH[i]))
                    dsHH.RemoveAt(i);
            }
        }

        //Số lần xuất hiện của hình 
        public void SoLanXuatHien()
        {
            foreach (string name in Enum.GetNames(typeof(LoaiHinh)))
            {
                QuanLyHinhHoc hinhHoc = TimHinh(g => g.GetType().Name == name);
                int count = hinhHoc.SoLuong;
                Console.WriteLine($"{name} xuất hiện {count} lần");
            }
        }
    }
}
