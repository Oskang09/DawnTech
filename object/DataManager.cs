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
        public static Dictionary<string, string> SETTINGS { get; set; }

        public DataManager()
        {
            SETTINGS = new Dictionary<string, string>();

            foreach (string str in File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "/config/setting.txt"))
            {
                if (str == "") continue;
                string[] array = str.Split(new[] { ':' }, 2);
                SETTINGS.Add(array[0], array[1].Substring(1));
            }
        }
    }
}
