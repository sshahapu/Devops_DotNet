<%@ Page Title="" Language="C#" MasterPageFile="~/Admin1.Master" AutoEventWireup="true" CodeBehind="DeleteOutPat.aspx.cs" Inherits="MyCampus.DeleteOutPat" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div align="center">
<h2>Out Patients List those can be deleted from the system</h2>
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="patid" OnRowDataBound="data_bound"
            OnRowDeleting="deleteRow"
            style="margin-left: 0px; margin-top: 0px;" Width="551px" 
            
            Height="84px" Visible="true" ForeColor="Black" PageSize="20">
         <Columns>
       <asp:BoundField DataField="patid" HeaderText="Patient Id" HeaderStyle-BackColor="#465c71">
<HeaderStyle BackColor="#465c71"></HeaderStyle>
            </asp:BoundField>
         <asp:BoundField DataField="Pname" HeaderText="Patient Name" 
                HeaderStyle-BackColor="#465c71">
<HeaderStyle BackColor="#465c71"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="contactno" HeaderText="Contact No" 
                HeaderStyle-BackColor="#465c71">
<HeaderStyle BackColor="#465c71"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="regdate" HeaderText="Registration date" 
                HeaderStyle-BackColor="#465c71">
<HeaderStyle BackColor="#465c71"></HeaderStyle>
            </asp:BoundField>
                
          <asp:TemplateField HeaderText="Select" HeaderStyle-BackColor="#465c71" >
     <ItemTemplate>
       <asp:LinkButton ID="LinkButton1" 
         CommandArgument='<%# Eval("patid") %>' 
         CommandName="Delete" runat="server">
         Delete</asp:LinkButton>
     </ItemTemplate>
   </asp:TemplateField>
          </Columns>
       
            <HeaderStyle ForeColor="White" />
       
            <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
       
        </asp:GridView>
        <div style="background-color:#4b6c9e; width: 552px; margin-left: 0px;" 
        runat="server" id="messagediv">

    <asp:Label ID="Lblmessge" runat="server" 
        ForeColor="White" Text="Label" Font-Size="Larger" Font-Underline="True"></asp:Label>
</div>
        </div>
</asp:Content>
