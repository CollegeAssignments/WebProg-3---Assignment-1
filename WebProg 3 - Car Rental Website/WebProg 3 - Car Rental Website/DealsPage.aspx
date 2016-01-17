<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DealsPage.aspx.cs" Inherits="DealsPage" MasterPageFile="~/mainTemplate.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .div_deal {
            text-align:center;
            color: #000;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--repeater is looping as many times as number of items in datasource (coming from page load) --%>
    <asp:Repeater ID="rep_Deals" runat="server" >
        <ItemTemplate>
            <%--OnCommand is like OnClick but can take arguments --%>
            <asp:LinkButton runat="server" ID="LinlDeal" OnCommand="LinlDeal_Command" CommandArgument='<%# Eval("DealID") %>'> <%--creating btn -- Eval is taking name of property in data sources and binding value --%>
                <div style="position:relative; display:inline-block;">
                    <%--<asp:Image runat="server" ID="img_Deal" ImageUrl='<%# Eval("DealImage") %>' />--%>
                    <asp:Image runat="server" ID="img_Deal" ImageUrl='<%# Eval("DealImage", "Images/{0}") %>' CssClass="img_deal"/>
                    <div style="position:absolute; top:0px; left:0px; background-color:#faf803;">
                        <table> 
                            <tr>
                                 <%-- first checking is deal limited if is not we are displaying deal name and discount.
                                else (:) we are checking is there more than 0 limited offeres left 
                                if true (?) we are displaing deal name, and how many is left else (:) More deals comming --%>
                                <td><asp:Label runat="server" ID="lbl_dealname" Text='<%# Eval("LimitedDealCounter") == null ? String.Format("<div class=\"div_deal\">{0}</div>", Eval("DealName")) : Convert.ToInt32(Eval("LimitedDealCounter"))> 0 ? String.Format("<div class=\"div_deal\">{0}<br />Only {1} left! <br /></div>", Eval("DealName"), Eval("LimitedDealCounter")): "<div class=\"div_deal\">More deals comming</div>" %>'></asp:Label></td>
                            </tr>
                            <tr>
                                <td><img src='<%# Eval("Discount", "Images/{0}.png") %>' /></td>
                            </tr>
                        </table>
                        
                        <%--<asp:Image  runat="server" ID="img_Discount" ImageUrl='<%# Eval("Discount", "Images/{0}") %>' />--%>

                       
                        
                    </div>
                </div>
            </asp:LinkButton>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>