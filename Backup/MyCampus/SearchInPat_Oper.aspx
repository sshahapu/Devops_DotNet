<%@ Page Title="" Language="C#" MasterPageFile="~/Operator.Master" AutoEventWireup="true" CodeBehind="SearchInPat_Oper.aspx.cs" Inherits="MyCampus.SearchInPat_Oper" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style type="text/css">
        .style2
        {
            width: 141px;
        }
    .style3
    {
        width: 131px;
    }
    .style4
    {
        width: 159px;
    }
    .style5
    {
        width: 141px;
        height: 42px;
    }
    .style6
    {
        width: 131px;
        height: 42px;
    }
    .style7
    {
        width: 159px;
        height: 42px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<br />
<div align="center" >
<table style="width:669px">
<tr><td class="style5">
    <asp:Label ID="Label1" runat="server" Text="Enter Patient Id to Search/Edit"></asp:Label>
    &nbsp;:</td><td class="style6">
        <asp:TextBox ID="PID" runat="server"></asp:TextBox>
    </td><td class="style7">
        <asp:Button ID="Button1" runat="server" Text="Search" Width="61px" 
            onclick="Button1_Click" style="margin-left: 0px" />
        <asp:Button ID="Button2" runat="server" CausesValidation="False" 
            onclick="Button2_Click" Text="Display All" />
    </td></tr>
    <tr><td class="style2"></td><td class="style3">
        <asp:Label ID="Label3" runat="server" Text="Errorlbl" Visible="False" 
            ForeColor="Red"></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ErrorMessage="Please enter Patient Id to search" ForeColor="Red" 
            ControlToValidate="PID"></asp:RequiredFieldValidator>
        </td><td class="style4"></td></tr>
</table></div>
<div align="center">
    <asp:GridView ID="Grdview" runat="server" style="margin-left: 0px" 
            AutoGenerateColumns="False" Width="680px" AllowPaging="True" 
                onpageindexchanging="grdApprove_PageIndexChanging" Height="106px" 
                Visible="False" ForeColor="Black">
        <AlternatingRowStyle BackColor="#979BCE" />
        <Columns>
       <asp:BoundField DataField="patid" HeaderText="Patient Id" HeaderStyle-BackColor="#465c71">
<HeaderStyle BackColor="#465c71"></HeaderStyle>
            </asp:BoundField>
         <asp:BoundField DataField="Pname" HeaderText="Patient Name" 
                HeaderStyle-BackColor="#465c71">
<HeaderStyle BackColor="#465c71"></HeaderStyle>
            </asp:BoundField>
           <asp:BoundField DataField="age" HeaderText="Age" 
                HeaderStyle-BackColor="#465c71">
<HeaderStyle BackColor="#465c71"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="gender" HeaderText="Gender" 
                HeaderStyle-BackColor="#465c71">
<HeaderStyle BackColor="#465c71"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="adress" HeaderText="Adress" 
                HeaderStyle-BackColor="#465c71">
<HeaderStyle BackColor="#465c71"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="contactno" HeaderText="Contact No" 
                HeaderStyle-BackColor="#465c71">
<HeaderStyle BackColor="#465c71"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="roomno" HeaderText="Room No" 
                HeaderStyle-BackColor="#465c71">
<HeaderStyle BackColor="#465c71"></HeaderStyle>
            </asp:BoundField>   
          </Columns>
 
           <HeaderStyle ForeColor="White" />
            <PagerStyle HorizontalAlign="Center" />
            <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        </asp:GridView>


    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="patid" 
            style="margin-left: 0px; margin-top: 0px;" Width="776px" 
            
            Height="84px" Visible="False" ForeColor="Black">
         <Columns>
       <asp:BoundField DataField="patid" HeaderText="Patient Id" HeaderStyle-BackColor="#465c71">
<HeaderStyle BackColor="#465c71"></HeaderStyle>
            </asp:BoundField>
         <asp:BoundField DataField="Pname" HeaderText="Patient Name" 
                HeaderStyle-BackColor="#465c71">
<HeaderStyle BackColor="#465c71"></HeaderStyle>
            </asp:BoundField>
           <asp:BoundField DataField="age" HeaderText="Age" 
                HeaderStyle-BackColor="#465c71">
<HeaderStyle BackColor="#465c71"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="gender" HeaderText="Gender" 
                HeaderStyle-BackColor="#465c71">
<HeaderStyle BackColor="#465c71"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="adress" HeaderText="Adress" 
                HeaderStyle-BackColor="#465c71">
<HeaderStyle BackColor="#465c71"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="contactno" HeaderText="Contact No" 
                HeaderStyle-BackColor="#465c71">
<HeaderStyle BackColor="#465c71"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="roomno" HeaderText="Room No" 
                HeaderStyle-BackColor="#465c71">
<HeaderStyle BackColor="#465c71"></HeaderStyle>
            </asp:BoundField>
          <asp:HyperLinkField  datanavigateurlfields="patid" 
            DataNavigateUrlFormatString="~\InRegistration_Oper.aspx?patid={0}" Text="Edit" 
            HeaderStyle-BackColor=#465c71 HeaderText="Select">         
<HeaderStyle BackColor="#465c71"></HeaderStyle>
        </asp:HyperLinkField>
          </Columns>
       
            <HeaderStyle ForeColor="White" />
       
            <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
       
        </asp:GridView></div>

<br />
</asp:Content>
