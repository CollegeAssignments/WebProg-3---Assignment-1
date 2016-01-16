using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebProg_3___Car_Rental_Website
{
    public partial class home : System.Web.UI.Page
    {
        //Main connection string to database
        Entities mainDB = new Entities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session != null)
            {
                string fName = (string)Session["fName"];
                tbxTest.Text = fName;
            }
            
        }
    }
}