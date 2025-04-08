using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using QRCoder;
using RestSharp;

namespace CHTL.GUI.BanHang
{
    public partial class FormQRPayment : Form
    {
        private decimal amount;
        private string maHoaDon;

        public FormQRPayment(string maHoaDon, decimal amount)
        {
            InitializeComponent();
            this.maHoaDon = maHoaDon;
            this.amount = amount;
            GenerateAndDisplayQRCode();
        }

        private void GenerateAndDisplayQRCode()
        {
            try
            {
                // Tạo yêu cầu API VietQR
                var apiRequest = new ApiRequest
                {
                    acqId = 970422, // Mã BIN của MB Bank
                    accountNo = "0976341968", // Số tài khoản
                    accountName = "HOANG MINH THANH", // Thay bằng tên chủ tài khoản thực tế
                    amount = (int)amount, // Số tiền (chuyển thành số nguyên)
                    addInfo = $"Thanh toan hoa don {maHoaDon}", // Nội dung thanh toán
                    format = "text",
                    template = "compact"
                };

                // Serialize yêu cầu thành JSON
                var jsonRequest = JsonConvert.SerializeObject(apiRequest);

                // Gọi API VietQR
                var client = new RestClient("https://api.vietqr.io/v2/generate");
                var request = new RestRequest
                {
                    Method = Method.Post
                };
                request.AddHeader("Accept", "application/json");
                request.AddParameter("application/json", jsonRequest, ParameterType.RequestBody);

                var response = client.Execute(request);
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show($"Lỗi khi gọi API VietQR: {response.StatusDescription}", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Deserialize phản hồi
                var dataResult = JsonConvert.DeserializeObject<ApiResponse>(response.Content);
                if (dataResult.code != "00")
                {
                    MessageBox.Show($"Lỗi từ API VietQR: {dataResult.desc}", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Chuyển base64 thành hình ảnh và hiển thị
                var image = Base64ToImage(dataResult.data.qrDataURL.Replace("data:image/png;base64,", ""));
                pbQRCode.Image = image;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo mã QR: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                ms.Write(imageBytes, 0, imageBytes.Length);
                return Image.FromStream(ms, true);
            }
        }
    }
}
