using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace Microsoft.Web.RedisSessionStateProvider.Demo
{
    public class RedisSessionLog
    {
        public static TextWriter OnWrite()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Log.txt";
            FileStream fs = File.Open(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);

            return new StreamWriter(fs);
        }
    }
}