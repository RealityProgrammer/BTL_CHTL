namespace CHTL.GUI.BanHang {
    // TODO: Rename when merging with main
    public class ApiResponse {
        public string code { get; set; }
        public string desc { get; set; }
        public ApiResponseData data { get; set; }
    }

    public class ApiResponseData {
        public string qrDataURL { get; set; }
    }
}