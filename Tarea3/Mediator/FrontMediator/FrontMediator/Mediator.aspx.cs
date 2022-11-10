using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace FrontMediator
{
    public partial class Mediator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnEnviar_Click(object sender, EventArgs e)
        {
            EnviarMensaje();
            GV1.DataBind();
        }

        public void EnviarMensaje()
        {
            MSN mensaje = new MSN();

            mensaje.Usuario = DLUsuario.Text;
            mensaje.Mensaje = TxtMensaje.Text;
            string text = JsonConvert.SerializeObject(mensaje);
            try
            {
                System.IO.File.WriteAllText(@"D:\Debug.json", text);
            }
            catch (Exception ex) { }

            Uri uri = new Uri("https://localhost:7005/Mediator/mediador");

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(uri);

            request.Method = "POST";
            request.ContentType = "application/json";
            //request.Headers.Add("Authorization", "Basic TUZDLVRFU1Q6dkp1OVdKK2wxbw==");

            XmlDocument resultadoSOAPencrypted = new XmlDocument();

            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
            byte[] bytes = encoding.GetBytes(text);
            request.ContentLength = bytes.Length;


            using (Stream requestStream = request.GetRequestStream())
            {
                // Send the data.
                requestStream.Write(bytes, 0, bytes.Length);
            }

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                StreamReader srd = new StreamReader(response.GetResponseStream());
                var result1 = srd.ReadToEnd();
                //return result1;
            }


        }
    }


}

public class MSN
{
    public string Usuario { get; set; }
    public string Mensaje { get; set; }
}