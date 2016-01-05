<%@ Page Title="" Language="C#" MasterPageFile="~/mainTemplate.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="WebProg_3___Car_Rental_Website.register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--UserName field-->
    <asp:Label runat="server">User Name</asp:Label>
    <asp:TextBox ID="tbxUserName" runat="server"></asp:TextBox>
    <!--Email field-->
    <asp:Label runat="server">Email</asp:Label>
    <asp:TextBox ID="tbxEmail" runat="server"></asp:TextBox>
</asp:Content>
