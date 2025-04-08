using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHTL.GUI.BanHang
{
    public class ApiRequest
    {
        public int acqId { get; set; }
        public string accountNo { get; set; }
        public string accountName { get; set; }
        public int amount { get; set; }
        public string addInfo { get; set; }
        public string format { get; set; }
        public string template { get; set; }
    }
}
