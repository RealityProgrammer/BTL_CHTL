using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHTL.GUI.BanHang
{
    public class ApiResponse
    {
        public string code { get; set; }
        public string desc { get; set; }
        public ApiResponseData data { get; set; }
    }

    public class ApiResponseData
    {
        public string qrDataURL { get; set; }
    }
}
