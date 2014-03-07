using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client
{

    
    public partial class RegistrationWebForm : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btRegister_Click(object sender, EventArgs e)
        {
            AccountService.Account account;
            AccountService.AccountServiceClient client = new AccountService.AccountServiceClient();

            account = new AccountService.Account();

            account.number = client.GenerateAccountNumber();
            account.name = tbName.Text;
            account.password = tbPassword.Text;
            account.residence = tbResidence.Text;
                      
            client.Register(account);

            Session["number"] = Convert.ToInt32(account.number);
            Session["password"] = Convert.ToString(tbPassword.Text);

            Session["client"] = client;              

            Response.Redirect("SessionWebForm.aspx");

        }

        protected void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        //public int acnumber
        //{
        //    get
        //    {
        //        return account.number;
        //    }
        //}

        //public string acname
        //{
        //    get
        //    {
        //        return account.name;
        //    }
        //}

        //public decimal acbalance
        //{
        //    get
        //    {
        //        return account.balance;
        //    }
        //}

        

        
    }
}