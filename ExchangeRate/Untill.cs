using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRate
{
    static class Untill
    {
        public static void UpdateData(Form1.Bank Bank)
        {
            switch (Bank)
            {
                case Form1.Bank.KBH:
                    using (WebClient Web = new WebClient())
                    {
                        //Web.Encoding = Encoding.UTF8;
                        String source = Web.DownloadString("http://info.finance.naver.com/marketindex/exchangeDetail.nhn?marketindexCd=FX_USDKRW");
                        UpdateData(source);
                    }
                    break;
                case Form1.Bank.Sinhan:
                    using (WebClient Web = new WebClient())
                    {
                        //Web.Encoding = Encoding.UTF8;
                        String source = Web.DownloadString("http://info.finance.naver.com/marketindex/exchangeDetail.nhn?marketindexCd=FX_USDKRW_SHB");
                        UpdateData(source);
                    }
                    break;
            }
        }

        private static void UpdateData(String source)
        {
            String[] delimiter = { "<option value=\"" };
            String str = source.Split(delimiter, StringSplitOptions.None)[2];
            str = str.Split('\"')[0].Split('\"')[0];
            Data.Dollar = Convert.ToDouble(str);
            delimiter[0] = "<span class=\"date\">";
            str = source.Split(delimiter, StringSplitOptions.None)[1];
            Data.RefreshDate = str.Split('<')[0];
            delimiter[0] = "<td><img src=\"";
            str = source.Split(delimiter, StringSplitOptions.None)[1];
            delimiter[0] = "alt=\"";
            if (str.Split(delimiter, StringSplitOptions.None)[1].Split('\"')[0].Equals("상승"))
                Data.isUp = true;
            else
                Data.isUp = false;
            delimiter[0] = "\"> ";
            str = str.Split(delimiter, StringSplitOptions.None)[1].Split('<')[0];
            Data.ComparePercent = Convert.ToDouble(str);
        }

    }
}
