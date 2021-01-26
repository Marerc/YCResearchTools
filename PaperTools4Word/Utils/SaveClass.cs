using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PaperTools4Word.Utils
{
    class SaveClass
    {
        public string thesis_name = "";
        public string version_name = "";
        public int version1 = 0;
        public int version2 = 0;

        public SaveClass(string s)
        {
            // 输出一个字符串创建保存类
            string[] ss = s.Split('-');
            // 可能符合规则
            if(ss.Length > 1)
            {
                string[] tmp2 = ss[0].Split('.');
                this.thesis_name = tmp2[0];
                if(tmp2.Length > 1)
                {
                    this.version_name = tmp2[1];
                }

                if (ss[1].Contains("v"))
                {
                    string tmps1 = ss[1].Replace("v", "");
                    string[] sa1 = tmps1.Split('.');
                    if (sa1.Length > 1)
                    {
                        try
                        {
                            this.version1 = Convert.ToInt16(sa1[0]);
                        }
                        catch (Exception)
                        {

                        }

                        try
                        {
                            this.version2 = Convert.ToInt16(sa1[1]);
                        }
                        catch (Exception)
                        {

                        }

                    }

                }


            }

        }

        //public string[] getNameVersion(string s)
        //{

        //    //毕业论文综述 - v0.01 - 202010
        //    //毕业论文综述 _ 最终修改版 - v0.01 - 202010
        //    string[] rtn = new string[] { };

        //    Dictionary<string, string> openWith = new Dictionary<string, string>();

        //    List<string> rtnl = new List<string>();

        //    string[] tmp1 = s.Split('-');
        //    string[] tmp2 = tmp1[0].Split('_');

        //    foreach(string ts in tmp2)
        //    {
        //        rtnl.Add(ts);
        //    }

        //    if (tmp2.Length < 2)
        //    {
        //        rtnl.Add("");
        //    }

        //    rtn[0] =  


        //    //返回名称-大版本-小版本
        //    return rtn;
        //}

        public static void mySave()
        {

        }

    }
}
