<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationWebForm.aspx.cs" Inherits="Client.RegistrationWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #registrationForm {
            height: 1497px;
            border-width: medium;
           
            
        }
        .auto-style1 {
            font-size: xx-large;
        }
        .auto-style2 {
            font-size: xx-small;
        }
    </style>
    
</head>
<body>
     
    <form id="registrationForm" runat="server" style="background-color: #FFFFFF; background-image:url('Resources/Registration.png'); width: 1141px; margin-right: 1200px;" visible="True">
        
            &nbsp;
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
       
    <div id="registration" style="background-position: center; height: 398px; width: 340px; float: left; background-color: #999966; margin-left: 240px; opacity: 0.7;">
        <strong>
        <br />
        &nbsp;<span class="auto-style1">Create your Bank Account! </span><br />
        <br />
        &nbsp;
        Name</strong><br />
        
        <asp:TextBox ID="tbName" runat="server" Width="308px"></asp:TextBox>
        <br />
        <br />
        <strong>&nbsp; Residence</strong><br />
        <asp:TextBox ID="tbResidence" runat="server" Width="309px"></asp:TextBox>
        <br />
        <br />
        <strong>&nbsp; Password</strong><br />
        <asp:TextBox ID="tbPassword" runat="server" TextMode="Password" Width="168px" MaxLength="8">Password</asp:TextBox>
        &nbsp; <span class="auto-style2">Max 8 characters</span><br />
        <br />
        <span class="auto-style2">By clicking Register, you agreeto our Terms and that you have read our Data Use Policy, </span>
        <br class="auto-style2" />
        <span class="auto-style2">including our Cookie Use.</span><br />
        <asp:Button ID="btRegister" runat="server" Text="Register" OnClick="btRegister_Click" Height="41px" Width="107px" />
        
        &nbsp;&nbsp;&nbsp;
        
        <p>
            &nbsp;</p>
        </div>
       
    </form>
 
    
</body>
</html>
