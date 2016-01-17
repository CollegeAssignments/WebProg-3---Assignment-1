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
        //Entities mainDB = new Entities();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Test query -- making sure all is wired up correctly
            //var query = from car in mainDB.Vehicles
            //            select new
            //            {
            //                brand = car.Brand,
            //                model = car.Model
            //            };

            ////Display sample data to label on home page
            //foreach(var car in query)
            //{
            //    //tbxTest.Text = car.brand.ToString() + " " + car.model.ToString();
            //}

        }
    }
}