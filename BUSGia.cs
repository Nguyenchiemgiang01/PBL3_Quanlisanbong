﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_An_PLB03.DTO;
using Do_An_PLB03.DAL;


namespace Do_An_PLB03.BUS
{
    internal class BUSGia
    {
        public static List<TimeSpan> tgbd = new List<TimeSpan>();
        public static List<TimeSpan> tgkt = new List<TimeSpan>();
        public static List<int> giatheogio = new List<int>();
        public static List<TimeSpan> tgbatdau(DTOGia gia,int loaisan)
        {
           tgbd=DALGia.tgbatdau(gia, loaisan);
            return tgbd;
        }
        public static List<TimeSpan> tgketthuc(DTOGia gia, int loaisan)
        {
            tgkt = DALGia.tgketthuc(gia, loaisan);
            return tgkt;
        }
        public static List<int> gia(DTOGia gia, int loaisan)
        {
            giatheogio = DALGia.gia(gia, loaisan);
            return giatheogio;
        }

    }
}
