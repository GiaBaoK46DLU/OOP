namespace QuanLyHinhHoc
{
    class HinhHoc
    {
        public float Canh;
        public HinhHoc(float canh)
        {
            Canh = canh;
        }

        public virtual float TinhDienTich()
        {
            return 0;
        }

        public virtual float TinhChuVi()
        {
            return 0;
        }
    }
}
