namespace ExchangeRate
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ExchangeRateTab = new MetroFramework.Controls.MetroTabControl();
            this.TodayRatePage = new MetroFramework.Controls.MetroTabPage();
            this.UpDown = new System.Windows.Forms.WebBrowser();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.BankPicture = new System.Windows.Forms.WebBrowser();
            this.CompareRate = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.RateDollars = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.RateGrahp = new System.Windows.Forms.WebBrowser();
            this.RefreshTime = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SearchLastRate = new MetroFramework.Controls.MetroTabPage();
            this.PageCount = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.RateSearch = new MetroFramework.Controls.MetroTrackBar();
            this.LastRate = new System.Windows.Forms.WebBrowser();
            this.CalculationRate = new MetroFramework.Controls.MetroTabPage();
            this.ExchangeList = new System.Windows.Forms.WebBrowser();
            this.ChangeList1 = new MetroFramework.Controls.MetroComboBox();
            this.ChangeList = new MetroFramework.Controls.MetroComboBox();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.ChangeAmout2 = new MetroFramework.Controls.MetroTextBox();
            this.ChangeAmout1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SelectBank = new MetroFramework.Controls.MetroComboBox();
            this.ExchangeRateTab.SuspendLayout();
            this.TodayRatePage.SuspendLayout();
            this.SearchLastRate.SuspendLayout();
            this.CalculationRate.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExchangeRateTab
            // 
            this.ExchangeRateTab.Controls.Add(this.TodayRatePage);
            this.ExchangeRateTab.Controls.Add(this.SearchLastRate);
            this.ExchangeRateTab.Controls.Add(this.CalculationRate);
            this.ExchangeRateTab.Location = new System.Drawing.Point(17, 116);
            this.ExchangeRateTab.Name = "ExchangeRateTab";
            this.ExchangeRateTab.SelectedIndex = 1;
            this.ExchangeRateTab.Size = new System.Drawing.Size(760, 507);
            this.ExchangeRateTab.TabIndex = 0;
            this.ExchangeRateTab.UseSelectable = true;
            this.ExchangeRateTab.SelectedIndexChanged += new System.EventHandler(this.TodayRateTab_Changed);
            this.ExchangeRateTab.TabIndexChanged += new System.EventHandler(this.SelectBank_SelectedIndexChanged);
            // 
            // TodayRatePage
            // 
            this.TodayRatePage.Controls.Add(this.UpDown);
            this.TodayRatePage.Controls.Add(this.webBrowser2);
            this.TodayRatePage.Controls.Add(this.BankPicture);
            this.TodayRatePage.Controls.Add(this.CompareRate);
            this.TodayRatePage.Controls.Add(this.metroLabel5);
            this.TodayRatePage.Controls.Add(this.RateDollars);
            this.TodayRatePage.Controls.Add(this.metroLabel4);
            this.TodayRatePage.Controls.Add(this.metroLabel3);
            this.TodayRatePage.Controls.Add(this.RateGrahp);
            this.TodayRatePage.Controls.Add(this.RefreshTime);
            this.TodayRatePage.Controls.Add(this.metroLabel2);
            this.TodayRatePage.HorizontalScrollbarBarColor = true;
            this.TodayRatePage.HorizontalScrollbarHighlightOnWheel = false;
            this.TodayRatePage.HorizontalScrollbarSize = 10;
            this.TodayRatePage.Location = new System.Drawing.Point(4, 38);
            this.TodayRatePage.Name = "TodayRatePage";
            this.TodayRatePage.Size = new System.Drawing.Size(752, 465);
            this.TodayRatePage.TabIndex = 0;
            this.TodayRatePage.Text = "오늘의 환율";
            this.TodayRatePage.VerticalScrollbarBarColor = true;
            this.TodayRatePage.VerticalScrollbarHighlightOnWheel = false;
            this.TodayRatePage.VerticalScrollbarSize = 10;
            // 
            // UpDown
            // 
            this.UpDown.Location = new System.Drawing.Point(141, 88);
            this.UpDown.MinimumSize = new System.Drawing.Size(20, 20);
            this.UpDown.Name = "UpDown";
            this.UpDown.ScrollBarsEnabled = false;
            this.UpDown.Size = new System.Drawing.Size(20, 20);
            this.UpDown.TabIndex = 12;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(713, 135);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.ScrollBarsEnabled = false;
            this.webBrowser2.Size = new System.Drawing.Size(43, 48);
            this.webBrowser2.TabIndex = 11;
            this.webBrowser2.Url = new System.Uri("http://imgfinance.naver.net/nfinance/flag/flag_USD.png", System.UriKind.Absolute);
            // 
            // BankPicture
            // 
            this.BankPicture.Location = new System.Drawing.Point(635, 421);
            this.BankPicture.MinimumSize = new System.Drawing.Size(20, 20);
            this.BankPicture.Name = "BankPicture";
            this.BankPicture.ScrollBarsEnabled = false;
            this.BankPicture.Size = new System.Drawing.Size(114, 41);
            this.BankPicture.TabIndex = 10;
            this.BankPicture.Url = new System.Uri("https://ssl.pstatic.net/sstatic/keypage/outside/scui/foreigninfo/img/img_hana.png" +
        "", System.UriKind.Absolute);
            // 
            // CompareRate
            // 
            this.CompareRate.AutoSize = true;
            this.CompareRate.Location = new System.Drawing.Point(78, 95);
            this.CompareRate.Name = "CompareRate";
            this.CompareRate.Size = new System.Drawing.Size(16, 19);
            this.CompareRate.TabIndex = 9;
            this.CompareRate.Text = "0";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(0, 95);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(72, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "전일대비 :";
            // 
            // RateDollars
            // 
            this.RateDollars.AutoSize = true;
            this.RateDollars.Location = new System.Drawing.Point(118, 57);
            this.RateDollars.Name = "RateDollars";
            this.RateDollars.Size = new System.Drawing.Size(16, 19);
            this.RateDollars.TabIndex = 7;
            this.RateDollars.Text = "0";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(0, 57);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(112, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "현재 달러 환율 : ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(0, 135);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(115, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "현재 환율 그래프";
            // 
            // RateGrahp
            // 
            this.RateGrahp.Location = new System.Drawing.Point(0, 157);
            this.RateGrahp.MinimumSize = new System.Drawing.Size(20, 20);
            this.RateGrahp.Name = "RateGrahp";
            this.RateGrahp.ScrollBarsEnabled = false;
            this.RateGrahp.Size = new System.Drawing.Size(752, 260);
            this.RateGrahp.TabIndex = 4;
            this.RateGrahp.Url = new System.Uri("http://imgfinance.naver.net/chart/marketindex/area/month3/FX_USDKRW_SHB.png", System.UriKind.Absolute);
            // 
            // RefreshTime
            // 
            this.RefreshTime.AutoSize = true;
            this.RefreshTime.Location = new System.Drawing.Point(142, 19);
            this.RefreshTime.Name = "RefreshTime";
            this.RefreshTime.Size = new System.Drawing.Size(55, 19);
            this.RefreshTime.TabIndex = 3;
            this.RefreshTime.Text = "0-0-0-0";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(0, 19);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(136, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "최근 업데이트 시각 :";
            // 
            // SearchLastRate
            // 
            this.SearchLastRate.Controls.Add(this.PageCount);
            this.SearchLastRate.Controls.Add(this.metroLabel6);
            this.SearchLastRate.Controls.Add(this.RateSearch);
            this.SearchLastRate.Controls.Add(this.LastRate);
            this.SearchLastRate.HorizontalScrollbarBarColor = true;
            this.SearchLastRate.HorizontalScrollbarHighlightOnWheel = false;
            this.SearchLastRate.HorizontalScrollbarSize = 10;
            this.SearchLastRate.Location = new System.Drawing.Point(4, 38);
            this.SearchLastRate.Name = "SearchLastRate";
            this.SearchLastRate.Size = new System.Drawing.Size(752, 465);
            this.SearchLastRate.TabIndex = 3;
            this.SearchLastRate.Text = "지난 환율 검색";
            this.SearchLastRate.VerticalScrollbarBarColor = true;
            this.SearchLastRate.VerticalScrollbarHighlightOnWheel = false;
            this.SearchLastRate.VerticalScrollbarSize = 10;
            // 
            // PageCount
            // 
            this.PageCount.AutoSize = true;
            this.PageCount.Location = new System.Drawing.Point(99, 11);
            this.PageCount.Name = "PageCount";
            this.PageCount.Size = new System.Drawing.Size(14, 19);
            this.PageCount.TabIndex = 5;
            this.PageCount.Text = "1";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(3, 11);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(90, 19);
            this.metroLabel6.TabIndex = 4;
            this.metroLabel6.Text = "현재 페이지 :";
            // 
            // RateSearch
            // 
            this.RateSearch.BackColor = System.Drawing.Color.Transparent;
            this.RateSearch.Location = new System.Drawing.Point(0, 33);
            this.RateSearch.MouseWheelBarPartitions = 5;
            this.RateSearch.Name = "RateSearch";
            this.RateSearch.Size = new System.Drawing.Size(752, 23);
            this.RateSearch.TabIndex = 3;
            this.RateSearch.Value = 1;
            this.RateSearch.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RateSearch_Scroll);
            // 
            // LastRate
            // 
            this.LastRate.Location = new System.Drawing.Point(0, 62);
            this.LastRate.MinimumSize = new System.Drawing.Size(20, 20);
            this.LastRate.Name = "LastRate";
            this.LastRate.ScriptErrorsSuppressed = true;
            this.LastRate.ScrollBarsEnabled = false;
            this.LastRate.Size = new System.Drawing.Size(756, 400);
            this.LastRate.TabIndex = 2;
            this.LastRate.Url = new System.Uri("http://info.finance.naver.com/marketindex/exchangeDailyQuote.nhn?marketindexCd=FX" +
        "_USDKRW&page=1", System.UriKind.Absolute);
            // 
            // CalculationRate
            // 
            this.CalculationRate.Controls.Add(this.ExchangeList);
            this.CalculationRate.Controls.Add(this.ChangeList1);
            this.CalculationRate.Controls.Add(this.ChangeList);
            this.CalculationRate.Controls.Add(this.metroLink1);
            this.CalculationRate.Controls.Add(this.ChangeAmout2);
            this.CalculationRate.Controls.Add(this.ChangeAmout1);
            this.CalculationRate.HorizontalScrollbarBarColor = true;
            this.CalculationRate.HorizontalScrollbarHighlightOnWheel = false;
            this.CalculationRate.HorizontalScrollbarSize = 10;
            this.CalculationRate.Location = new System.Drawing.Point(4, 38);
            this.CalculationRate.Name = "CalculationRate";
            this.CalculationRate.Size = new System.Drawing.Size(752, 465);
            this.CalculationRate.TabIndex = 4;
            this.CalculationRate.Text = "환율 계산기";
            this.CalculationRate.VerticalScrollbarBarColor = true;
            this.CalculationRate.VerticalScrollbarHighlightOnWheel = false;
            this.CalculationRate.VerticalScrollbarSize = 10;
            // 
            // ExchangeList
            // 
            this.ExchangeList.AllowNavigation = false;
            this.ExchangeList.Location = new System.Drawing.Point(-4, 119);
            this.ExchangeList.MinimumSize = new System.Drawing.Size(20, 20);
            this.ExchangeList.Name = "ExchangeList";
            this.ExchangeList.ScriptErrorsSuppressed = true;
            this.ExchangeList.Size = new System.Drawing.Size(760, 350);
            this.ExchangeList.TabIndex = 8;
            this.ExchangeList.Url = new System.Uri("http://info.finance.naver.com/marketindex/exchangeList.nhn", System.UriKind.Absolute);
            // 
            // ChangeList1
            // 
            this.ChangeList1.FormattingEnabled = true;
            this.ChangeList1.ItemHeight = 23;
            this.ChangeList1.Items.AddRange(new object[] {
            "대한민국 원 KRW",
            "미국 달러 USD",
            "유럽연합 유로 EUR",
            "일본 엔 JPY (100엔)",
            "중국 위안 CNY",
            "홍콩 달러 HKD",
            "대만 달러 TWD",
            "영국 파운드 GBP",
            "오만 리알 OMR",
            "캐나다 달러 CAD",
            "스위스 프랑 CHF",
            "스웨덴 크로나 SEK",
            "호주 달러 AUD",
            "뉴질랜드 코루나 CZK",
            "칠레 페소 CLP",
            "터키 리라 TRY",
            "몽골 투그릭 MNT",
            "이스라엘 세켈 ILS",
            "덴마크 크로넬 DKK",
            "노르웨이 크로네 NOK",
            "사우디아라비아 리얄 SAR",
            "쿠웨이트 디나르 KWD",
            "바레인 디나르 BHD",
            "아랍에미리트 디르함 AED",
            "요르단 디나르 JOD",
            "이집트 파운드 EGP",
            "태국 바트 THB",
            "싱가포트 달러 SGD",
            "말레이시아 링깃 MYR",
            "인도네시아 루피아 IDR",
            "카타르 리얄 QAR",
            "카자흐스탄 텡게 KZT",
            "브루나이 달러 BND",
            "인도 루피 INR",
            "파키스탄 루피 PKR",
            "방글라데시 타카 BDT",
            "필리핀 페소 PHP",
            "멕시코 페소 MXN",
            "브라질 레알 BRL",
            "베트남 동 VND",
            "남아프리카 공화국 랜드 ZAR",
            "러시아 루블 RUB",
            "헝가리 포린트 HUF",
            "폴란드 즈워티 PLN"});
            this.ChangeList1.Location = new System.Drawing.Point(418, 46);
            this.ChangeList1.Name = "ChangeList1";
            this.ChangeList1.Size = new System.Drawing.Size(250, 29);
            this.ChangeList1.TabIndex = 6;
            this.ChangeList1.UseSelectable = true;
            this.ChangeList1.SelectedIndexChanged += new System.EventHandler(this.ListSelectedChanged1);
            // 
            // ChangeList
            // 
            this.ChangeList.DisplayFocus = true;
            this.ChangeList.FormattingEnabled = true;
            this.ChangeList.ItemHeight = 23;
            this.ChangeList.Items.AddRange(new object[] {
            "대한민국 원 KRW",
            "미국 달러 USD",
            "유럽연합 유로 EUR",
            "일본 엔 JPY (100엔)",
            "중국 위안 CNY",
            "홍콩 달러 HKD",
            "대만 달러 TWD",
            "영국 파운드 GBP",
            "오만 리알 OMR",
            "캐나다 달러 CAD",
            "스위스 프랑 CHF",
            "스웨덴 크로나 SEK",
            "호주 달러 AUD",
            "뉴질랜드 코루나 CZK",
            "칠레 페소 CLP",
            "터키 리라 TRY",
            "몽골 투그릭 MNT",
            "이스라엘 세켈 ILS",
            "덴마크 크로넬 DKK",
            "노르웨이 크로네 NOK",
            "사우디아라비아 리얄 SAR",
            "쿠웨이트 디나르 KWD",
            "바레인 디나르 BHD",
            "아랍에미리트 디르함 AED",
            "요르단 디나르 JOD",
            "이집트 파운드 EGP",
            "태국 바트 THB",
            "싱가포트 달러 SGD",
            "말레이시아 링깃 MYR",
            "인도네시아 루피아 IDR",
            "카타르 리얄 QAR",
            "카자흐스탄 텡게 KZT",
            "브루나이 달러 BND",
            "인도 루피 INR",
            "파키스탄 루피 PKR",
            "방글라데시 타카 BDT",
            "필리핀 페소 PHP",
            "멕시코 페소 MXN",
            "브라질 레알 BRL",
            "베트남 동 VND",
            "남아프리카 공화국 랜드 ZAR",
            "러시아 루블 RUB",
            "헝가리 포린트 HUF",
            "폴란드 즈워티 PLN"});
            this.ChangeList.Location = new System.Drawing.Point(81, 46);
            this.ChangeList.Name = "ChangeList";
            this.ChangeList.Size = new System.Drawing.Size(250, 29);
            this.ChangeList.TabIndex = 5;
            this.ChangeList.UseSelectable = true;
            this.ChangeList.SelectedIndexChanged += new System.EventHandler(this.ListSelectedChanged);
            // 
            // metroLink1
            // 
            this.metroLink1.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.metroLink1.Location = new System.Drawing.Point(337, 46);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(75, 58);
            this.metroLink1.TabIndex = 4;
            this.metroLink1.Text = "=";
            this.metroLink1.UseSelectable = true;
            // 
            // ChangeAmout2
            // 
            // 
            // 
            // 
            this.ChangeAmout2.CustomButton.Image = null;
            this.ChangeAmout2.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.ChangeAmout2.CustomButton.Name = "";
            this.ChangeAmout2.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.ChangeAmout2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ChangeAmout2.CustomButton.TabIndex = 1;
            this.ChangeAmout2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ChangeAmout2.CustomButton.UseSelectable = true;
            this.ChangeAmout2.CustomButton.Visible = false;
            this.ChangeAmout2.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.ChangeAmout2.Lines = new string[] {
        "0"};
            this.ChangeAmout2.Location = new System.Drawing.Point(418, 81);
            this.ChangeAmout2.MaxLength = 32767;
            this.ChangeAmout2.Name = "ChangeAmout2";
            this.ChangeAmout2.PasswordChar = '\0';
            this.ChangeAmout2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ChangeAmout2.SelectedText = "";
            this.ChangeAmout2.SelectionLength = 0;
            this.ChangeAmout2.SelectionStart = 0;
            this.ChangeAmout2.ShortcutsEnabled = true;
            this.ChangeAmout2.Size = new System.Drawing.Size(250, 29);
            this.ChangeAmout2.TabIndex = 3;
            this.ChangeAmout2.Text = "0";
            this.ChangeAmout2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ChangeAmout2.UseSelectable = true;
            this.ChangeAmout2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ChangeAmout2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ChangeAmout1
            // 
            // 
            // 
            // 
            this.ChangeAmout1.CustomButton.Image = null;
            this.ChangeAmout1.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.ChangeAmout1.CustomButton.Name = "";
            this.ChangeAmout1.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.ChangeAmout1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ChangeAmout1.CustomButton.TabIndex = 1;
            this.ChangeAmout1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ChangeAmout1.CustomButton.UseSelectable = true;
            this.ChangeAmout1.CustomButton.Visible = false;
            this.ChangeAmout1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.ChangeAmout1.Lines = new string[] {
        "0"};
            this.ChangeAmout1.Location = new System.Drawing.Point(81, 81);
            this.ChangeAmout1.MaxLength = 32767;
            this.ChangeAmout1.Name = "ChangeAmout1";
            this.ChangeAmout1.PasswordChar = '\0';
            this.ChangeAmout1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ChangeAmout1.SelectedText = "";
            this.ChangeAmout1.SelectionLength = 0;
            this.ChangeAmout1.SelectionStart = 0;
            this.ChangeAmout1.ShortcutsEnabled = true;
            this.ChangeAmout1.Size = new System.Drawing.Size(250, 29);
            this.ChangeAmout1.TabIndex = 2;
            this.ChangeAmout1.Text = "0";
            this.ChangeAmout1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ChangeAmout1.UseSelectable = true;
            this.ChangeAmout1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ChangeAmout1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.ChangeAmout1.TextChanged += new System.EventHandler(this.ChangeAmount_Change);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(17, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "은행 선택";
            // 
            // SelectBank
            // 
            this.SelectBank.FormattingEnabled = true;
            this.SelectBank.ItemHeight = 23;
            this.SelectBank.Items.AddRange(new object[] {
            "KBH 하나은행",
            "신한은행"});
            this.SelectBank.Location = new System.Drawing.Point(17, 83);
            this.SelectBank.Name = "SelectBank";
            this.SelectBank.Size = new System.Drawing.Size(760, 29);
            this.SelectBank.TabIndex = 2;
            this.SelectBank.UseSelectable = true;
            this.SelectBank.SelectedIndexChanged += new System.EventHandler(this.SelectBank_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 645);
            this.Controls.Add(this.SelectBank);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.ExchangeRateTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "환율, 환율 계산기";
            this.ExchangeRateTab.ResumeLayout(false);
            this.TodayRatePage.ResumeLayout(false);
            this.TodayRatePage.PerformLayout();
            this.SearchLastRate.ResumeLayout(false);
            this.SearchLastRate.PerformLayout();
            this.CalculationRate.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl ExchangeRateTab;
        private MetroFramework.Controls.MetroTabPage TodayRatePage;
        private MetroFramework.Controls.MetroLabel RefreshTime;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.WebBrowser RateGrahp;
        private MetroFramework.Controls.MetroLabel CompareRate;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel RateDollars;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.WebBrowser BankPicture;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox SelectBank;
        private System.Windows.Forms.WebBrowser UpDown;
        private MetroFramework.Controls.MetroTabPage SearchLastRate;
        private MetroFramework.Controls.MetroTabPage CalculationRate;
        private System.Windows.Forms.WebBrowser LastRate;
        private MetroFramework.Controls.MetroTrackBar RateSearch;
        private MetroFramework.Controls.MetroLabel PageCount;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox ChangeList1;
        private MetroFramework.Controls.MetroComboBox ChangeList;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroTextBox ChangeAmout2;
        private MetroFramework.Controls.MetroTextBox ChangeAmout1;
        private System.Windows.Forms.WebBrowser ExchangeList;
    }
}

