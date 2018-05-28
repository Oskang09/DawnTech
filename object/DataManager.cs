using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DawnTech
{
    public class DataManager
    {
        public static string ERROR_TRACKER_PATH = AppDomain.CurrentDomain.BaseDirectory + "/error.log";
        public static Dictionary<string, string> SETTINGS { get; set; }


        public static string BASE_PATH = AppDomain.CurrentDomain.BaseDirectory;
        public static string[] FILES = new string[] { "/data/", "/data/employee", "/data/workdata" };

        public DataManager()
        {
            if (!File.Exists(ERROR_TRACKER_PATH))
            {
                File.Create(ERROR_TRACKER_PATH).Close();
            }
            if (!Directory.Exists(BASE_PATH))
            {
                Directory.CreateDirectory(BASE_PATH);
            }
            foreach (string str in FILES)
            {
                if (str.Contains("."))
                {
                    if (!File.Exists(BASE_PATH + str))
                    {
                        File.Create(BASE_PATH + str).Close();
                    }
                }
                else
                {
                    if (!Directory.Exists(BASE_PATH + str))
                    {
                        Directory.CreateDirectory(BASE_PATH + str);
                    }
                }
            }
            
            SETTINGS = new Dictionary<string, string>();
            foreach (string str in File.ReadAllLines(BASE_PATH + "/config/setting.txt"))
            {
                if (str == "") continue;
                string[] array = str.Split(new[] { ':' }, 2);
                SETTINGS.Add(array[0], array[1].Substring(1));
            }
        }
    }
}
