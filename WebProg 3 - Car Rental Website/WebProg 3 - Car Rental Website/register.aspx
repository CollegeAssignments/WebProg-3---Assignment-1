<%@ Page Title="" Language="C#" MasterPageFile="~/mainTemplate.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="WebProg_3___Car_Rental_Website.register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container main-reg-form">
        <!--Left Column-->
        <div class="col-xs-12 col-md-6">
            <div class="input-group col-xs-12 col-md-10 col-md-offset-1 space-inputs">
                <!--FName field-->
                <asp:Label runat="server">First Name</asp:Label>
                <asp:TextBox ID="tbxFName" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="input-group col-xs-12 col-md-10 col-md-offset-1 space-inputs">
                <!--LName field-->
                <asp:Label runat="server">LastName</asp:Label>
                <asp:TextBox ID="tbxLName" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="input-group col-xs-12 col-md-10 col-md-offset-1 space-inputs">
                <!--Phone field-->
                <asp:Label runat="server">Phone  Number</asp:Label>
                <asp:TextBox ID="tbxPhone" CssClass="form-control" runat="server"></asp:TextBox>
            </div>

            <div class="input-group col-xs-12 col-md-10 col-md-offset-1 space-inputs">
                <asp:Label runat="server">Date of Birth</asp:Label>
                <asp:TextBox id="tbxDate" CssClass="form-control"  runat="server"></asp:TextBox>
            </div>
            
            <hr />

            <div class="input-group col-xs-12 col-md-10 col-md-offset-1 space-inputs">
                <!--Address1 field-->
                <asp:Label runat="server">Address 1</asp:Label>
                <asp:TextBox ID="tbxAddress1" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="input-group col-xs-12 col-md-10 col-md-offset-1 space-inputs">
                <!--Address2 field-->
                <asp:Label runat="server">Address 2</asp:Label>
                <asp:TextBox ID="tbxAdress2" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="input-group col-xs-12 col-md-10 col-md-offset-1 space-inputs">
                <!--AddressCountry field-->
                <asp:Label runat="server">Country</asp:Label>
                <asp:TextBox ID="tbxAddressCountry" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <hr />
            <div class="input-group col-xs-12 col-md-10 col-md-offset-1 space-inputs">
                <!--LicenseNum field-->
                <asp:Label runat="server">License  Number</asp:Label>
                <asp:TextBox ID="tbxLicenseNum" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>
        <!--Right Column-->
        <div class="col-xs-12 col-md-6">
            <div class="input-group col-xs-12 col-md-10 col-md-offset-1 space-inputs">
                <!--UserName field-->
                <asp:Label runat="server">User Name</asp:Label>
                <asp:TextBox ID="tbxUserName" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="input-group col-xs-12 col-md-10 col-md-offset-1 space-inputs">
                <!--Email field-->
                <asp:Label runat="server">Email</asp:Label>
                <asp:TextBox ID="tbxEmail" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <hr />
            <div class="input-group col-xs-12 col-md-10 col-md-offset-1 space-inputs">
                <!--Password field-->
                <asp:Label runat="server">Password</asp:Label>
                <asp:TextBox ID="tbxPassword" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="input-group col-xs-12 col-md-10 col-md-offset-1 space-inputs">
                <!--ConfirmPassword field-->
                <asp:Label runat="server">Confirm Password</asp:Label>
                <asp:TextBox ID="tbxConfirmPassword" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>
    </div>

    <script>
        $(function() {
            $( "#<%= tbxDate.ClientID %>" ).datepicker();
        });
    </script>
</asp:Content>