<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionWebForm.aspx.cs" Inherits="Client.SessionWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style type="text/css">
        .auto-style1 {
            font-size: medium;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server" style="background-color: #C0C0C0">

        <div id="accountInfo1" style="height: 360px; width: 200px; float: left; background-color: #C0C0C0;">
            <span class="auto-style1">Hi, </span>
            <asp:Label ID="lblName" runat="server" Text="Label" CssClass="auto-style1"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Account Number" style="font-weight: 700"></asp:Label>
            <br />
            <asp:Label ID="lblAccountNumber" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <strong>Residence</strong><br />
            <asp:Label ID="lblResidence" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Balance" style="font-weight: 700"></asp:Label>
            <br />
            <asp:Label ID="lblBalance" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnLogOff" runat="server" Text="Log Off" OnClick="btnLogOff_Click" />
            <br />
          
        </div>

        &nbsp;&nbsp;&nbsp;<div id="transaction" style="height: 342px; background-color: #C0C0C0; margin-left: 40px; background-image: url('Resources/Untitled.png'); margin-top: 0px;">

            <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            <br />
            Transfer</strong><br />

            <asp:TextBox ID="tbAmount" runat="server">Amount</asp:TextBox>
            <asp:TextBox ID="tbAccountNumber" runat="server">AccountNumber</asp:TextBox>
            &nbsp;
            <asp:Button ID="btTransfer" runat="server" Text="Transfer" OnClick="btTransfer_Click" />

            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Messages" style="font-weight: 700"></asp:Label>
            <br />
            <br />
            <asp:ListBox ID="lbMessage" runat="server" Height="114px" OnSelectedIndexChanged="lbMessage_SelectedIndexChanged" Width="322px"></asp:ListBox>
        </div>
        &nbsp;<%@ PreviousPageType VirtualPath="~/RegistrationWebForm.aspx" %></form>
</body>
</html>
