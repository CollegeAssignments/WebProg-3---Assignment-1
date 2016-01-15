using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebProg_3___Car_Rental_Website
{
    public partial class carList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string PickUpDate = Request.QueryString["PickUp"];
            string DropOffDate = Request.QueryString["DropOff"];

            lblPickUp.Text = PickUpDate;
            lblDropOff.Text = DropOffDate;

        }
    }
}