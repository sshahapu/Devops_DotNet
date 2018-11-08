<%@ Page Title="" Language="C#" MasterPageFile="~/Admin1.Master" AutoEventWireup="true" CodeBehind="Adminhome.aspx.cs" Inherits="MyHospital.Adminhome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

<link href="~/Styles/UserStyle.css" rel="stylesheet" type="text/css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <center><h2>Welcome to MyHospital Management System</h2></center>
<div align="center" >

         <div align="center" >
        <object type="application/x-shockwave-flash" data="./slideshow/slideshow.swf" 
                 width="700" style="height: 450px">
				<param name="menu" value="false" />
				<param name="wmode" value="transparent" />
				<param name="flashvars" value="xml=./slideshow/slideshow.xml&amp;dir=./slideshow/" />
				<param name="movie" value="./slideshow/slideshow.swf" />
	</object></div></div>

</asp:Content>
