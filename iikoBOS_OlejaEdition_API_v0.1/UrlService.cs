using System.IO;
using System.Net;

namespace iiko_it_getversion_API
{

    public class UrlService
    {

        public ServerProperties GetServerProperties(string url)
        {
            WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(url);
            WebProxy myProxy = new WebProxy("myproxy", 80);
            myProxy.BypassProxyOnLocal = true;
            
            Stream objStream = wrGETURL.GetResponse().GetResponseStream();
            StreamReader objReader = new StreamReader(objStream);
            ServerProperties serverProperties = new ServerProperties(objReader.ReadLine());

            return serverProperties;
        }

      

    }
}
