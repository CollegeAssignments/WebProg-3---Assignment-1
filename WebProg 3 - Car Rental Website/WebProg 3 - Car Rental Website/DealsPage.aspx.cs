using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebProg_3___Car_Rental_Website;

public partial class DealsPage : System.Web.UI.Page
{
    //Entities mainDB = new Entities();
    // linq to sql db con
    CarRentalDataContext db = new CarRentalDataContext();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //creating collection of anonimus object with properties we need 
            var deals = from d in db.DealLinks
                        select new
                        {
                            d.DealId,
                            d.DealImage,
                            d.Discount,
                            d.LimitedDealCounter,
                            d.DealName
                        };
            rep_Deals.DataSource = deals;
            rep_Deals.DataBind();//fire repeter and get data from db
        }
    }

    protected void LinlDeal_Command(object sender, CommandEventArgs e)
    {
        //after clicking on deal  we are creating deal object, pulling it from database, the one that was clicked 
        DealLink deal = db.DealLinks.SingleOrDefault(d => d.DealId.ToString() == e.CommandArgument.ToString());
        if (deal!=null)
        { // if deal is limited 
            if (deal.LimitedDealCounter !=null) // limited deal 
            {   //if any limited deal left 
                if (Convert.ToInt32(deal.LimitedDealCounter)>0)
                {
                    //go to booking with deal key
                    Response.Redirect("Booking.aspx?key=" + deal.DealKey.ToString());
                }// redirect to same page 
                else Response.Redirect(HttpContext.Current.Request.Url.AbsoluteUri);
            }
            else//deal is not limited 
            {
                //go to booking with deal key
                Response.Redirect("Booking.aspx?key=" + deal.DealKey.ToString());
            }
        }
    }
}