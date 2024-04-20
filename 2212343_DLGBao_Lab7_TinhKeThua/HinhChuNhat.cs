namespace QuanLyHinhHoc
{
    class HinhChuNhat : HinhHoc
    {
        private float _chieuDai, _chieuRong;

        public float ChieuDai
        {
            get { return _chieuDai; }
            set
            {
                if (value < 0)
                    value = 0;
                _chieuDai = value;
            }
        }

        public float ChieuRong
        {
            get { return _chieuRong; }
            set
            {
                if (value < 0)
                    value = 0;
                _chieuRong = value;
            }
        }

        public HinhChuNhat(float chieuDai, float chieuRong) : base(chieuDai)
        {
            ChieuDai = chieuDai;
            ChieuRong = chieuRong;
        }

        public override float TinhChuVi()
        {
            return (ChieuDai + ChieuRong) * 2;
        }

        public override float TinhDienTich()
        {
            return ChieuDai * ChieuRong;
        }

        public override string ToString()
        {
            return $"Hình chữ nhật chiều dài {ChieuDai}, chiều rộng {ChieuRong}, chu vi {TinhChuVi()}, diện tích {TinhDienTich()}";
        }
    }
}
