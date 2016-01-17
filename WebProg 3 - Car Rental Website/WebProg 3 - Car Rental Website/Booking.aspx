<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Booking.aspx.cs" Inherits="Booking" MasterPageFile="~/mainTemplate.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label runat="server" ID="lbl_discount" > </asp:Label>
    <asp:Button runat="server" ID="btn_pay" Text="PAY NOW" OnClick="btn_pay_Click" />
</asp:Content>