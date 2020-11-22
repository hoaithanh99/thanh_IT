using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cau4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btndangky_Click(object sender, EventArgs e)
        {
            Application["name"] = txtdn.Text;
            Application["pass"] = txtmk.Text;
            Application["passs"] = txtnhaplaimk.Text;
            Application["email"] = txtemail.Text;
            Application["date"] = txtDate.Text;

            //gioi tinh
            if (rdbNam.Checked)
            {
                Application["GioiTinh.Text"] = rdbNam.Text;
            }
            else if(rdbNu.Checked)
            {
                Application["GioiTinh.Text"] = rdbNu.Text;
            }

            //so thich
            if (CheckBox1.Checked && CheckBox2.Checked )
            {
                Application["sothich1.Text"] = CheckBox1.Text;
                Application["sothich2.Text"] = CheckBox2.Text;
            }
            else if (CheckBox1.Checked && CheckBox3.Checked)
            {
                Application["sothich1.Text"] = CheckBox1.Text;
                Application["sothich2.Text"] = CheckBox3.Text;
            }
            else if (CheckBox2.Checked && CheckBox3.Checked)
            {
                Application["sothich1.Text"] = CheckBox2.Text;
                Application["sothich2.Text"] = CheckBox3.Text;
            }

            Response.Redirect("WebForm2.aspx");
        }

        protected void btnnhaplai_Click(object sender, EventArgs e)
        {
            txtdn.Text = "";
            txtmk.Text = "";
            txtemail.Text = "";
            txtDate.Text = "";
            txtnhaplaimk.Text = "";
        
            rdbNam.Checked = false;
            rdbNu.Checked = false;
            
            CheckBox1.Checked = false;
            CheckBox2.Checked = false;
            CheckBox3.Checked = false;

        }
    }
}