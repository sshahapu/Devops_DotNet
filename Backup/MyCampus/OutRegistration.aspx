<%@ Page Title="" Language="C#" MasterPageFile="~/Admin1.Master" AutoEventWireup="true" CodeBehind="OutRegistration.aspx.cs" Inherits="MyCampus.OutRegistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 220px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div align="center"; style="height: 508px" >
<table style="border:2px solid #465c71; background-color:#FFF0F5; height: 423px;">
<caption id="loginCaption" 
            style="font-weight: 300;font-size: x-large; text-transform: uppercase;  color: black; text-decoration: blink; font-family: Calibri;" >
        <br />
        Out-Patient Registration form</caption>

<tr><td>&nbsp;</td><td></td><td class="style1" style="color:Blue">Fields marked 
    <asp:Label ID="Label14" runat="server" ForeColor="Red" Text="*"></asp:Label>
    are mandatory</td></tr>
<tr><td></td><td></td><td class="style1"></td></tr>
<tr><td>
    &nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Text="Patient-ID"></asp:Label>
    <asp:Label ID="Label16" runat="server" ForeColor="Red" Text="*"></asp:Label>
    </td><td>
        <asp:TextBox ID="PId" runat="server" MaxLength="10"></asp:TextBox>
    </td><td class="style1">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
            ControlToValidate="PId" ErrorMessage="Please enter a Patient Id" 
            ForeColor="Red" SetFocusOnError="True" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="PId" Display="Dynamic" 
            ErrorMessage="Patient Id should a digit number" ForeColor="Red" 
            ValidationExpression="\d+"></asp:RegularExpressionValidator>
    </td></tr>
<tr><td>
    &nbsp;&nbsp;<asp:Label ID="Label2" runat="server" Text="Patient Name"></asp:Label>
    <asp:Label ID="Label11" runat="server" ForeColor="Red" Text="*"></asp:Label>
    </td><td>
        <asp:TextBox ID="PName" runat="server"></asp:TextBox>
    </td><td class="style1">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
            ControlToValidate="PName" ErrorMessage="Please enter the Name" 
            ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
    </td></tr>
<tr><td>
    &nbsp;&nbsp;<asp:Label ID="Label3" runat="server" Text="Age"></asp:Label>
    <asp:Label ID="Label12" runat="server" ForeColor="Red" Text="*"></asp:Label>
    </td><td>
        <asp:TextBox ID="Ptage" runat="server"></asp:TextBox>
    </td><td class="style1">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
            ControlToValidate="Ptage" ErrorMessage="Please enter the Age" 
            ForeColor="Red" SetFocusOnError="True" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
            ControlToValidate="Ptage" Display="Dynamic" 
            ErrorMessage="Please enter a valid Age" ForeColor="Red" 
            ValidationExpression="\d+"></asp:RegularExpressionValidator>
        <asp:RangeValidator ID="RangeValidator1" runat="server" 
            ControlToValidate="Ptage" Display="Dynamic" 
            ErrorMessage="Please enter age between 0 to 150" ForeColor="Red" 
            MaximumValue="150" MinimumValue="0" SetFocusOnError="True" Type="Integer"></asp:RangeValidator>
    </td></tr>
<tr><td>
   &nbsp;&nbsp;<asp:Label ID="Label9" runat="server" Text="Gender"></asp:Label>
    <asp:Label ID="Label10" runat="server" ForeColor="Red" Text="*"></asp:Label>
&nbsp;</td><td>
    <asp:DropDownList ID="PGender" runat="server" Width="159px">
        <asp:ListItem>--Select--</asp:ListItem>
        <asp:ListItem>Male</asp:ListItem>
        <asp:ListItem>Female</asp:ListItem>
    </asp:DropDownList>
    </td><td class="style1">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
            ControlToValidate="PGender" ErrorMessage="Please select the Gender" 
            ForeColor="Red" SetFocusOnError="True" InitialValue="--Select--"></asp:RequiredFieldValidator>
    </td></tr>
<tr><td>
    &nbsp;&nbsp;<asp:Label ID="Label5" runat="server" Text="Department"></asp:Label>
    <asp:Label ID="Label17" runat="server" ForeColor="Red" Text="*"></asp:Label>
    </td><td>
        <asp:DropDownList ID="DropDownList1" runat="server" 
             DataTextField="Department" 
            DataValueField="Department" Width="159px"  
            OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" 
            AutoPostBack="True">
            <asp:ListItem>--Select--</asp:ListItem>
        </asp:DropDownList>
    </td><td class="style1">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
            ControlToValidate="DropDownList1" ErrorMessage="Please select the Department" 
            ForeColor="Red" SetFocusOnError="True" InitialValue="--Select--"></asp:RequiredFieldValidator>
    </td></tr>
<tr><td>
    &nbsp;&nbsp;<asp:Label ID="Label6" runat="server" Text="Contact Number"></asp:Label>
    <asp:Label ID="Label13" runat="server" ForeColor="Red" Text="*"></asp:Label>
    </td><td>
        <asp:TextBox ID="PContact" runat="server" MaxLength="10"></asp:TextBox>
    </td><td class="style1">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
            ControlToValidate="PContact" ErrorMessage="Please enter a Contact Number" 
            ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
    </td></tr>
<tr><td>
    &nbsp;&nbsp;<asp:Label ID="Label8" runat="server" Text="Date"></asp:Label>
    </td><td>
        <asp:TextBox ID="regdate" runat="server"></asp:TextBox>
    </td><td class="style1"></td></tr>
<tr><td>
    &nbsp;&nbsp;<asp:Label ID="Label7" runat="server" Text="Doctor Name"></asp:Label>
    <asp:Label ID="Label15" runat="server" ForeColor="Red" Text="*"></asp:Label>
    </td><td>
        <asp:DropDownList ID="DropDownList2" runat="server" Width="159px" 
            DataTextField="Name" DataValueField="Name" >

        </asp:DropDownList>
    </td><td class="style1">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
            ControlToValidate="DropDownList2" ErrorMessage="Please select Doctor Name" 
            ForeColor="Red"></asp:RequiredFieldValidator>
    </td></tr>
<tr><td></td><td></td><td class="style1"></td></tr>

<tr><td></td><td>
    <asp:Button ID="Button1" runat="server" Text="Register" 
        onclick="Button1_Click" />
    &nbsp;<asp:Button ID="Button2" runat="server" Text=" Exit " 
        CausesValidation="False" onclick="Button2_Click" />
    </td><td class="style1"></td></tr>
<tr><td></td><td></td><td class="style1"></td></tr>
<tr><td></td><td></td><td class="style1"></td></tr>
</table>
<div style="background-color:#4b6c9e; width: 553px; margin-left: 0px;" 
        runat="server" id="messagediv">

    <asp:Label ID="Lblmessge" runat="server" 
        ForeColor="White" Text="Label" Font-Size="Larger" Font-Underline="True"></asp:Label>
</div>


</div>
</asp:Content>
