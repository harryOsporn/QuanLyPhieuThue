using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyPhieuThue
{
    public enum KieuLoaiPhong { A, B, C, D }
    [Serializable]
    class PhieuThue
    {
        public int MaPT { get; set; }
        public DateTime NgayBD { get; set; }
        public DateTime NgayKT { get; set; }
        public string TenKH { get; set; }
        public KieuLoaiPhong LoaiPhong { get; set; }

        public PhieuThue(int mapt, DateTime ngaybd, DateTime ngaykt, string tenkh, KieuLoaiPhong loaiphong)
        {
            MaPT = mapt;
            NgayBD = ngaybd;
            NgayKT = ngaykt;
            TenKH = tenkh;
            LoaiPhong = loaiphong;
        }
        public PhieuThue() { }
        public int getSoNgayThue
        {
            get => (NgayKT.Day - NgayBD.Day) + 1;
        }
        public int soTienThue
        {
            get
            {
                int soTien = 0;
                switch (LoaiPhong)
                {
                    case KieuLoaiPhong.A:
                        soTien = 250;
                        break;
                    case KieuLoaiPhong.B:
                        soTien = 400;
                        break;
                    case KieuLoaiPhong.C:
                        soTien = 600;
                        break;
                    case KieuLoaiPhong.D:
                        soTien = 900;
                        break;
                }
                return soTien;
            }
        }
    }
}
