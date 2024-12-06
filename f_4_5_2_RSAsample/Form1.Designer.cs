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
            this.SuspendLayout();
            // 
            // privateKey
            // 
            this.privateKey.Location = new System.Drawing.Point(114, 41);
            this.privateKey.Name = "privateKey";
            this.privateKey.Size = new System.Drawing.Size(233, 132);
            this.privateKey.TabIndex = 0;
            this.privateKey.Text = "";
            this.privateKey.TextChanged += new System.EventHandler(this.privateKey_TextChanged);
            // 
            // CustomerName
            // 
            this.CustomerName.Location = new System.Drawing.Point(114, 13);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(233, 22);
            this.CustomerName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "CustomerName";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // remark
            // 
            this.remark.Location = new System.Drawing.Point(114, 218);
            this.remark.Name = "remark";
            this.remark.Size = new System.Drawing.Size(233, 22);
            this.remark.TabIndex = 3;
            this.remark.Text = "SampleTest";
            // 
            // expectingAmount
            // 
            this.expectingAmount.Location = new System.Drawing.Point(114, 246);
            this.expectingAmount.Name = "expectingAmount";
            this.expectingAmount.Size = new System.Drawing.Size(233, 22);
            this.expectingAmount.TabIndex = 4;
            // 
            // notifyUrl
            // 
            this.notifyUrl.Location = new System.Drawing.Point(114, 274);
            this.notifyUrl.Name = "notifyUrl";
            this.notifyUrl.Size = new System.Drawing.Size(233, 22);
            this.notifyUrl.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Remark";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "USDT Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Notify URL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "10 : 存入 / 20 : 支付";
            // 
            // orderType
            // 
            this.orderType.Location = new System.Drawing.Point(114, 185);
            this.orderType.Name = "orderType";
            this.orderType.Size = new System.Drawing.Size(100, 22);
            this.orderType.TabIndex = 11;
            this.orderType.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "OrderType";
            // 
            // resultMessage
            // 
            this.resultMessage.AutoSize = true;
            this.resultMessage.Location = new System.Drawing.Point(112, 338);
            this.resultMessage.Name = "resultMessage";
            this.resultMessage.Size = new System.Drawing.Size(44, 12);
            this.resultMessage.TabIndex = 13;
            this.resultMessage.Text = "Message";
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(114, 302);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(75, 23);
            this.SendBtn.TabIndex = 14;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.Send_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(425, 578);
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

            try
            { 
                // Create signature
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
                    timestamp = Convert.ToInt64(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds).ToString()
                }); 
                GenSignature(privateKey, data, out string xSignature);

                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("X-Signature", xSignature);
                client.DefaultRequestHeaders.Add("X-Customer-Name", customerName);
                string apiHost = "https://stage-usdtpayfi-api.azurewebsites.net";
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
    }
}

