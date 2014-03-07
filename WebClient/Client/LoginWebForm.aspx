<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginWebForm.aspx.cs" Inherits="Client.LoginWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
            color: #0066FF;
            text-decoration: underline;
        }
        
    </style>
</head>
<body style="background-image:url('Resources/Login.jpg');">
 
    <form id="form1" runat="server" style="background-color: #FFFFFF opacity: 0.7;">
   
    
        <h3 class="auto-style1">
   
    
        <strong>Welcome to Awesome Bank!</h3>
        <br />
&nbsp;&nbsp;&nbsp; Account Number</strong><br />
   
    
        &nbsp;&nbsp;&nbsp;
   
    
        <asp:TextBox ID="tbAccountNumber" runat="server" OnTextChanged="tbAccountNumber_TextChanged"></asp:TextBox>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;<strong><br />
&nbsp;&nbsp;&nbsp; Password<br />
&nbsp;&nbsp;&nbsp; </strong>
        <asp:TextBox ID="tbPassword" runat="server" MaxLength="8" TextMode="Password"></asp:TextBox>
        &nbsp;<div style="margin-left: 40px">
            <br />
            <asp:Button ID="btLogin" runat="server" Text="Login" OnClick="btLogin_Click" Height="32px" Width="83px" />
            <br />
        </div>
        <br />

        <asp:Label ID="Label1" runat="server" Text="Don't have an account yet?" style="font-weight: 700"></asp:Label>
        &nbsp;
        <asp:Button ID="btRegister" runat="server" Text="Registration" OnClick="btRegister_Click" Height="35px" Width="131px" />
        <p>
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
