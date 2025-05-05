using CHTL.DAL;
using CHTL.Models;
using System;

namespace CHTL.BUS {
    public class XuLyBaoCao {
        private readonly TruyCapBaoCao truyCap = new TruyCapBaoCao();

        public BaoCao LayBaoCao(DateTime ngayBatDau, DateTime ngayKetThuc) => truyCap.LayBaoCao(ngayBatDau, ngayKetThuc);
    }
}