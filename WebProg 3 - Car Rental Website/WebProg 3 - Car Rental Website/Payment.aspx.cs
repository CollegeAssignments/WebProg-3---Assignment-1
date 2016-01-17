using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebProg_3___Car_Rental_Website;

public partial class Payment : System.Web.UI.Page
{
    //Entities mainDB = new Entities();
   
    CarRentalDataContext db = new CarRentalDataContext();
    // using delegate 
    public delegate void ArturDelegate2(int discount, int offeres);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            BookingLink booking = db.BookingLinks.SingleOrDefault(b => b.BookingKey.ToString() == Request["key"]);
            if (booking == null)
            {
                Response.Redirect("Home.aspx");
            }

            if (!booking.IsPaid)
            {
                lbl_amount.Text = string.Format("€{0:n2}", booking.Price);
            }
            else Response.Redirect("Home.aspx");
        }
    }

    protected void btn_pay_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
           

            BookingLink booking = db.BookingLinks.SingleOrDefault(b => b.BookingKey.ToString() == Request["key"]);
            if (booking != null)
            {
                // make a payement

                booking.IsPaid = true;
                
                if(booking.DealID != null) 
                {
                    DealLink deal = db.DealLinks.SingleOrDefault(d => d.DealId == booking.DealID);
                    if(deal != null)
                    {
                        if(deal.LimitedDealCounter != null) // is the teal limited?
                        {
                            deal.LimitedDealCounter--;
                            ArturDelegate2 a = new ArturDelegate2(CommAgent.SendInfoNewDealsUsers);
                            a += new ArturDelegate2(CommAgent.SendInfoNewDealsAdmin);

                            if(deal.LimitedDealCounter <= 0 && deal.Discount == 10)
                            {
                                // 10 % discount deal is over -- send emails to users about 5 % deal
                                deal.Discount = 5;
                                deal.LimitedDealCounter = 50;
                                a(deal.Discount, (int)deal.LimitedDealCounter);
                            }
                            else if (deal.LimitedDealCounter <= 0)
                            {
                                a(deal.Discount, (int)deal.LimitedDealCounter);
                            }
                        }
                    }
                }
                db.SubmitChanges();
                // send email to the user
                //UserLink user = db.UserLinks.SingleOrDefault(u => u.UserID == booking.UserID);
                CommAgent.SendBookingConfirmationEmail(booking.UserLink.FName + " " + booking.UserLink.LName, booking.UserLink.Email);

                Response.Redirect("home.aspx");
            }
        }
    }
}