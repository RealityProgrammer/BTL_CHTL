using Newtonsoft.Json;

namespace CHTL.GUI.BanHang {
    // TODO: Rename when merging with main
    public class QRPaymentResponse {
        [JsonProperty("code")] public string Code { get; set; }
        [JsonProperty("desc")] public string Description { get; set; }
        [JsonProperty("data")] public QRPaymentResponseData Data { get; set; }
    }

    public class QRPaymentResponseData {
        [JsonProperty("qrDataURL")] public string QRDataUrl { get; set; }
    }
}