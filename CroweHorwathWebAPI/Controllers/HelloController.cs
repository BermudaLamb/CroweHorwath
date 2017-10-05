using System.Web.Http;

namespace CroweHorwathWebAPI.Controllers
{
    public class HelloController : ApiController
    {
        public string Post([FromBody]string value)
        {
            return string.Format("Hello {0}", value);
        }

    }
}
