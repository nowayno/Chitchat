using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChitchatServer
{
    class DataAnalysis
    {
        static public List<string> dataAna(byte[] data)
        {
            string dataString = Encoding.Default.GetString(data);
            List<string> result = new List<string>();

            return result;
        }
    }
}
