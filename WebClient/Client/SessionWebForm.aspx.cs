using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Client
{
    public partial class SessionWebForm : System.Web.UI.Page
    {
        AccountService.Account account;
        AccountService.AccountServiceClient client;
        int acNumberSession;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["client"] != null)
            {
                client = (AccountService.AccountServiceClient)(Session["client"]);
                printAccountInfo();
            }
            else
            {
                Response.Redirect("LoginWebForm.aspx");
            }
        }

        protected void btTransfer_Click(object sender, EventArgs e)
        {
            int tNumber = Convert.ToInt32(tbAccountNumber.Text);
            decimal tAmount = Convert.ToDecimal(tbAmount.Text);

            client.Transfer(account, tNumber, tAmount);
            refreshBalanceAndMutation();
        }

        protected void btnLogOff_Click(object sender, EventArgs e)
        {
            Session["client"] = null;
            Response.Redirect("LoginWebForm.aspx");
        }

        protected void lbMessage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void printAccountInfo()
        {
            acNumberSession = (int)(Session["number"]);
            account = client.getAccount(acNumberSession);

            lblAccountNumber.Text = account.number.ToString();
            lblName.Text = account.name.ToString();
            lblBalance.Text = account.balance.ToString();
            lblResidence.Text = account.residence;
            lbMessage.Items.Clear();
            foreach (string m in account.mutations)
            {
                lbMessage.Items.Add(m);
            }
        }

        protected void refreshBalanceAndMutation()
        {
            lblBalance.Text = client.GetBalance(account.number).ToString();
            lbMessage.Items.Clear();
            string[] mutations = client.GetMutations(account.number);
            foreach (string m in mutations)
            {
                lbMessage.Items.Add(m);
            }
            printAccountInfo();
            Response.Redirect(Request.RawUrl);
        }
    }
}