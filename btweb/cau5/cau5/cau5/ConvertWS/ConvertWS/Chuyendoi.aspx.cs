using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConvertWS
{
    public partial class Chuyendoi : System.Web.UI.Page
    {
        ServiceConvert.WebService1SoapClient myService = new ServiceConvert.WebService1SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVND2USD_Click(object sender, EventArgs e)
        {
            double tien = Convert.ToDouble(txtTien.Text);

            double ketqua = myService.VND2USD(tien);

            lblKetQua.Text = ketqua.ToString();
        }

        protected void btnVND2EUR_Click(object sender, EventArgs e)
        {
            double tien = Convert.ToDouble(txtTien.Text);

            double ketqua = myService.VND2EUR(tien);

            lblKetQua.Text = ketqua.ToString();
        }

        protected void btnUSD2VND_Click(object sender, EventArgs e)
        {
            double tien = Convert.ToDouble(txtTien.Text);

            double ketqua = myService.USD2VND(tien);

            lblKetQua.Text = ketqua.ToString();
        }

        protected void btnEUR2VND_Click(object sender, EventArgs e)
        {
            double tien = Convert.ToDouble(txtTien.Text);

            double ketqua = myService.EUR2VND(tien);

            lblKetQua.Text = ketqua.ToString();
        }
    }
}