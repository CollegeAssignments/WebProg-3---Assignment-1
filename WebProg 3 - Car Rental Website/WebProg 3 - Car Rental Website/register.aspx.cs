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

            string salt = GenerateSalt();
            string passHashed = HashMD5(password+salt);

        }


        //Generate a random alphnumeric salt
        //Source: http://stackoverflow.com/questions/31957255/generating-a-random-number-in-c-sharp-with-alpha-numeric-values
        public static string GenerateSalt(int size = 8, string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890")
        {
            using (var crypto = new RNGCryptoServiceProvider())
            {
                var data = new byte[size];

                // If chars.Length isn't a power of 2 then there is a bias if
                // we simply use the modulus operator. The first characters of
                // chars will be more probable than the last ones.

                // buffer used if we encounter an unusable random byte. We will
                // regenerate it in this buffer
                byte[] smallBuffer = null;

                // Maximum random number that can be used without introducing a
                // bias
                int maxRandom = byte.MaxValue - ((byte.MaxValue + 1) % chars.Length);

                crypto.GetBytes(data);

                var result = new char[size];

                for (int i = 0; i < size; i++)
                {
                    byte v = data[i];

                    while (v > maxRandom)
                    {
                        if (smallBuffer == null)
                        {
                            smallBuffer = new byte[1];
                        }

                        crypto.GetBytes(smallBuffer);
                        v = smallBuffer[0];
                    }

                    result[i] = chars[v % chars.Length];
                }

                return new string(result);
            }
        }

        //Generates MD5 hashed password
        //
        //Accepts one string [password + salt]
        //Returns MD5 hash as a string
        string HashMD5(string input)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] bytes = md5.ComputeHash(Encoding.Unicode.GetBytes(input));
            string result = BitConverter.ToString(bytes).Replace("-", String.Empty);
            return result;
        }
    }
}