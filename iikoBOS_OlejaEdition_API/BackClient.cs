using iiko_it_getversion_API;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace iikoBOS_prealpha_API
{
    public class BackClient
    {
        public ServerProperties GetServerProperties(string mUrl)
        {
            if (!mUrl.Contains("https://") && mUrl.Contains("iiko.it"))
            {
                mUrl = "https://" + mUrl;
            }

            else if (!mUrl.Contains("http://") && !mUrl.Contains("iiko.it"))
            {
                mUrl = "http://" + mUrl;
            }

            if (!mUrl.Contains("/resto"))
            { mUrl = mUrl + "/resto"; }

            var url = mUrl + "/get_server_info.jsp?encoding=UTF-8";
            UrlService urlService = new UrlService();

            var serverProperties = urlService.GetServerProperties(url);
            return serverProperties;
        }
        public void BackClientConfigEdit(string url, string login)
        {
            
            var serverProperties = GetServerProperties(url);
            string roamingpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string backclientconfig = "";
            if (serverProperties.Edition == "chain")
            {
                backclientconfig = roamingpath + @"\iiko\Chain\Default\config\backclient.config.xml";
            }
            else
            {
                backclientconfig = roamingpath + @"\iiko\Rms\Default\config\backclient.config.xml";
            }

            XElement userList = XElement.Load(backclientconfig);
            userList.RemoveAll();


            var uriparser = new Uri(url);
            var serverListXml = new XElement("ServersList",
                                        new XElement("ServerName", serverProperties.ServerName),
                                        new XElement("Version", serverProperties.Version),
                                        new XElement("ComputerName", serverProperties.computerName),
                                        new XElement("Protocol", uriparser.Scheme),
                                        new XElement("ServerAddr", uriparser.Host),
                                        new XElement("ServerSubUrl", uriparser.PathAndQuery),
                                        new XElement("Port", uriparser.Port.ToString()),
                                        new XElement("IsPresent", serverProperties.isPresent)
                                        );


            userList.Add(serverListXml);
            var loginXElement = new XElement("Login", login);
            userList.Element("ServersList").AddAfterSelf(loginXElement);
            userList.Save(backclientconfig);

        }
        public void OpenBackOffice(string mUrl,string path)
        {

            var serverProperties = GetServerProperties(mUrl);


            string versionName = serverProperties.Version.Remove(8, 2);
            string edition = "*Office*";

            if (serverProperties.Edition == "chain")
            {
                edition = "*Chain*Office*";
            }
            else
            {
                edition = "*Office*";
            }

            string searchPattern = edition + versionName;


            var directories = Directory.EnumerateDirectories(path, searchPattern, SearchOption.AllDirectories);
            try
            {
                foreach (var directory in directories)
                {
                    if (directory.Contains("Chain") && serverProperties.Edition != "chain")
                    {
                        continue;
                    }
                    else if (!(File.Exists(directory + @"\BackOffice.exe")))
                    {
                        continue;
                    }

                    else
                    {
                        using (Process myProcess = new Process())
                        {
                            myProcess.StartInfo.UseShellExecute = false;
                            myProcess.StartInfo.FileName = directory + @"\BackOffice.exe";
                            myProcess.StartInfo.CreateNoWindow = true;
                            myProcess.Start();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format(e.Message));
            }


        }
        public void CloseBackOffice()
        {
            Process[] allBackOfficeProcess = Process.GetProcessesByName("BackOffice");
            foreach (var backOfficeProcess in allBackOfficeProcess)
            {
                backOfficeProcess.Kill();
            }

        }

    }
}
