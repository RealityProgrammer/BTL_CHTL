using Newtonsoft.Json;

namespace CHTL.GUI.BanHang {
    public class QRPaymentRequest {
        [JsonProperty("acqId")] public int AcquireID { get; set; }
        [JsonProperty("accountNo")] public string AccountNumber { get; set; }
        [JsonProperty("accountName")] public string AccountName { get; set; }
        [JsonProperty("amount")] public int Amount { get; set; }
        [JsonProperty("addInfo")] public string AdditionalInfo { get; set; }
        [JsonProperty("format")] public string Format { get; set; }
        [JsonProperty("template")] public string Template { get; set; }
    }
}