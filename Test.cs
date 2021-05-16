        public void ChangeDNS(string dnsValue = "test.svia.ml")
        {
            try
            {
                string result = string.Empty;
                byte[] bytes = Encoding.Default.GetBytes($"login_token=235372,e920f89d5f40621e4e15ad4d8f8343c9&format=json&domain_id=82917864&record_id=810955568&sub_domain=mc-wb&value={dnsValue}&record_type=CNAME&record_line_id=0");
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://dnsapi.cn/Record.Modify");
                request.Method = "POST";
                request.UserAgent = "Minecraft Authorized/0.0.1Beta (550645679@qq.com)";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = bytes.Length;
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(bytes, 0, bytes.Length);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                if (responseStream != null)
                {
                    using StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    result = reader.ReadToEnd();
                    reader.Close();
                }
                var rsInfo = (JObject)JsonConvert.DeserializeObject<dynamic>(result);
                MessageBox.Show($"{rsInfo["status"]["code"]}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }