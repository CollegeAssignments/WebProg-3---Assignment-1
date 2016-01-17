using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebProg_3___Car_Rental_Website;

public partial class Contact : System.Web.UI.Page
{
    //Entities mainDB = new Entities();
    
    CarRentalDataContext db = new CarRentalDataContext();
    // using delegate 
    public delegate void ArturDelegate(string userName, string userEmail, string userMsg);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
        }
    }

    protected void submit_Click(object sender, EventArgs e)
    {
        ArturDelegate a = new ArturDelegate(CommAgent.SendConfirmationEmail);
        a += new ArturDelegate(CommAgent.SendEmailToAdmin);

        a(InputName.Value, InputEmail.Value, InputMessage.Value);

    }
    
}