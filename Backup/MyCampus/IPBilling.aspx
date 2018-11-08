<%@ Page Title="" Language="C#" MasterPageFile="~/Admin1.Master" AutoEventWireup="true" CodeBehind="IPBilling.aspx.cs" Inherits="MyCampus.IPBilling" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            height: 32px;
        }
        .style4
        {
            height: 32px;
            width: 202px;
        }
        .style5
        {
            width: 202px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div align="center">

<table style="border:2px solid #465c71; background-color:#FFF0F5; height: 100px;">
<caption id="loginCaption" 
            style="font-weight: 300;font-size: x-large; text-transform: uppercase;  color: black; text-decoration: blink; font-family: Calibri;" >
        <br />
        In-Patient Billing form</caption>
        <tr>
        <td style="color:Blue">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Fields marked
            <asp:Label ID="Label17" runat="server" ForeColor="Red" Text="*"></asp:Label>
            &nbsp;are </td><td style="color:Blue">
                mandatory&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td><td class="style5">&nbsp;</td>
        </tr>
        <tr>
        <td></td><td align"center">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<asp:Label ID="Label4" runat="server" ForeColor="Black" Text="Bill" 
                Font-Names="Calibri"></asp:Label>
            </td><td class="style5"></td>
        </tr>
        <tr>
        <td>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Text="Bill No"></asp:Label>
            </td><td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td><td class="style5"></td>
        </tr>
        <tr>
        <td>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label2" runat="server" Text="Date"></asp:Label>
            </td><td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td><td class="style5"></td>
        </tr>
        </table>
        <table style="border:2px solid #465c71; background-color:#FFF0F5; height: 200px; width: 532px;">
        <tr>
        <td></td><td align"center">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" ForeColor="Black" Text="Patient Details" 
                Font-Names="Calibri"></asp:Label>
            </td><td class="style5"></td>
        </tr>
        <tr>
        <td>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label5" runat="server" Text="Patient Id"></asp:Label>
            <asp:Label ID="Label18" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td><td>
                <asp:TextBox ID="TextBox3" runat="server" ValidationGroup="errorsearch" 
                    MaxLength="6"></asp:TextBox>
            </td><td class="style5">
                <asp:Button ID="Button5" runat="server" onclick="Button5_Click" Text="Search" 
                    ValidationGroup="errorsearch" />
            </td>
        </tr>
        <tr>
        <td class="style1">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label6" runat="server" Text="Name"></asp:Label>
            </td><td class="style1">
                <asp:TextBox ID="TextBox4" runat="server" Enabled="False"></asp:TextBox>
            </td><td class="style4">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TextBox3" Display="Dynamic" 
                    ErrorMessage="Enter Patient Id to Search" ForeColor="Red" 
                    ValidationGroup="errorsearch"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="TextBox3" Display="Dynamic" 
            ErrorMessage="Patient Id should be digit number" ForeColor="Red" 
            ValidationExpression="\d+" ValidationGroup="errorsearch"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
        <td>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label7" runat="server" Text="Age"></asp:Label>
            </td><td>
                <asp:TextBox ID="TextBox5" runat="server" Enabled="False"></asp:TextBox>
            </td><td class="style5"></td>
        </tr>
        <tr>
        <td>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label8" runat="server" Text="Gender"></asp:Label>
            </td><td>
                <asp:DropDownList ID="DropDownList1" runat="server" Enabled="False" 
                    Width="159px">
                    <asp:ListItem>--Select--</asp:ListItem>
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:DropDownList>
            </td><td class="style5"></td>
        </tr>
        <tr>
        <td>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label9" runat="server" Text="Date of Admission"></asp:Label>
            </td><td>
                <asp:TextBox ID="TextBox7" runat="server" Enabled="False"></asp:TextBox>
            </td><td class="style5"></td>
        </tr>
        <tr>
        <td>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label10" runat="server" Text="Date of Discharge"></asp:Label>
            <asp:Label ID="Label21" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td><td>
                <asp:TextBox ID="TextBox8" runat="server" ValidationGroup="errordate"></asp:TextBox>
            </td><td class="style5">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="TextBox8" ErrorMessage="Enter Date of discharge" 
                    ForeColor="Red" ValidationGroup="errordate" Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" 
                    ControlToValidate="TextBox8" Display="Dynamic" 
                    ErrorMessage="Date format is mm/dd/yyy." ForeColor="Red" 
                    ValidationExpression="^(0?[1-9]|1[012])[\/](0?[1-9]|[12][0-9]|3[01])[\/]\d{4}$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        </table>
        <table style="border:2px solid #465c71; background-color:#FFF0F5; height: 200px;">
        <tr>
        <td></td><td align"center">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label11" runat="server" Text="Charges" Font-Names="Calibri" 
                Font-Overline="False"></asp:Label>
            </td><td class="style5"></td>
        </tr>
        <tr>
        <td>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label12" runat="server" Text="Room Charges"></asp:Label>
            <asp:Label ID="Label20" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td><td>
                <asp:TextBox ID="TextBox9" runat="server" ValidationGroup="errordate"></asp:TextBox>
            </td><td class="style5">
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
            ControlToValidate="TextBox9" Display="Dynamic" 
            ErrorMessage="Please enter digit value" ForeColor="Red" 
            ValidationExpression="\d+"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
        <td>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label13" runat="server" Text="Doctor Fees"></asp:Label>
            <asp:Label ID="Label19" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td><td>
                <asp:TextBox ID="TextBox10" runat="server" ValidationGroup="errordate"></asp:TextBox>
            </td><td class="style5">
        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
            ControlToValidate="TextBox10" Display="Dynamic" 
            ErrorMessage="Please enter digit value" ForeColor="Red" 
            ValidationExpression="\d+"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
        <td>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label14" runat="server" Text="Pathology"></asp:Label>
            </td><td>
                <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
            </td><td class="style5">
        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
            ControlToValidate="TextBox11" Display="Dynamic" 
            ErrorMessage="Please enter digit value" ForeColor="Red" 
            ValidationExpression="\d+"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
        <td>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label15" runat="server" Text="Miscellanous"></asp:Label>
            </td><td>
                <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
            </td><td class="style5">
        <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" 
            ControlToValidate="TextBox12" Display="Dynamic" 
            ErrorMessage="Please enter digit value" ForeColor="Red" 
            ValidationExpression="\d+"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
        <td>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label16" runat="server" Text="Total"></asp:Label>
            </td><td>
                <asp:TextBox ID="TextBox13" runat="server" Enabled="False"></asp:TextBox>
            </td><td class="style5">
                <asp:Button ID="Button1" runat="server" Text="Calculate" 
                    onclick="Button1_Click" CausesValidation="False" />
            </td>
        </tr>
        <tr>
        <td>
                &nbsp;</td><td>
                <asp:Button ID="Button3" runat="server" Text=" Save " 
                    onclick="Button3_Click" Enabled="False" ValidationGroup="errordate" />
            &nbsp;
                <asp:Button ID="Button2" runat="server" Text=" Exit " 
                    CausesValidation="False" onclick="Button2_Click" />
            </td><td class="style5">
                <asp:Button ID="Button6" runat="server" CausesValidation="False" 
                    onclick="Button6_Click" Text="Generate Bill" Enabled="False" />
            </td>
        </tr>
        </table>
        <div style="background-color:#4b6c9e; width: 532px; margin-left: 0px;" 
        runat="server" id="messagediv">

    <asp:Label ID="Lblmessge" runat="server" 
        ForeColor="White" Text="Label" Font-Size="Larger" Font-Underline="True"></asp:Label>
</div><br />
</div>

</asp:Content>
