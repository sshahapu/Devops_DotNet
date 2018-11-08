<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MyHospital.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~/Styles/UserStyle.css" rel="stylesheet" type="text/css" />
   
    <style type="text/css">
        .style2
        {
            width: 101px;
        }
        .style3
        {
            width: 101px;
            height: 19px;
        }
        .style4
        {
            height: 19px;
        }
        .style5
        {
            width: 101px;
            height: 16px;
        }
        .style6
        {
            height: 16px;
        }
        .style7
        {
            width: 101px;
            height: 17px;
        }
        .style8
        {
            height: 17px;
        }
        
    </style>
    <script type="text/javascript" >
        $(document).ready(function () {
            $("#txtuserId").attr('title', 'This is the hover-over text');

        });
    </script>
  
</head>
<body style="background-image:url('girl-plain-colour-background.jpg'); background-repeat:repeat;">
    <form id="form1" runat="server">
    <div class=Loginbody>
    <div class="loginheader"> 
    <div style="float:left"> <img src="Hospital_logo.jpg" height="90px" width="90px"/> </div>
    <div style="padding:8px 0px 5px 5px "><span style="font-family: 'Arial Narrow';">My</span>Hospital<span style=" font-family: 'Arial Narrow'; font-size: x-large;">  Where there is care !</span></div>
    </div>
    <div class="Loginstyle"  style="border:5px double #333399;background-image:url('cardiology_stethoscope.jpg');opacity:0.8; filter:alpha(opacity=80);" >
    <table id="loginTable" align="center">
    <caption id="loginCaption" 
            style="font-weight: 300; font-size: x-large; font-style: italic; text-transform: uppercase; border-bottom-style: inset; border-bottom-color: #0033CC; color: #3333CC; text-decoration: blink; font-family: Calibri;" >
        <br />
        Login</caption>
    <tr><td class="style3"></td><td class="style4"></td></tr>
    <tr>
    <td class="style2" >&nbsp;</td><td>
            &nbsp;</td>
    </tr>
    
    <tr>
    <td class="style2" >&nbsp;&nbsp; 
        <asp:Label ID="Label4" runat="server" Text="User Name" ForeColor="Red" 
            Font-Bold="True" Font-Size="Large"></asp:Label><asp:Label ID="Label2" 
            runat="server" ForeColor="Red" Text="*"></asp:Label>
        </td>
    <td>
        <asp:DropDownList ID="DropDownList1" runat="server" 
            DataValueField="--Select--" Width="159px">
            <asp:ListItem>--Select--</asp:ListItem>
            <asp:ListItem>Admin</asp:ListItem>
            <asp:ListItem>Operator</asp:ListItem>
        </asp:DropDownList>
    </td>
    </tr>
    <tr><td class="style7"></td><td class="style8">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="DropDownList1" ErrorMessage="Please select User Name" 
            ForeColor="Red" Display="Dynamic" SetFocusOnError="True" 
            InitialValue="--Select--"></asp:RequiredFieldValidator>
        </td></tr>
    <tr>
    <td class="style2" >&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label1" runat="server" 
            Text="Password" ForeColor="Red" Font-Bold="True" Font-Size="Large"></asp:Label><asp:Label ID="Label3" 
            runat="server" ForeColor="Red" Text="*"></asp:Label>
        </td><td>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        </td>
    </tr>
    <tr><td class="style5"></td><td class="style6">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ControlToValidate="txtPassword" ErrorMessage="Please enter the Password" 
            ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
        </td></tr>
    
    <tr><td class="style2"></td><td>
        <asp:Button ID="btnSubmit" runat="server" Text="Sign In" 
            onclick="btnSubmit_Click" />
        </td></tr>
    </table>
        &nbsp;&nbsp;&nbsp;
        <center>
        <div style="height:23px; margin-top: 0px;"><asp:Label ID="Errormassage" runat="server" Text="Label" ForeColor="Red" 
            Visible="False"></asp:Label></div></center>
    </div>
    <div id="loginfooter">
       <div>
           <p style="margin-left:8px; text-align: left; margin-bottom: 4px; font-size: medium;">
                                Copyright &copy; 2014---. All Rights Reserved.</p>
       </div>
    </div>
    </div>
    </form>
</body>
</html>
