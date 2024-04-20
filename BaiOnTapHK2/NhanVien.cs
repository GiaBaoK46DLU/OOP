using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiOnTapHK2
{
    internal interface iNhanVien
    {
        string MaSo { get; }
        int NamSinh { get; set; }
        string Ten { get; set; }
    }
}
