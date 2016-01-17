using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebProg_3___Car_Rental_Website;

public partial class Booking : System.Web.UI.Page
{
    //Entities mainDB = new Entities();
    // i dont know how to recreate dll WebProg_3___Car_Rental_Website; so it would include deals class
    CarRentalDataContext db = new CarRentalDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            // get deal from db 
            DealLink deal = db.DealLinks.SingleOrDefault(d => d.DealKey.ToString() == Request["key"]);
            // is there a deal 
            if (deal !=null)
            {
                // go to Fergal booking form 
                lbl_discount.Text = string.Format("{0}%", deal.Discount);
            }    
        }
    }

    protected void btn_pay_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            DealLink deal = db.DealLinks.SingleOrDefault(d => d.DealKey.ToString() == Request["key"]);
            // if aspx login is used that line can help us to identify user 
            //string userName = HttpContext.Current.User.Identity.Name;
            BookingLink bkg = new BookingLink()
            {
                // getting info from Fergal booking form ? 
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(3),
                UserID = 1,
                CarID = 1,
                Price = CalcPrice(deal),
                DealID = deal == null ? (Nullable<int>)null : deal.DealId,// if function in object , asking is booking based on a deal 
                BookingKey = Guid.NewGuid()              
            };

            db.BookingLinks.InsertOnSubmit(bkg);
            db.SubmitChanges();// insert booking into db
            Response.Redirect("Payment.aspx?key=" + bkg.BookingKey.ToString()); // go to payments with booking key
        }
    }

    private decimal CalcPrice(DealLink deal)
    {
        // Fergal counting method ?  calc price
        decimal totalPrice = 100;

        if (deal != null)
        {
            if (deal.LimitedDealCounter != null)
            {
                totalPrice = totalPrice - (totalPrice * deal.Discount / (decimal)100);
            }
            else if (deal.MinDays >= 0)// Fergal form end date - start date 
            {
                totalPrice = totalPrice - (totalPrice * deal.Discount / (decimal)100);
            }

        }

        return totalPrice;
    }
}