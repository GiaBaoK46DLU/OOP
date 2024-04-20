using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhBa
{
    internal class DanhBa
    {
        List<ThueBao> Collection = new List<ThueBao>();
        public void Nhap()
        {

            Console.WriteLine("Nhap dia chi: ");
            string a = Console.ReadLine();
            Console.Write("Nhap gioi tinh: ");
            var b = Console.ReadLine();
            var gt = GioiTinh.Nu;
            if (b == "Nam" || b == "nam")
                gt = GioiTinh.Nam;
            Console.WriteLine("Nhap ho ten: ");
            string c = Console.ReadLine();
            Console.WriteLine("Nhap ngay sinh: ");
            var d = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("Nhap so dien thoai: ");
            string e = Console.ReadLine();
            Console.WriteLine("Nhap so CMND: ");
            string f = Console.ReadLine();
            Collection.Add(new ThueBao(a, gt, c, d, e, f));
        }

        public void Xuat()
        {
            foreach (ThueBao t in Collection)
            {
                t.Xuat();
            }
        }
        public void Them(ThueBao n)
        {
            Collection.Add(n);
        }
        public void NhapTuFile()
        {
            string tenFile = "D:\\C#\\2212343_DLGBao_Lab6_UngDungQuanLyDanhBa\\bin\\Debug\\data.csv"; //tạo 1 biến là tenFile với dữ liệu của nó là dữ liệu của file data.csv
            StreamReader sr = new StreamReader(tenFile);//sử dụng lệnh Streamreader để đọc file data.csv
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                ThueBao n = new ThueBao(s);
                Collection.Add(n);
            }
        }
        public List<string> TimDSCacThanhPho()
        {
            List<string> kq = new List<string>();//tạo đối tượng mới màn tên kq trong mảng
            foreach (var item in Collection) //qét từng đối tượng trong mảng
            {
                if (!kq.Contains(item.ThanhPho))//nếu kq nằm trong thành phố
                    kq.Add(item.ThanhPho);//thêm đối tượng kq đó vào thành phố
            }
            return kq;
        }
        public int DemSoThueBaoTheoTP(string tp)
        {
            int dem = 0;//gắn mặc định rằng số thuê bao trong thành phố là 0
            foreach (var item in Collection)
            {
                if (item.ThanhPho == tp)//nếu tên  thành phố trong mảng trùng tên với thành phố đang xét 
                    dem++;//dem tăng 1
            }
            return dem;
        }
        public List<string> TimTPCoNhieuThueBaoNhat()
        {
            List<string> kq = new List<string>();
            List<string> dstp = TimDSCacThanhPho();
            int max = int.MinValue;//gắn biến max bằng giá trị nhỏ nhất
            foreach (var item in dstp)
            {
                if (max < DemSoThueBaoTheoTP(item))//nếu max bé hơn số thuê bao trong thanh phố "item"
                    max = DemSoThueBaoTheoTP(item);//max sẽ được gắn bằng số thuê bao trong "item" vừa tìm được 
            }
            foreach (var tp in dstp)
            {
                if (DemSoThueBaoTheoTP(tp) == max)//nếu số thuê bao trong thành phố tp bằng max
                    kq.Add((tp));//kết quả sẽ là thành phố đó

            }
            return kq;
        }
        public List<string> TimTatCaTPCoSoTBLaX(int x)
        {
            List<string> kq = new List<string>();
            List<string> dstp = TimDSCacThanhPho();
            foreach (var item in dstp)
            {
                if (DemSoThueBaoTheoTP(item) == x)
                    kq.Add(item);
            }
            return kq;
        }
        public List<string> TimTPCoItThueBaoNhat()
        {           
            List<string> dstp = TimDSCacThanhPho();
            var min = int.MaxValue;
            foreach (var item in dstp)
            {
                if (min > DemSoThueBaoTheoTP(item))
                    min = DemSoThueBaoTheoTP(item);
            }
            return TimTatCaTPCoSoTBLaX(min);
        }
        public List<string> TimDSCacThueBao()
        {
            List<string> kq = new List<string>();
            foreach (var item in Collection) 
            {
                if (!kq.Contains(item.KhachSuDung))
                    kq.Add(item.KhachSuDung);
            }
            return kq;
        }
        public int DemSoSDTTheoThueBao(string tb)
        {
            int dem = 0;
            foreach (var item in Collection)
            {
                if (item.KhachSuDung == tb)
                    dem++;
            }
            return dem;
        }
        public List<string> TimThueBaoCoSDTLaX(int x)
        {
            List<string> kq = new List<string>();
            List<string> dstb = TimDSCacThueBao();
            foreach (var item in dstb)
            {
                if (DemSoSDTTheoThueBao(item) == x)
                    kq.Add(item);
            }
            return kq;
        }
        public List<string> TimThueBaoCoItSDT()
        {
            List<string> dstb = TimDSCacThueBao();
            int min = int.MaxValue;
            foreach (var item in dstb)
            {
                if (min > DemSoSDTTheoThueBao(item))
                    min = DemSoSDTTheoThueBao(item);
            }
            return TimThueBaoCoSDTLaX(min);
        }
    }
}
