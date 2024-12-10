using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System;
using Newtonsoft.Json;
using System.Security.Cryptography; 
using System.Net; 
using JavaScience;
using Newtonsoft.Json.Linq;

namespace f_4_5_2_RSAsample
{
    partial class Form1
    { 
        static string apiHost = "https://stage-usdtpayfi-api.azurewebsites.net"; 

        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        private async void InitializeComponent()
        {
            this.privateKey = new System.Windows.Forms.RichTextBox();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.remark = new System.Windows.Forms.TextBox();
            this.expectingAmount = new System.Windows.Forms.TextBox();
            this.notifyUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.orderType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.resultMessage = new System.Windows.Forms.Label();
            this.SendBtn = new System.Windows.Forms.Button();
            this.orderNo = new System.Windows.Forms.TextBox();
            this.OrderNoTilte = new System.Windows.Forms.Label();
            this.notifyTestUrl = new System.Windows.Forms.TextBox();
            this.notifyTestType = new System.Windows.Forms.TextBox();
            this.labelnotifyTestUrl = new System.Windows.Forms.Label();
            this.labelnotifyTestType = new System.Windows.Forms.Label();
            this.NotifyManuallyBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // privateKey
            // 
            this.privateKey.Location = new System.Drawing.Point(95, 76);
            this.privateKey.Name = "privateKey";
            this.privateKey.Size = new System.Drawing.Size(233, 132);
            this.privateKey.TabIndex = 0;
            this.privateKey.Text = "";
            this.privateKey.TextChanged += new System.EventHandler(this.privateKey_TextChanged);
            // 
            // CustomerName
            // 
            this.CustomerName.Location = new System.Drawing.Point(95, 48);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(233, 22);
            this.CustomerName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "CustomerName";
            // 
            // remark
            // 
            this.remark.Location = new System.Drawing.Point(95, 253);
            this.remark.Name = "remark";
            this.remark.Size = new System.Drawing.Size(233, 22);
            this.remark.TabIndex = 3;
            this.remark.Text = "SampleTest";
            // 
            // expectingAmount
            // 
            this.expectingAmount.Location = new System.Drawing.Point(95, 281);
            this.expectingAmount.Name = "expectingAmount";
            this.expectingAmount.Size = new System.Drawing.Size(233, 22);
            this.expectingAmount.TabIndex = 4;
            // 
            // notifyUrl
            // 
            this.notifyUrl.Location = new System.Drawing.Point(95, 309);
            this.notifyUrl.Name = "notifyUrl";
            this.notifyUrl.Size = new System.Drawing.Size(233, 22);
            this.notifyUrl.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Remark";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "USDT Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Notify URL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "20 : 支付";
            // 
            // orderType
            // 
            this.orderType.Location = new System.Drawing.Point(95, 220);
            this.orderType.Name = "orderType";
            this.orderType.Size = new System.Drawing.Size(100, 22);
            this.orderType.TabIndex = 11;
            this.orderType.Text = "20";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "OrderType";
            // 
            // resultMessage
            // 
            this.resultMessage.AutoSize = true;
            this.resultMessage.Location = new System.Drawing.Point(93, 373);
            this.resultMessage.Name = "resultMessage";
            this.resultMessage.Size = new System.Drawing.Size(44, 12);
            this.resultMessage.TabIndex = 13;
            this.resultMessage.Text = "Message";
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(95, 337);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(75, 23);
            this.SendBtn.TabIndex = 14;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.Send_Click);
            // 
            // orderNo
            // 
            this.orderNo.Location = new System.Drawing.Point(436, 48);
            this.orderNo.Name = "orderNo";
            this.orderNo.Size = new System.Drawing.Size(255, 22);
            this.orderNo.TabIndex = 15;
            // 
            // OrderNoTilte
            // 
            this.OrderNoTilte.AutoSize = true;
            this.OrderNoTilte.Location = new System.Drawing.Point(384, 51);
            this.OrderNoTilte.Name = "OrderNoTilte";
            this.OrderNoTilte.Size = new System.Drawing.Size(46, 12);
            this.OrderNoTilte.TabIndex = 16;
            this.OrderNoTilte.Text = "OrderNo";
            // 
            // notifyTestUrl
            // 
            this.notifyTestUrl.Location = new System.Drawing.Point(436, 76);
            this.notifyTestUrl.Name = "notifyTestUrl";
            this.notifyTestUrl.Size = new System.Drawing.Size(255, 22);
            this.notifyTestUrl.TabIndex = 17;
            // 
            // notifyTestType
            // 
            this.notifyTestType.Location = new System.Drawing.Point(436, 104);
            this.notifyTestType.Name = "notifyTestType";
            this.notifyTestType.Size = new System.Drawing.Size(255, 22);
            this.notifyTestType.TabIndex = 18;
            // 
            // labelnotifyTestUrl
            // 
            this.labelnotifyTestUrl.AutoSize = true;
            this.labelnotifyTestUrl.Location = new System.Drawing.Point(380, 79);
            this.labelnotifyTestUrl.Name = "labelnotifyTestUrl";
            this.labelnotifyTestUrl.Size = new System.Drawing.Size(50, 12);
            this.labelnotifyTestUrl.TabIndex = 19;
            this.labelnotifyTestUrl.Text = "NotifyUrl";
            // 
            // labelnotifyTestType
            // 
            this.labelnotifyTestType.AutoSize = true;
            this.labelnotifyTestType.Location = new System.Drawing.Point(371, 107);
            this.labelnotifyTestType.Name = "labelnotifyTestType";
            this.labelnotifyTestType.Size = new System.Drawing.Size(59, 12);
            this.labelnotifyTestType.TabIndex = 20;
            this.labelnotifyTestType.Text = "NotifyType";
            // 
            // NotifyManuallyBtn
            // 
            this.NotifyManuallyBtn.Location = new System.Drawing.Point(436, 218);
            this.NotifyManuallyBtn.Name = "NotifyManuallyBtn";
            this.NotifyManuallyBtn.Size = new System.Drawing.Size(75, 23);
            this.NotifyManuallyBtn.TabIndex = 21;
            this.NotifyManuallyBtn.Text = "Send Notify";
            this.NotifyManuallyBtn.UseVisualStyleBackColor = true;
            this.NotifyManuallyBtn.UseWaitCursor = true;
            this.NotifyManuallyBtn.Click += new System.EventHandler(this.Send_NotifyManually);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(434, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 12);
            this.label8.TabIndex = 22;
            this.label8.Text = "5 : 支付入帳成功";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(434, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 12);
            this.label9.TabIndex = 23;
            this.label9.Text = "0 : 支付入帳失敗";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(434, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 12);
            this.label10.TabIndex = 24;
            this.label10.Text = "1 : 錢包歸集成功";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(434, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 12);
            this.label11.TabIndex = 25;
            this.label11.Text = "2 : 錢包歸集失敗";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(434, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 12);
            this.label12.TabIndex = 26;
            this.label12.Text = "3 : 代付成功";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(434, 189);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 12);
            this.label13.TabIndex = 27;
            this.label13.Text = "4 : 代付失敗";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(723, 669);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NotifyManuallyBtn);
            this.Controls.Add(this.labelnotifyTestType);
            this.Controls.Add(this.labelnotifyTestUrl);
            this.Controls.Add(this.notifyTestType);
            this.Controls.Add(this.notifyTestUrl);
            this.Controls.Add(this.OrderNoTilte);
            this.Controls.Add(this.orderNo);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.resultMessage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.orderType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.notifyUrl);
            this.Controls.Add(this.expectingAmount);
            this.Controls.Add(this.remark);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.privateKey);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private void Send_Click(object sender, EventArgs e)
        {
            // Required parameters
            string customerName = this.CustomerName.Text;
            string privateKey = this.privateKey.Text;
            int orderType = Convert.ToInt32(this.orderType.Text);  // 10 : 存入 / 20 : 支付
            Random rnd = new Random();
            string customerOrderNo = @"Sample_CreateOrder_" + rnd.Next(1, 99999); // 以不重複為原則
            string remark = this.remark.Text;
            string expectingAmount = this.expectingAmount.Text;
            string notifyUrl = this.notifyUrl.Text;

            Order_CreateOrder(customerName, privateKey, orderType, customerOrderNo, remark, expectingAmount, notifyUrl);
        }

        private void Send_NotifyManually(object sender, EventArgs e)
        {
            // Required parameters
           string customerName = this.CustomerName.Text;  
            string privateKey = this.privateKey.Text;
            string orderNo = this.orderNo.Text; 
            string notifyTestUrl = this.notifyTestUrl.Text;
            int notifyTestType = Convert.ToInt32(this.notifyTestType.Text);

            CreateNotifyManually(customerName, privateKey, orderNo, notifyTestUrl, notifyTestType);
        }

         
        /// <summary>
        /// 產生(10 : 存入 / 20 : 支付)訂單
        /// </summary>
        /// <param name="customerName"></param>
        /// <param name="privateKey"></param>
        /// <param name="orderType"></param>
        /// <param name="customerOrderNo"></param>
        /// <param name="remark"></param>
        /// <param name="expectingAmount"></param>
        /// <param name="notifyUrl"></param>
        /// <returns></returns>
        async Task<JObject> Order_CreateOrder(
            string customerName, string privateKey, int orderType, string customerOrderNo, string remark, string expectingAmount, string notifyUrl)
        {
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)192 | (SecurityProtocolType)768 | (SecurityProtocolType)3072;

            this.resultMessage.Text = "Sending Order_CreateOrder...";

            try
            {
                // 轉成 Xml 格式
                var pemprivatekey = opensslkey.DecodeOpenSSLPrivateKey(privateKey);
                if (pemprivatekey != null)
                {
                    RSACryptoServiceProvider rsa = opensslkey.DecodeRSAPrivateKey(pemprivatekey);
                    privateKey = rsa.ToXmlString(true);
                } 

                string data = JsonConvert.SerializeObject(new
                {
                    orderType = orderType,
                    customerOrderNo = customerOrderNo, // 請視規則調整
                    remark = remark,
                    expectingAmount = expectingAmount, // U 總量
                    notifyUrl = notifyUrl,
                    redirectUrl = "",
                    timestamp = Convert.ToInt64(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds).ToString()
                }); 
                GenSignature(privateKey, data, out string xSignature);

                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("X-Signature", xSignature);
                client.DefaultRequestHeaders.Add("X-Customer-Name", customerName);
                string apiUri = $"{apiHost}/api/Order/CreateOrder";

                // Post
                StringContent httpContent = new StringContent(data, Encoding.UTF8, "application/json");
                var result = client.PostAsync(apiUri, httpContent).Result;
                var res = result.Content.ReadAsStringAsync().Result;
                JObject json = JObject.Parse(res);
                 
                this.resultMessage.Text = json.ToString();
                
                return json;
            } 
            catch (Exception ex)
            {
                this.resultMessage.Text = ex.Message;
                Console.WriteLine("Exception : " + ex.Message);
                return null;
            }   
        }

        /// <summary>
        /// 手動回調
        /// </summary>
        /// <param name="customerName"></param>
        /// <param name="privateKey"></param>
        /// <param name="orderNo"></param>
        /// <param name="notifyTestUrl"></param>
        /// <param name="notifyTestType"></param>
        /// <returns></returns>
        async Task<JObject> CreateNotifyManually(
          string customerName, string privateKey, string orderNo, string notifyTestUrl , int notifyTestType)
        {
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)192 | (SecurityProtocolType)768 | (SecurityProtocolType)3072;

            this.resultMessage.Text = "Sending CreateNotifyManually...";

            try
            {
                // 轉成 Xml 格式
                var pemprivatekey = opensslkey.DecodeOpenSSLPrivateKey(privateKey);
                if (pemprivatekey != null)
                {
                    RSACryptoServiceProvider rsa = opensslkey.DecodeRSAPrivateKey(pemprivatekey);
                    privateKey = rsa.ToXmlString(true);
                }

                string data = JsonConvert.SerializeObject(new
                {
                    orderNo = orderNo,
                    notifyTestUrl = notifyTestUrl,
                    notifyTestType = notifyTestType,
                    timestamp = Convert.ToInt64(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds).ToString()
                });
                GenSignature(privateKey, data, out string xSignature);

                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("X-Signature", xSignature);
                client.DefaultRequestHeaders.Add("X-Customer-Name", customerName);  
                string apiUri = $"{apiHost}/api/Test/GenerateNotifyManually";

                // Post
                StringContent httpContent = new StringContent(data, Encoding.UTF8, "application/json");
                var result = client.PostAsync(apiUri, httpContent).Result;
                var res = result.Content.ReadAsStringAsync().Result;
                JObject json = JObject.Parse(res);

                this.resultMessage.Text = json.ToString();

                return json;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception : " + ex.Message);
                return null;
            }
        }

        static void GenSignature(string RSAxmlStr, string data, out string xSignature)
        {
            xSignature = "";
            try
            {
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(); 
                rsa.FromXmlString(RSAxmlStr);
                var bytes = Encoding.UTF8.GetBytes(data);

                // sign
                var signature = rsa.SignData(bytes, 0, bytes.Length, SHA256.Create());
                  xSignature = Convert.ToBase64String(signature);

                // verify
                var isValid = rsa.VerifyData(bytes,   SHA256.Create(), signature);
                 
                Console.WriteLine("isValid  " + isValid);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception RSA file: " + e); 
            }
        }

        private System.Windows.Forms.RichTextBox privateKey;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox remark;
        private System.Windows.Forms.TextBox expectingAmount;
        private System.Windows.Forms.TextBox notifyUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox orderType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label resultMessage;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.TextBox orderNo;
        private System.Windows.Forms.Label OrderNoTilte;
        private System.Windows.Forms.TextBox notifyTestUrl;
        private System.Windows.Forms.TextBox notifyTestType;
        private System.Windows.Forms.Label labelnotifyTestUrl;
        private System.Windows.Forms.Label labelnotifyTestType;
        private System.Windows.Forms.Button NotifyManuallyBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

