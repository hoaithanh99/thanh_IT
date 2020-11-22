using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cau3
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCal_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtA.Text);
            int b = Convert.ToInt32(txtB.Text);
            for( int i = 0; i < ddlNut.Items.Count; i++)
            {
                if (ddlNut.Items[0].Selected)
                {
                    lblKQ.Text = (a + b).ToString();
                }
                else if (ddlNut.Items[1].Selected)
                {
                    lblKQ.Text = (a - b).ToString();
                }
                else if (ddlNut.Items[2].Selected)
                {
                    lblKQ.Text = (a * b).ToString();
                }
                else if (ddlNut.Items[3].Selected)
                {
                    lblKQ.Text = (a / b).ToString();
                }
                else if (ddlNut.Items[4].Selected)
                {
                    lblKQ.Text = (a % b).ToString();
                }
                else if (ddlNut.Items[5].Selected)
                {
                    lblKQ.Text = Math.Pow(a,b).ToString();
                }
            }
        } 
    }
}