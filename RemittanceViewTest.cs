using System;
using System.Text;
using Xunit;

namespace RemittanceTest
{
    public class RemittanceViewTest
    {
        [Fact]
        public void ListTest()
        {
            var list = new VerifyRemitanceViewList();
            var viewdlist = new string[] { "File Name", "File Type", "Partner", "Status", "Total" };
            StringBuilder builder = new StringBuilder();
            foreach(string value in viewdlist)
            {
                builder.Append(value);
                builder.Append('.');
            }
            string finalview = builder.ToString();
            string actualview = list.ActualList(finalview);
            Assert.Equal(actualview, finalview);
        }
    }
}
