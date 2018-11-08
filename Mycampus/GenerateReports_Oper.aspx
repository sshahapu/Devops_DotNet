<%@ Page Title="" Language="C#" MasterPageFile="~/Operator.Master" AutoEventWireup="true" CodeBehind="GenerateReports_Oper.aspx.cs" Inherits="MyCampus.GenerateReports_Oper" %>
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
        <caption id="Caption1" 
            style="font-weight: 300;font-size: x-large; text-transform: uppercase;  color: black; text-decoration: blink; font-family: Calibri;" >
        <br />
        Generate Reports</caption>
        <tr>
        <td style="color:Blue">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Fields marked
            <asp:Label ID="Label14" runat="server" ForeColor="Red" Text="*"></asp:Label>
            &nbsp;are </td><td style="color:Blue">
                mandatory&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td><td class="style2">&nbsp;</td>
        </tr>
        <tr><td></td><td></td><td></td></tr>
        <tr>
        <td>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label5" runat="server" Text="Pat Id"></asp:Label>
    <asp:Label ID="Label15" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td><td>
                <asp:TextBox ID="TextBox3" runat="server" ValidationGroup="searcherrors" 
                    MaxLength="6"></asp:TextBox>
            </td><td class="style2">
                <asp:Button ID="Button5" runat="server" onclick="Button5_Click" Text="Search" 
                    ValidationGroup="searcherrors" />
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
                    ErrorMessage="Enter Pat Id to Search" ForeColor="Red" 
                    ValidationGroup="searcherrors"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="TextBox3" Display="Dynamic" 
            ErrorMessage="Patient Id should be digit number" ForeColor="Red" 
            ValidationExpression="\d+" ValidationGroup="searcherrors"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
        <td>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label7" runat="server" Text="Age"></asp:Label>
            </td><td>
                <asp:TextBox ID="TextBox5" runat="server" Enabled="False"></asp:TextBox>
            </td><td class="style2"></td>
        </tr>
        <tr>
        <td>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label8" runat="server" Text="Gender"></asp:Label>
            </td><td>
                <asp:DropDownList ID="DropDownList1" runat="server" Enabled="False" 
                    Width="154px">
                    <asp:ListItem>-Select--</asp:ListItem>
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:DropDownList>
            </td><td class="style2">&nbsp;</td>
        </tr>
        <tr>
        <td class="style1">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label9" runat="server" Text="Test Name"></asp:Label>
    <asp:Label ID="Label16" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td><td class="style1">
                <asp:DropDownList ID="DropDownList2" runat="server" ValidationGroup="saverrors" 
                    Width="154px">
                    <asp:ListItem>--Select--</asp:ListItem>
                    <asp:ListItem>Blood test</asp:ListItem>
                    <asp:ListItem>Urine test</asp:ListItem>
                    <asp:ListItem>X-Rays</asp:ListItem>
                </asp:DropDownList>
            </td><td class="style1">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="DropDownList2" EnableViewState="False" 
                    ErrorMessage="Please select Test Name" ForeColor="Red" 
                    InitialValue="--Select--" ValidationGroup="saverrors"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
        <td>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label10" runat="server" Text="Description"></asp:Label>
    <asp:Label ID="Label17" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td><td>
                <asp:TextBox ID="TextBox8" runat="server" TextMode="MultiLine" MaxLength="200" 
                    Height="50px" ValidationGroup="saverrors" Width="165px"></asp:TextBox>
            </td><td class="style2">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="TextBox8" ErrorMessage="Please enter the Description" 
                    ForeColor="Red" ValidationGroup="saverrors"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
        <td>
            &nbsp;</td><td>
                
            </td><td class="style2"></td>
        </tr>
        <tr>
        <td>
            &nbsp;</td><td>
                
                <asp:Button ID="Button6" runat="server" CausesValidation="False" 
                    Text=" Reset " onclick="Button6_Click" />
&nbsp;
                <asp:Button ID="Button7" runat="server" Text=" Save " onclick="Button7_Click" 
                    ValidationGroup="saverrors" Enabled="False" />
                
            </td><td class="style2">
                <asp:Button ID="Button8" runat="server" CausesValidation="False" 
                    onclick="Button8_Click" Text=" Exit " />
            </td>
        </tr>
        </table>
        <div style="background-color:#4b6c9e; width: 497px; margin-left: 0px;" 
        runat="server" id="messagediv">

    <asp:Label ID="Lblmessge" runat="server" 
        ForeColor="White" Text="Label" Font-Size="Larger" Font-Underline="True"></asp:Label>
</div><br />
</div>
</asp:Content>
