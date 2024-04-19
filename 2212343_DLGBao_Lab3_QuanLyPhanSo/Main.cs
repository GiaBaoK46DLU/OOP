using _2212343_DLGBao_Lab3_QuanLyPhanSo;

PhanSo a = new PhanSo(2, 3);
a.Xuat();

PhanSo b = new PhanSo(3, 4);
b.Xuat();

PhanSo c = a.Cong(a, b);
Console.Write(" a+b ");
c.Xuat();

PhanSo d = a.Tru(a, b);
Console.Write(" a-b ");
d.Xuat();

PhanSo e = a.Nhan(a, b);
Console.Write(" a*b ");
e.Xuat();

PhanSo f = a.Chia(a, b);
Console.Write(" a/b ");
f.Xuat();

MangPhanSo m = new MangPhanSo();
m.Nhap();
m.Xuat();
