<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DealsPage.aspx.cs" Inherits="DealsPage" MasterPageFile="~/mainTemplate.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--repeater is looping as many times as number of items in datasource (coming from page load) --%>
    <asp:Repeater ID="rep_Deals" runat="server" >
        <ItemTemplate>
            <%--OnCommand is like OnClick but can take arguments --%>
            <asp:LinkButton runat="server" ID="LinlDeal" OnCommand="LinlDeal_Command" CommandArgument='<%# Eval("DealID") %>'> <%--creating btn -- Eval is taking name of property in data sources and binding value --%>
                <div style="position:relative; display:inline-block;">
                    <%--<asp:Image runat="server" ID="img_Deal" ImageUrl='<%# Eval("DealImage") %>' />--%>
                    <asp:Image runat="server" ID="img_Deal" ImageUrl='<%# Eval("DealImage", "Images/{0}") %>' />
                    <div style="position:absolute; top:10px; left:10px; width:150px; height:150px; background-color: yellow;">

                        <%--<asp:Image  runat="server" ID="img_Discount" ImageUrl='<%# Eval("Discount", "Images/{0}") %>' />--%>

                        <%-- first checking is deal limited if is not we are displaying deal name and discount.
                            else (:) we are checking is there more than 0 limited offeres left 
                            if true (?) we are displaing deal name, and how many is left else (:) More deals comming --%>
                        <asp:Label runat="server" ID="lbl_dealname" Text='<%# Eval("LimitedDealCounter") == null ? String.Format("{0}<br /><span class=\"discount\">{1}%</span>", Eval("DealName"), Eval("Discount")) : Convert.ToInt32(Eval("LimitedDealCounter"))> 0 ? String.Format("{0}<br />Only {1} left! <br /><span class=\"discount\">{2}%</span>", Eval("DealName"), Eval("LimitedDealCounter"), Eval ("Discount")): "More deals comming" %>'></asp:Label>                  
                    </div>
                </div>
            </asp:LinkButton>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>