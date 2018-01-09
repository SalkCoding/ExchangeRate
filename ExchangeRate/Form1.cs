using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExchangeRate
{

    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public enum Bank
        {
            Sinhan = 1,
            KBH = 0
        }

        public Form1()
        {
            InitializeComponent();
            this.MouseWheel += new MouseEventHandler(RateSearch_Wheel);
            SelectBank.SelectedIndex = 0;
            Untill.UpdateData(Bank.KBH);
            display();
            using (WebClient Web = new WebClient())
            {
                String source = Web.DownloadString(@"http://info.finance.naver.com/marketindex/exchangeDailyQuote.nhn?marketindexCd=FX_USDKRW&page=100000");
                String[] delimiter = { "<a href=\"/marketindex/exchangeDailyQuote.nhn?marketindexCd=FX_USDKRW&page="};
                String[] str = source.Split(delimiter, StringSplitOptions.None);
                String Last = str[str.Length - 1];
                RateSearch.Minimum = 1;
                RateSearch.Maximum = Convert.ToInt32(Last.Split('\"')[0]);
            }
        }

        private void SelectBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ExchangeRateTab.SelectedTab.Name.Equals("TodayRatePage"))
            {
                switch (SelectBank.SelectedItem)
                {
                    case "신한은행":
                        BankPicture.Url = new Uri("https://ssl.pstatic.net/sstatic/keypage/outside/scui/foreigninfo/img/img_shinhan.png");
                        RateGrahp.Url = new Uri("http://imgfinance.naver.net/chart/marketindex/area/month3/FX_USDKRW.png");
                        Untill.UpdateData(Bank.Sinhan);
                        display();
                        break;
                    case "KBH 하나은행":
                        BankPicture.Url = new Uri("https://ssl.pstatic.net/sstatic/keypage/outside/scui/foreigninfo/img/img_hana.png");
                        RateGrahp.Url = new Uri("http://imgfinance.naver.net/chart/marketindex/area/month3/FX_USDKRW_SHB.png");
                        Untill.UpdateData(Bank.KBH);
                        display();
                        break;
                }
            }
            else if (ExchangeRateTab.SelectedTab.Name.Equals("SearchLastRate"))
            {
                switch (SelectBank.SelectedItem)
                {
                    case "신한은행":
                        LastRate.Url = new Uri("http://info.finance.naver.com/marketindex/exchangeDailyQuote.nhn?marketindexCd=FX_USDKRW_SHB&page=" + RateSearch.Value + "");
                        break;
                    case "KBH 하나은행":
                        LastRate.Url = new Uri("http://info.finance.naver.com/marketindex/exchangeDailyQuote.nhn?marketindexCd=FX_USDKRW&page=" + RateSearch.Value + "");
                        break;
                }
            }
        }

        private void getExchange(Double input, Calculation.CalNum num, Calculation.CalNum num1, Calculation.Bank bank)
        {
            if (num == num1)
            {
                ChangeAmout2.Text = ChangeAmout1.Text;
                return;
            }
            Calculation.CalNum[] list = { num, num1 };
            String[] result = new String[2];
            for (int i = 0; i < 2; i++)
            {
                if (list[i] == Calculation.CalNum.KRW)
                {
                    result[i] = "1";
                    continue;
                }
                String source = @"http://info.finance.naver.com/marketindex/exchangeDetail.nhn?marketindexCd=FX_";
                using (WebClient wc = new WebClient())
                {
                    source = source + list[i].ToString() + Calculation.CalNum.KRW.ToString();
                    switch (bank)
                    {
                        case Calculation.Bank._SHB:
                            source += Calculation.Bank._SHB.ToString();
                            break;
                    }
                    source = wc.DownloadString(source);
                }
                String[] delimiter = { "<option value=\"" };
                String str = source.Split(delimiter, StringSplitOptions.None)[2 + (int)list[i]];
                result[i] = str.Split('\"')[0].Split('\"')[0];
            }
            Double ExchangeTarget = Convert.ToDouble(result[0]);
            Double ExchangeResult = Convert.ToDouble(result[1]);
            Double Total = ((ExchangeTarget * input) / ExchangeResult);
            if (Total >= 1) {
                ChangeAmout2.Text = Total.ToString("#.##");
            }
            else
            {
                ChangeAmout2.Text = Total.ToString("0.##");
            }
            
        }

        public static Boolean isCorrectString(String str)
        {
            try
            {
                Convert.ToDouble(str);
                return true;
            }
            catch (Exception) { }
            return false;
        }

        private void display()
        {
            RefreshTime.Text = Data.RefreshDate;
            RateDollars.Text = "달러 당 " + Data.Dollar + "원";
            if (Data.isUp)
            {
                UpDown.Url = new Uri("http://static.naver.com/nfinance/ico_up.gif");
                CompareRate.Text = Data.ComparePercent + "% 상승";
            }
            else
            {
                UpDown.Url = new Uri("http://static.naver.com/nfinance/ico_down.gif");
                CompareRate.Text = Data.ComparePercent + "% 하락";
            }
        }

        private void RateSearch_Scroll(object sender, ScrollEventArgs e)
        {
            switch (SelectBank.SelectedItem)
            {
                case "신한은행":
                    LastRate.Url = new Uri("http://info.finance.naver.com/marketindex/exchangeDailyQuote.nhn?marketindexCd=FX_USDKRW_SHB&page=" + RateSearch.Value + "");
                    break;
                case "KBH 하나은행":
                    LastRate.Url = new Uri("http://info.finance.naver.com/marketindex/exchangeDailyQuote.nhn?marketindexCd=FX_USDKRW&page=" + RateSearch.Value + "");
                    break;
            }
            PageCount.Text = RateSearch.Value + " 입니다.";
        }

        private void RateSearch_Wheel(object sender, MouseEventArgs e)
        {
            switch (SelectBank.SelectedItem)
            {
                case "신한은행":
                    LastRate.Url = new Uri("http://info.finance.naver.com/marketindex/exchangeDailyQuote.nhn?marketindexCd=FX_USDKRW_SHB&page=" + RateSearch.Value + "");
                    break;
                case "KBH 하나은행":
                    LastRate.Url = new Uri("http://info.finance.naver.com/marketindex/exchangeDailyQuote.nhn?marketindexCd=FX_USDKRW&page=" + RateSearch.Value + "");
                    break;
            }
            PageCount.Text = RateSearch.Value + " 입니다.";
        }

        private void TodayRateTab_Changed(object sender, EventArgs e)
        {
            SelectBank_SelectedIndexChanged(sender, e);
        }

        private void ChangeAmount_Change(object sender, EventArgs e)//left
        {
            UpdataCalculate();
        }

        private void ListSelectedChanged(object sender, EventArgs e)
        {
            UpdataCalculate();
        }

        private void ListSelectedChanged1(object sender, EventArgs e)
        {
            UpdataCalculate();
        }

        private void UpdataCalculate()
        {
            if (ChangeAmout1.Text.Length <= 0)
            {
                ChangeAmout2.Text = "0";
                return;
            }
            if (isCorrectString(ChangeAmout1.Text))
            {
                getExchange(Convert.ToDouble(ChangeAmout1.Text), (Calculation.CalNum)ChangeList.SelectedIndex, (Calculation.CalNum)ChangeList1.SelectedIndex, Calculation.Bank.KBH);
            }
            else
            {
                ChangeAmout2.Text = "잘못된 입력입니다!";
            }
        }

        private void LastRateNavigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (!(e.Url.AbsoluteUri.Contains(@"http://info.finance.naver.com/marketindex/exchangeDailyQuote.nhn?marketindexCd=FX_USDKRW&page=")))
            {
                e.Cancel = true;
            }
        }
    }
}
