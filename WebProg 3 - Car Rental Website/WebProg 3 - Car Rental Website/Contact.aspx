<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" MasterPageFile="~/mainTemplate.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="contactContainer" class="container">
<div class="row">
    <div class="col-lg-6">
      
      <div class="form-group">
        
          <asp:Label class="myLabel" ID="lblName" runat="server" Text="Label">Your Name</asp:Label>
        <div class="input-group">
          <input type="text" runat="server"  class="form-control" name="InputName" id="InputName" placeholder="Enter Name" required="required"/>
          <span class="input-group-addon"><i class="glyphicon glyphicon-ok form-control-feedback"></i></span></div>
        
      </div>
      <div class="form-group">
          <asp:Label class="myLabel" ID="lblEmail" runat="server" Text="Label">Your Email</asp:Label>
        <div class="input-group">

          <input  class="form-control" runat="server" id="InputEmail" name="InputEmail" placeholder="Enter Email" required="required" />
          <span class="input-group-addon"><i class="glyphicon glyphicon-ok form-control-feedback"></i></span></div>
          <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="InputEmail" ErrorMessage="*Enter Email!" CssClass="validators"></asp:RequiredFieldValidator>
          <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="InputEmail" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ErrorMessage="*Enter valid Email" CssClass="validators"/>
       

      </div>
      <div class="form-group">
          <asp:Label class="myLabel" ID="lblMessage" runat="server" Text="Label">Message</asp:Label>
        
        <div class="input-group"
>
          <textarea name="InputMessage" id="InputMessage" runat="server" class="form-control" rows="5" required="required"></textarea>
          <span class="input-group-addon"><i class="glyphicon glyphicon-ok form-control-feedback"></i></span></div>
      </div>
      
        <asp:Button ID="submit" runat="server" Text="submit" class="btn btn-info pull-right" OnClick="submit_Click" />
     
    </div>
  <hr class="featurette-divider hidden-lg"/>
  <div class="col-lg-5 col-md-push-1">
    <div>
    <h3>Location</h3>
    <p class="lead"><a href="http://www.europcar.ie">CAR HIRE<br/>
      28 South Anne Street</a><br/>
      Dublin 2<br/>
      Ireland<br/>
      Phone: 01 679 4409<br/>
      Fax: 01 679 4409</p>
    </div>
  </div>
</div>

</div>
</asp:Content>