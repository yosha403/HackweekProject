using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailProcessor.Model;


namespace EmailProcessor.ServiceLayer
{
    public class CherwellServiceLayer
    {
        public CherwellServiceLayer() { }

        public EmailInfo GetEmailInfo()
        {
            EmailInfo e = new EmailInfo();
            e.Description = "I would like a mortgage payoff notice good through May 5 emailed to me and faxed to Arledge Law Firm at 1234567890. The Loan number is 9876543210. Address is 123 main street. Thank you.";
            e.SenderEmailId = "yoshakunnummal@rocketmortgage.com";
            e.Subject = "Regarding Payoff Mortgage";
            return e;
        }
    }
}
