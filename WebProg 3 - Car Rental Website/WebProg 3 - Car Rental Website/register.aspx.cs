using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text;

namespace WebProg_3___Car_Rental_Website
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSubmitReg_Click(object sender, EventArgs e)
        {
            //Collect data inputs
            string fName = tbxFName.Text;
            string lName = tbxLName.Text;
            string pNumber = tbxPhone.Text;
            DateTime dOB = Convert.ToDateTime(tbxDate.Text);
            string address = tbxAddress1.Text + "," + tbxAdress2.Text + "," + tbxAddressCountry.Text;
            string licenseNum = tbxLicenseNum.Text;
            string userName = tbxUserName.Text;
            string email = tbxEmail.Text;

            string password = tbxPassword.Text;
            string confirmPassword = tbxConfirmPassword.Text;
            string passHashed;

            //MD5 Class
            //https://msdn.microsoft.com/en-us/library/system.security.cryptography.md5(v=vs.110).aspx

            using (MD5 md5Hash = MD5.Create())
            {
                passHashed = GetMd5Hash(md5Hash, password);
            }
            while (true) { }
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}