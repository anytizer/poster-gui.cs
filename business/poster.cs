using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace business
{
    class poster
    {
        public string post(string path, object data)
        {
            string result = "";
            string json = JsonConvert.SerializeObject(data);
            string server = "http://access.example.com:9090";

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(server + path);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream());
            streamWriter.Write(json);
            streamWriter.Flush();
            streamWriter.Close();

            HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            return result;
        }
    }
}
