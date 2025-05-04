using Krypton.Toolkit;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHTL.GUI.BanHang {
    public partial class FormThanhToanQR : KryptonForm {
        private decimal amount;
        private string maHoaDon;

        private CancellationTokenSource _cancellationTokenSource;
        private Task _generateQRTask;
        
        public FormThanhToanQR(string maHoaDon, decimal amount) {
            InitializeComponent();
            
            _cancellationTokenSource = new CancellationTokenSource();
            
            this.maHoaDon = maHoaDon;
            this.amount = amount;

            panelFooter.SaveButton.Enabled = false;
            _generateQRTask = GenerateAndDisplayQRCode(_cancellationTokenSource.Token);
        }
        
        private async Task GenerateAndDisplayQRCode(CancellationToken cancellationToken) {
            try {
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

                var response = await client.ExecuteAsync(request, cancellationToken);
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
                var image = await Base64ToImage(dataResult.data.qrDataURL.Replace("data:image/png;base64,", ""), cancellationToken);
                
                BeginInvoke((Action)(() => {
                    panelFooter.SaveButton.Enabled = true;
                    pbQR.Image = image;
                    labelTrangThai.Text = "Quét mã QR để thanh toán";
                }));
            }
            catch (OperationCanceledException) {}
            catch (Exception ex) {
                BeginInvoke((Action<string>)(msg => {
                    MessageBox.Show($"Lỗi khi tạo mã QR: {ex.Message}", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }), ex.Message);
            }
        }
        
        private async Task<Image> Base64ToImage(string base64String, CancellationToken cancellationToken)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                await ms.WriteAsync(imageBytes, 0, imageBytes.Length, cancellationToken);
                return Image.FromStream(ms, true);
            }
        }
        
        private void btnSave_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }
        
        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        
        private void FormThanhToanQR_FormClosed(object sender, FormClosedEventArgs e) {
            _cancellationTokenSource.Cancel();
            _generateQRTask.Wait();
            _cancellationTokenSource.Dispose();
        }
    }
}