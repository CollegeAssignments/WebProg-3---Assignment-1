<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Payment.aspx.cs" Inherits="Payment" MasterPageFile="~/mainTemplate.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
<div class="container">
         <!--3nd step -->
       <div class="row" >
        <div class="col-md-6 col-md-offset-3">
            <div id="paymentContainer" class="panel panel-default">
                <div class="panel-heading">
                    <h3 class="panel-title"><img class="pull-right" src="http://i76.imgup.net/accepted_c22e0.png"/>Payment Details</h3>
                </div>
                <div class="panel-body">
                    <div class="row">
                            <div class="col-xs-12">
                                <div class="form-group">
                                    <asp:Label  runat="server" ID="lbl_amount">AMOUNT</asp:Label>
                                    </div>
                                </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-12">
                                <div class="form-group">
                                    <label  for="cardNumber">CARD NUMBER</label>
                                    <div class="input-group">
                                        <input type="text" class="form-control" name="cardNumber" placeholder="Valid Card Number" required="required" autofocus="autofocus" data-stripe="number" />
                                        <span class="input-group-addon"><i class="fa fa-credit-card"></i></span>
                                    </div>
                                </div>                            
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-7 col-md-7">
                                <div class="form-group">
                                    <label for="expMonth">EXPIRATION DATE</label>



                                    <div class="col-xs-6 col-lg-6 pl-ziro">
                                        <input type="text" class="form-control" name="expMonth" placeholder="MM" required="required" data-stripe="exp_month" />
                                    </div>
                                    <div class="col-xs-6 col-lg-6 pl-ziro">
                                        <input type="text" class="form-control" name="expYear" placeholder="YY" required="required" data-stripe="exp_year" />
                                    </div>
                                </div>




                            </div>
                            <div class="col-xs-5 col-md-5 pull-right">
                                <div class="form-group">
                                    <label for="cvCode">CV CODE</label>
                                    <input type="password" class="form-control" name="cvCode" placeholder="CV" required="required" data-stripe="cvc" />
                                </div>
                            </div>
                        </div>
                       
                        <div class="row">
                            <div class="col-xs-12">
                                <asp:Button runat="server" ID="btn_pay" Text="PAY NOW" CssClass="btn btn-success btn-lg btn-block" onclick ="btn_pay_Click" />
                            </div>

                            
                           
                                  

                        </div>
                        <div class="row" style="display:none;">
                            <div class="col-xs-12">
                                <p class="payment-errors"></p>
                            </div>
                        </div>
                </div>
            </div>
        </div>
    </div>
       <!--end 3nd step -->
        </div> <!--end container -->

</asp:Content>