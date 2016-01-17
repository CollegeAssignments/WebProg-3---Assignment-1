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
            //Test query -- making sure all is wired up correctly
            var query = from vehicle in mainDB.Vehicles
                        join brand in mainDB.CarBrands on vehicle.BrandID equals brand.BrandID
                        join model in mainDB.BrandModels on vehicle.ModelID equals model.ModelID
                        select new
                        {
                            brand = brand.BrandName,
                            model = model.ModelName
                        };

            //Display sample data to label on home page
            if(Session != null)
            {
                string fName = (string)Session["fName"];
                tbxTest.Text = fName;
            }
            
        }

        protected void btnFindCars_Click(object sender, EventArgs e)
        {
            string queryString = string.Format("PickUp={0}&DropOff={1}", tbxPickUpDate.Text, tbxDropOffDate.Text);
            Response.Redirect("carList.aspx?" + queryString);
        }
    }
}