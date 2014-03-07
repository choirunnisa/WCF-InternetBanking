using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client
{
    public partial class LoginWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btLogin_Click(object sender, EventArgs e)
        {
            AccountService.AccountServiceClient client = new AccountService.AccountServiceClient();
            AccountService.Account account = client.Login(Convert.ToInt32(tbAccountNumber.Text), tbPassword.Text.ToString());
            
            if (account.isLoggedin == true)
            {
                Session["client"] = client;

                Session["number"] = Convert.ToInt32(tbAccountNumber.Text);
                Session["password"] = Convert.ToString(tbPassword.Text);

                Response.Redirect("SessionWebForm.aspx");
            }
            else
            {
                lblMessage.Text = "Login is unsuccesful. Please make sure the combination of your account number and password is correct.";
            }
        }

        protected void btRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrationWebForm.aspx");
        }

        protected void tbAccountNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}