using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CN.WXEXT
{
    public class WxExtApp
    {
        public static string name = "";
        public static string key = "";
        public static string user = "";
        public static string binduser = "";
        public static string datapath = "";
        public void CN_WXEXT_RUN()
        {
            Console.WriteLine("程序运行目录:{0}", Environment.CurrentDirectory);
            user = Environment.GetEnvironmentVariable("cn.wxext.user");
            binduser = Environment.GetEnvironmentVariable("cn.wxext.binduser");
            name = Environment.GetEnvironmentVariable("cn.wxext.name");
            key = Environment.GetEnvironmentVariable("cn.wxext.key");
            datapath = Environment.GetEnvironmentVariable("cn.wxext.datapath");
            var fileinfo = new FileInfo("www\\auth\\ws.json"); 
            if (!fileinfo.Directory.Exists) fileinfo.Directory.Create();
            File.WriteAllText(fileinfo.FullName, $"{{\"name\":\"{name}\",\"key\":\"{key}\"}}");
        }
    }
}