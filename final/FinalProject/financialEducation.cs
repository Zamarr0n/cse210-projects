using System;


public class financialEducation{
    private string expenses_article = "https://hbr.org/2022/11/5-ways-to-manage-your-personal-finances";
    private string stock_market = "https://fortune.com/recommends/investing/how-to-start-investing/";
    private string emergency_fund = "https://www.consumerfinance.gov/an-essential-guide-to-building-an-emergency-fund/";
    public string financialTips(){
        string recomendation =$@"
            Welcome!!
            Here you will receive sources for personal finances :)
            How to manage your expenses:  {expenses_article}
            Learn about the stock market or investments:  {stock_market}
            What is an Emergency Found?  {emergency_fund}
        ";
        return recomendation;
    }




}





