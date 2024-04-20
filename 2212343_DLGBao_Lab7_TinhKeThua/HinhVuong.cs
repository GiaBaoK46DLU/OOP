namespace QuanLyHinhHoc
{
    class HinhVuong : HinhChuNhat
    {
        public HinhVuong(float canh) : base(canh, canh)
        {
        }

        public override string ToString()
        {
            return $"Hình vuông cạnh {Canh}, chu vi {TinhChuVi()}, diện tích {TinhDienTich()}";
        }
    }
}
