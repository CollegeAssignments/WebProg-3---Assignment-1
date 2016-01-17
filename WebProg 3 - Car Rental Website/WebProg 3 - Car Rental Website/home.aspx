<%@ Page Title="" Language="C#" MasterPageFile="~/mainTemplate.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="WebProg_3___Car_Rental_Website.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="col-xs-12 col-md-4">
            <div class="panel panel-info">
                <div class="panel-heading"><h4>Our price includes</h4></div>
                <div class="panel-body">
                        <ul>
                            <li><i class='fa fa-check tick-icon'></i>Vat (Sales Tax)</li>
                            <li><i class='fa fa-check tick-icon'></i>Unlimited Millage</li>
                            <li><i class='fa fa-check tick-icon'></i>Third Party Cover</li>
                            <li><i class='fa fa-check tick-icon'></i>Collision Damage Waiver</li>
                            <li><i class='fa fa-check tick-icon'></i>Theft Protection</li>
                        </ul>
                </div>
            </div>
        </div>
        <div id="carListMain" class="col-xs-12 col-md-8" runat="server"></div>
    </div>
</asp:Content>
