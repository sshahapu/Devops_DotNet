<%@ Page Title="" Language="C#" MasterPageFile="~/Admin1.Master" AutoEventWireup="true" CodeBehind="OutPatBilling.aspx.cs" Inherits="MyCampus.OutPatBilling" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            height: 33px;
        }
        .style2
        {
            width: 169px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div align="center">

<table style="border:2px solid #465c71; background-color:#FFF0F5; height: 100px; width: 495px;">
<caption id="loginCaption" 
            style="font-weight: 300;font-size: x-large; text-transform: uppercase;  color: black; text-decoration: blink; font-family: Calibri;" >
        <br />
        Out-Patient Billing form</caption>

        <tr>
        <td></td><td align"center">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<asp:Label ID="Label4" runat="server" ForeColor="Black" Text="Bill" 
                Font-Names="Calibri"></asp:Label>
            </td><td></td>
        </tr>
        <tr>
        <td>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Text="Bill No"></asp:Label>
            </td><td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td><td></td>
        </tr>
        <tr>
        <td class="style1">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label2" runat="server" Text="Date"></asp:Label>
            </td><td class="style1">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td><td class="style1"></td>
        </tr>
        </table>
        <table style="border:2px solid #465c71; background-color:#FFF0F5; height: 109px; width: 495px; margin-left: 0px;">
        <tr>
        <td></td><td align"center">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" ForeColor="Black" Text="Patient Details" 
                Font-Names="Calibri"></asp:Label>
            </td><td></td>
        </tr>
        <tr>
        <td>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label5" runat="server" 
                Text="Patient Id"></asp:Label>
            <asp:Label ID="Label20" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td><td>
                <asp:TextBox ID="TextBox3" runat="server" MaxLength="6"></asp:TextBox>
            </td><td>
                <asp:Button ID="Button5" runat="server" onclick="Button5_Click" Text="Search" />
            </td>
        </tr>
        <tr>
        <td class="style1">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label6" runat="server" Text="Name"></asp:Label>
            </td><td class="style1">
                <asp:TextBox ID="TextBox4" runat="server" Enabled="False"></asp:TextBox>
            </td><td class="style1">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TextBox3" Display="Dynamic" 
                    ErrorMessage="Enter Patient Id to search" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="TextBox3" Display="Dynamic" 
            ErrorMessage="Patient Id should be digit number" ForeColor="Red" 
            ValidationExpression="\d+"></asp:RegularExpressionValidator>
            </td>
        </tr>
        
        
        </table>
        <table style="border:2px solid #465c71; background-color:#FFF0F5; height: 200px; width: 494px;">
        <tr>
        <td class="style2"></td><td align"center">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label11" runat="server" Text="Charges" Font-Names="Calibri" 
                Font-Overline="False"></asp:Label>
            </td><td></td>
        </tr>
        
        <tr>
        <td class="style2">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label13" runat="server" Text="Doctor name"></asp:Label>
            </td><td>
                <asp:TextBox ID="TextBox10" runat="server" Enabled="False"></asp:TextBox>
            </td><td></td>
        </tr>
        
        <tr>
        <td class="style2">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label15" runat="server" 
                Text="Consultation Amount"></asp:Label>
            </td><td>
                <asp:TextBox ID="TextBox12" runat="server" MaxLength="5"></asp:TextBox>
            </td><td>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
            ControlToValidate="TextBox12" Display="Dynamic" 
            ErrorMessage="Amount should be digit number" ForeColor="Red" 
            ValidationExpression="\d+"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
        <td class="style2">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label16" runat="server" Text="Total"></asp:Label>
            </td><td>
                <asp:TextBox ID="TextBox13" runat="server" Enabled="False"></asp:TextBox>
            </td><td>
                <asp:Button ID="Button1" runat="server" Text="Calculate" 
                    onclick="Button1_Click" CausesValidation="False" />
            </td>
        </tr>
        <tr>
        <td class="style2">
                <asp:Button ID="Button6" runat="server" CausesValidation="False" 
                    Enabled="False" onclick="Button6_Click" Text="Generate Bill" />
            </td><td>
                <asp:Button ID="Button4" runat="server" Text="Reset" CausesValidation="False" 
                    onclick="Button4_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button3" runat="server" Text="Save" onclick="Button3_Click" />
            </td><td>
                <asp:Button ID="Button2" runat="server" Text="  Exit  " 
                    CausesValidation="False" onclick="Button2_Click" />
            </td>
        </tr>
        </table>
        <div style="background-color:#4b6c9e; width: 497px; margin-left: 11px;" 
        runat="server" id="messagediv">

    <asp:Label ID="Lblmessge" runat="server" 
        ForeColor="White" Text="Label" Font-Size="Larger" Font-Underline="True"></asp:Label>
</div><br />
</div>
</asp:Content>
