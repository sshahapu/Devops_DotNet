<%@ Page Title="" Language="C#" MasterPageFile="~/Admin1.Master" AutoEventWireup="true" CodeBehind="Register_doct.aspx.cs" Inherits="MyCampus.Register_doct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div align="center">


        <table style="border:2px solid #465c71; background-color:#FFF0F5; height: 200px;">
        <caption id="loginCaption" 
            style="font-weight: 300;font-size: x-large; text-transform: uppercase;  color: black; text-decoration: blink; font-family: Calibri;" >
        <br />
        Doctors Registration form</caption>
        <tr>
        <td></td><td align"center">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td><td class="style2"></td>
        </tr>
        <tr>
        <td>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label5" runat="server" 
                Text="Doctor Id"></asp:Label>
            <asp:Label ID="Label18" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td><td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td><td class="style2">
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="TextBox3" Display="Dynamic" 
            ErrorMessage="Doctor ID should be digit number" ForeColor="Red" 
            ValidationExpression="\d+"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
        <td class="style1">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label6" runat="server" Text="Name"></asp:Label>
            <asp:Label ID="Label19" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td><td class="style1">
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td><td class="style1">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TextBox4" ErrorMessage="Enter Doctor Name" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
        <td>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label7" runat="server" Text="Age"></asp:Label>
            </td><td>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td><td class="style2">&nbsp;</td>
        </tr>
        <tr>
        <td>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label8" runat="server" Text="Gender"></asp:Label>
            <asp:Label ID="Label20" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td><td>
                <asp:DropDownList ID="DropDownList1" runat="server" Width="159px">
                    <asp:ListItem>--Select--</asp:ListItem>
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:DropDownList>
            </td><td class="style2">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="DropDownList1" ErrorMessage="Select Gender" ForeColor="Red" 
                    InitialValue="--Select--"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
        <td>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label9" runat="server" 
                Text="Contact Number"></asp:Label>
            </td><td>
                <asp:TextBox ID="TextBox7" runat="server" MaxLength="10"></asp:TextBox>
            </td><td class="style2"></td>
        </tr>
        <tr>
        <td>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label10" runat="server" 
                Text="Department"></asp:Label>
            <asp:Label ID="Label21" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td><td>
                <asp:DropDownList ID="DropDownList2" runat="server" Width="159px">
                    <asp:ListItem>--Select--</asp:ListItem>
                    <asp:ListItem>Cardiology</asp:ListItem>
                    <asp:ListItem>Orthopedics</asp:ListItem>
                    <asp:ListItem>Dental</asp:ListItem>
                    <asp:ListItem>Neurology</asp:ListItem>
                    <asp:ListItem>General surgery</asp:ListItem>
                    <asp:ListItem>OBG</asp:ListItem>
                </asp:DropDownList>
            </td><td class="style2">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="DropDownList2" ErrorMessage="Select Department" 
                    ForeColor="Red" InitialValue="--Select--"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr><td></td><td></td><td></td></tr>
        <tr><td></td><td>
            <asp:Button ID="Button1" runat="server" CausesValidation="False" 
                onclick="Button1_Click" Text=" Reset " />
&nbsp;
            <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text=" Save " />
            </td><td>
                <asp:Button ID="Button3" runat="server" CausesValidation="False" 
                    onclick="Button3_Click" Text=" Exit " />
            </td></tr>
        <tr><td></td><td></td><td></td></tr>
        </table>
        
        <div style="background-color:#4b6c9e; width: 484px; margin-left: 0px;" 
        runat="server" id="messagediv">

    <asp:Label ID="Lblmessge" runat="server" 
        ForeColor="White" Text="Label" Font-Size="Larger" Font-Underline="True"></asp:Label>
</div><br />
</div>
</asp:Content>
