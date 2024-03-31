using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace B19
{
    public partial class Konvertor : System.Web.UI.Page
    {
        ServiceReference1.WebService1SoapClient service = new ServiceReference1.WebService1SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox2.Text = service.LatinicaUCirilicu(TextBox1.Text);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = service.CirilicaULatinicu(TextBox2.Text);
        }
    }
}