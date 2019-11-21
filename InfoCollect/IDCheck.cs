using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoCollect
{
    class IDCheck
    {
        /// <summary>
        /// 身份证验证
        /// </summary>
        /// <param name="Id">身份证号</param>
        /// <returns></returns>
        public static bool CheckIDCard(string Id)
        {
            if (Id.Length == 18)
            {
                bool check = CheckIDCard18(Id);
                return check;
            }
            else if (Id.Length == 15)
            {
                bool check = CheckIDCard15(Id);
                return check;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 18位身份证验证
        /// </summary>
        /// <param name="Id">身份证号</param>
        /// <returns></returns>
        private static bool CheckIDCard18(string Id)
        {
            long n = 0;
            if (long.TryParse(Id.Remove(17), out n) == false || n < Math.Pow(10, 16) || long.TryParse(Id.Replace('x', '0').Replace('X', '0'), out n) == false)
            {
                return false;//数字验证
            }
            string address = "11x22x35x44x53x12x23x36x45x54x13x31x37x46x61x14x32x41x50x62x15x33x42x51x63x21x34x43x52x64x65x71x81x82x91";
            if (address.IndexOf(Id.Remove(2)) == -1)
            {
                return false;//省份验证
            }
            string birth = Id.Substring(6, 8).Insert(6, "-").Insert(4, "-");
            DateTime time = new DateTime();
            if (DateTime.TryParse(birth, out time) == false)
            {
                return false;//生日验证
            }
            string[] arrVarifyCode = ("1,0,x,9,8,7,6,5,4,3,2").Split(',');
            string[] Wi = ("7,9,10,5,8,4,2,1,6,3,7,9,10,5,8,4,2").Split(',');
            char[] Ai = Id.Remove(17).ToCharArray();
            int sum = 0;
            for (int i = 0; i < 17; i++)
            {
                sum += int.Parse(Wi[i]) * int.Parse(Ai[i].ToString());
            }
            int y = -1;
            Math.DivRem(sum, 11, out y);
            if (arrVarifyCode[y] != Id.Substring(17, 1).ToLower())
            {
                return false;//校验码验证
            }
            return true;//符合GB11643-1999标准
        }
        /// <summary>
        /// 15位身份证验证
        /// </summary>
        /// <param name="Id">身份证号</param>
        /// <returns></returns>
        private static bool CheckIDCard15(string Id)
        {
            long n = 0;
            if (long.TryParse(Id, out n) == false || n < Math.Pow(10, 14))
            {
                return false;//数字验证
            }
            string address = "11x22x35x44x53x12x23x36x45x54x13x31x37x46x61x14x32x41x50x62x15x33x42x51x63x21x34x43x52x64x65x71x81x82x91";
            if (address.IndexOf(Id.Remove(2)) == -1)
            {
                return false;//省份验证
            }
            string birth = Id.Substring(6, 6).Insert(4, "-").Insert(2, "-");
            DateTime time = new DateTime();
            if (DateTime.TryParse(birth, out time) == false)
            {
                return false;//生日验证
            }
            return true;//符合15位身份证标准
        }

        //身份证读取后为民族代码，需要转换为文字
        public static string getNational(string code)
        {
            string result = string.Empty;
            switch (code)
            {
                case "01":
                    result = "汉族";
                    break;
                case "02":
                    result = "蒙古族";
                    break;
                case "03":
                    result = "回族";
                    break;
                case "04":
                    result = "藏族";
                    break;
                case "05":
                    result = "维吾尔族";
                    break;
                case "06":
                    result = "苗族";
                    break;
                case "07":
                    result = "彝族";
                    break;
                case "08":
                    result = "壮族";
                    break;
                case "09":
                    result = "布依族";
                    break;
                case "10":
                    result = "朝鲜族";
                    break;
                case "11":
                    result = "满族";
                    break;
                case "12":
                    result = "侗族";
                    break;
                case "13":
                    result = "瑶族";
                    break;
                case "14":
                    result = "白族";
                    break;
                case "15":
                    result = "土家族";
                    break;
                case "16":
                    result = "哈尼族";
                    break;
                case "17":
                    result = "哈萨克族";
                    break;
                case "18":
                    result = "傣族";
                    break;
                case "19":
                    result = "黎族";
                    break;
                case "20":
                    result = "僳僳族";
                    break;
                case "21":
                    result = "佤族";
                    break;
                case "22":
                    result = "畲族";
                    break;
                case "23":
                    result = "高山族";
                    break;
                case "24":
                    result = "拉祜族";
                    break;
                case "25":
                    result = "水族";
                    break;
                case "26":
                    result = "东乡族";
                    break;
                case "27":
                    result = "纳西族";
                    break;
                case "28":
                    result = "景颇族";
                    break;
                case "29":
                    result = "柯尔克孜族";
                    break;
                case "30":
                    result = "土族";
                    break;
                case "31":
                    result = "达斡尔族";
                    break;
                case "32":
                    result = "仫佬族";
                    break;
                case "33":
                    result = "羌族";
                    break;
                case "34":
                    result = "布朗族";
                    break;
                case "35":
                    result = "撒拉族";
                    break;
                case "36":
                    result = "毛难族";
                    break;
                case "37":
                    result = "仡佬族";
                    break;
                case "38":
                    result = "锡伯族";
                    break;
                case "39":
                    result = "阿昌族";
                    break;
                case "40":
                    result = "普米族";
                    break;
                case "41":
                    result = "塔吉克族";
                    break;
                case "42":
                    result = "怒族";
                    break;
                case "43":
                    result = "乌孜别克族";
                    break;
                case "44":
                    result = "俄罗斯族";
                    break;
                case "45":
                    result = "鄂温克族";
                    break;
                case "46":
                    result = "崩龙族";
                    break;
                case "47":
                    result = "保安族";
                    break;
                case "48":
                    result = "裕固族";
                    break;
                case "49":
                    result = "京族";
                    break;
                case "50":
                    result = "塔塔尔族";
                    break;
                case "51":
                    result = "独龙族";
                    break;
                case "52":
                    result = "鄂伦春族";
                    break;
                case "53":
                    result = "赫哲族";
                    break;
                case "54":
                    result = "门巴族";
                    break;
                case "55":
                    result = "珞巴族";
                    break;
                case "56":
                    result = "基诺族";
                    break;
                default:
                    result = "其他";
                    break;
            }
            return result;

        }
    }
}
