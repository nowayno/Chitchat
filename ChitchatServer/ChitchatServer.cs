using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChitchatServer
{
    class ChitchatServer
    {
        /// <summary>
        /// 数据分析
        /// </summary>
        /// <param name="data">传入的数据</param>
        /// <returns>解析完的数据</returns>
        public Dictionary<string, string> dataAna(string data)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            string[] dataSplit = data.Split('#');
            foreach (string temple in dataSplit)
            {
                result.Add(temple.Split(',')[0], temple.Split(',')[1]);
            }
            return result;
        }
        /// <summary>
        /// 图片或者文件的分析
        /// </summary>
        /// <param name="data">图片或者文件</param>
        /// <returns>保存在服务器上的路径</returns>
        public string dataAna(byte data)
        {
            string path = "";

            return path;
        }

        static void Main(string[] args)
        {
            
        }
    }
}
