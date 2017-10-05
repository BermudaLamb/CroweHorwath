using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CroweHorwathWebAPI.Controllers;
using System.Configuration;
using System.Net;
using System.Text;
using System.IO;

namespace CroweHorwathWebAPI.Tests.Controllers
{
    [TestClass]
    public class HelloControllerTest
    {
        [TestMethod]
        public void Post()
        {
            // Arrange
            HelloController controller = new HelloController();

            // Act
            var result = controller.Post("World");

            // Assert
            StringAssert.Equals("Hello World", result);
        }

        [TestMethod]
        public void PostAPI()
        {
            var api = ConfigurationManager.AppSettings["HelloAPI"]
                ?? "http://localhost/api/Hello";
            var webrequest = (HttpWebRequest)WebRequest.Create(api);
            var value = "\"Crowe Horwath\"";
            webrequest.Method = "POST";
            webrequest.Accept = "application/json";
            webrequest.ContentType = "text/json";
            webrequest.ContentLength = value.Length;
            using (var stream = webrequest.GetRequestStream())
            {
                var encoding = new ASCIIEncoding();
                stream.Write(encoding.GetBytes(value), 0, value.Length);
                stream.Close();
            }
            var response = (HttpWebResponse)webrequest.GetResponse();
            var enc = Encoding.GetEncoding("utf-8");
            using (var reader = new StreamReader(response.GetResponseStream(), enc))
            {
                var result = reader.ReadToEnd();
                // Assert
                StringAssert.Equals("Hello Crowe Horwath", result);
            }
            response.Close();
        }

    }
}
