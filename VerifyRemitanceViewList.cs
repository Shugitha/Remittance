using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemittanceTest
{
    class VerifyRemitanceViewList
    {
        public string ActualList(string actuallist)
        {
            string[] list = new string[] { "File Name", "File Type", "Partner", "Status", "Total" };
            StringBuilder builder = new StringBuilder();
            foreach(string value in list)
            {
                builder.Append(value);
                builder.Append('.');
            }
            string result = builder.ToString();
            return result;
        }
    }
}
