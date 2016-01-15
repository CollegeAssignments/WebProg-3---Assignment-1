<%@ Page Title="" Language="C#" MasterPageFile="~/mainTemplate.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="WebProg_3___Car_Rental_Website.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <span style="font-size:1.5em;" class="glyphicon glyphicon-home" aria-hidden="true"></span>

        <asp:Label ID="tbxTest" runat="server"></asp:Label>

        <div class="find-cars-form col-xs-12 col-md-6">
            <asp:Label runat="server">Pick Up Date</asp:Label>
            <asp:TextBox ID="tbxPickUpDate" CssClass="form-control space-inputs"  runat="server" />
            <asp:Label runat="server">Drop Off Date</asp:Label>
            <asp:TextBox ID="tbxDropOffDate" CssClass="form-control space-inputs"  runat="server" />
            <asp:Button ID="btnFindCars" Text="Find Cars" CssClass="btn btn-success pull-right space-inputs" OnClick="btnFindCars_Click" runat="server" />
        </div>
    </div>

    <script>
        $(function() {
            $("#<%= tbxPickUpDate.ClientID %>").datepicker();
            $( "#<%= tbxDropOffDate.ClientID %>" ).datepicker();
        });
    </script>
</asp:Content>
