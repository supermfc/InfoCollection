using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace InfoCollect
{
    public class Base
    {
        static public Dictionary<string, string> Options = new Dictionary<string, string>();

        
        [DllImport("SRIDreadcard.dll")]
        public extern static void setTheServer(
            string serverAddress,
            int serverPort,
            string serverSndAddress,
            int serverSndPort);
           

        [DllImport("SRIDreadcard.dll", EntryPoint = "readCard", CharSet = CharSet.Auto, SetLastError = false)]
        public static extern int readCard(ref IDInfo info, int timeOut);

        [DllImport("WltRS.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetBmp(string pucPHMsg, int intf);


        public struct IDInfo
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1024)]
            public string address;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string authority;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1024)]
            public string avatar;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 30)]
            public string birth;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
            public string cardNo;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
            public string ethnicity;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string name;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
            public string period;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
            public string sex;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
            public string dn;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1024)]
            public string fingerprint;
        }

        public static string getRspMsg(int v)
        {
            string msg = "";
            switch (v)
            {
                case 0:
                    msg = v.ToString() + " 读取成功";
                    break;
                case -1:
                    msg = v.ToString() + " 没有找到阅读器";
                    break;
                case -2:
                    msg = v.ToString() + " 不允许阅读器匹配多部手机";
                    break;
                case -3:
                    msg = v.ToString() + " 网络异常，请检查当前网络状态";
                    break;
                case -4:
                    msg = v.ToString() + " 请检查证件是否旋转在设备上";
                    break;
                case -5:
                    msg = v.ToString() + " 服务器处理异常";
                    break;
                case -6:
                    msg = v.ToString() + " 阅读器异常错误";
                    break;
                case -7:
                    msg = v.ToString() + " 出现错误需要重试";
                    break;
                case -8:
                    msg = v.ToString() + " 打开身份证错误";
                    break;
                case -9:
                    msg = v.ToString() + " 无法连接服务器";
                    break;
                case -10:
                    msg = v.ToString() + " 服务器连接超时";
                    break;
                case -11:
                    msg = v.ToString() + " 服务器连接失败";
                    break;
                case -12:
                    msg = v.ToString() + " 服务器处理繁忙";
                    break;
                default:
                    msg = v.ToString() + "未知状态";
                    break;
            }
            return msg;
        }
    }
}
