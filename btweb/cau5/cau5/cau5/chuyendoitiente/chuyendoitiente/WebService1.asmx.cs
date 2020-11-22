using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace chuyendoitiente
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        private const double USD_RATE = 16740;
        private const double EUR_RATE = 18960;

        [WebMethod]
        public double EUR2VND(double eur)
        {
            return eur * EUR_RATE;
        }

        [WebMethod]
        public double USD2VND(double usd)
        {
            return usd * USD_RATE;
        }

        [WebMethod]
        public double VND2EUR(double dong)
        {
            return dong / EUR_RATE;
        }

        [WebMethod]
        public double VND2USD(double dong)
        {
            return dong / USD_RATE;
        }
    }
}
