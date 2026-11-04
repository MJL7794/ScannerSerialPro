using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
namespace ScannerSerialPro.工具层
{
      public class IniConfigHelper{

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        // 明确指定 Unicode
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        [DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
        private static extern uint GetPrivateProfileStringA(string section, string key, string def, byte[] retVal, uint size, string filePath);
        public static List<string> ReadSections(string iniFilename) { 
            List<string> result = new List<string>();
            Byte[] buf = new Byte[65536];
            uint len = GetPrivateProfileStringA(null, null, null, buf, (uint)buf.Length, iniFilename);
            int j = 0;
            for (int i = 0; i < len; i++)
            {
                if (buf[i] == 0)
                {

                    result.Add(Encoding.Default.GetString(buf, j, i - j));
                    j = i + 1;
                }
            }
            return result;
        }
        public static List<string> ReadKeys(string SectionName, string inifilename)
        {
            List<string> result = new List<string>();
            Byte[] buf = new Byte[65536];
            uint len = GetPrivateProfileStringA(SectionName, null, null, buf, (uint)buf.Length, inifilename);
            int j = 0;
            for (int i = 0; i < len; i++)
            {
                if (buf[i] == 0)
                {
                    result.Add(Encoding.Default.GetString(buf, j, i - j));
                    j = i + 1;
                }
            }
            return result;


        }
        public static string ReadIniData(string Section, string Key, string DefaultValue, string iniFilePath) {
            if (File.Exists(iniFilePath)) {
                StringBuilder temp = new StringBuilder(1024);
                GetPrivateProfileString(Section, Key, DefaultValue, temp, 1024, iniFilePath);
                return temp.ToString();
            }
            return string.Empty;
        }
        public static bool WriteIniData(string Section, string Key, string Value, string iniFilePath) {
            long OpStation = WritePrivateProfileString(Section, Key, Value, iniFilePath);
            if (OpStation == 0) {
                return false;
            }
            return true;
        }


       }
}
