using _2212343_DLGBao_Lab5_UngDungMangDoiTuong;

//MangNhaXuatBan m = new MangNhaXuatBan();
//m.Nhap();
//m.Xuat();

MangNhaXuatBan m = new MangNhaXuatBan();
m.NhapTuFile();
m.Xuat();
Console.WriteLine("Danh sach NXB co dia chi o Tran Phu ");
m.TimTatCaNXBCoDiaChiTranPhu().Xuat();