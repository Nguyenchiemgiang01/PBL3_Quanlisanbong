﻿using Do_An_PLB03.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_An_PLB03.DTO;
using System.Data;

namespace Do_An_PLB03.BUS
{
    public class BUSDangNhap
    {
        public static bool DangNhap(DTONguoiDung user)
        {
            return DALDangNhap.KiemTraDangNhap(user);
        }
        public static DataTable Getallkhachhang()
        {
            return DALDangNhap.GetAllKhachHang();
        }
    } 
}
