using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cau4
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("THÔNG TIN TÀI KHOẢN <br>");
            string name = Application["name"].ToString();
            string pass = Application["pass"].ToString();
            string passs = Application["passs"].ToString();
            string email = Application["email"].ToString();
            string date = Application["date"].ToString();
            string gioitinh = Application["GioiTinh.Text"].ToString();
            string sothich = Application["sothich1.Text"].ToString() + " | " + Application["sothich2.Text"].ToString();
            
            
            Response.Write("Tên đăng nhập: " + name + "<br>");
            Response.Write("Mật khẩu: " + pass + "<br>");
            Response.Write("Email: " + email + "<br>");
            Response.Write("Ngày sinh: " + date + "<br>");
            Response.Write("Giới tính: " + gioitinh + "<br>");
            Response.Write("Sở thích: " + sothich + "<br>");
        }
    }
}