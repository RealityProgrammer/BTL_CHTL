using System;
using CHTL.DAL;
using CHTL.Models;

namespace CHTL.BUS
{
    public class XuLyBaoCao
    {
        private readonly TruyCapBaoCao truyCap = new TruyCapBaoCao();

        public BaoCao LayBaoCao(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            return truyCap.LayBaoCao(ngayBatDau, ngayKetThuc);
        }
    }
}