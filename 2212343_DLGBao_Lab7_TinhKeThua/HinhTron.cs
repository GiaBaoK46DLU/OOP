using System;

namespace QuanLyHinhHoc
{
    class HinhTron : HinhHoc
    {
        private float _banKinh;

        public float BanKinh
        {
            get
            {
                return _banKinh;
            }
            set
            {
                if (value < 0)
                    value = 0;
                _banKinh = value;
            }
        }

        public HinhTron(float banKinh) : base(banKinh)
        {
            BanKinh = banKinh;
        }

        public override float TinhChuVi()
        {
            return (float)(2 * BanKinh * Math.PI);
        }

        public override float TinhDienTich()
        {
            return (float)(BanKinh * BanKinh * Math.PI);
        }

        public override string ToString()
        {
            return $"Hình tròn bán kính {BanKinh}, chu vi {TinhChuVi()}, diện tích {TinhDienTich()}";       
        }
    }
}
