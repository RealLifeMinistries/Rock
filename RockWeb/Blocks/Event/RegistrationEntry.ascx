﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="RegistrationEntry.ascx.cs" Inherits="RockWeb.Blocks.Event.RegistrationEntry" %>

<asp:UpdatePanel ID="upnlContent" runat="server">
<ContentTemplate>

    <asp:HiddenField ID="hfTriggerScroll" runat="server" Value="" />
    <asp:HiddenField ID="hfAllowNavigate" runat="server" Value="" />

    <asp:ValidationSummary ID="vsSummary" runat="server" HeaderText="Please Correct the Following" CssClass="alert alert-danger" />
    <Rock:NotificationBox ID="nbPaymentValidation" runat="server" NotificationBoxType="Danger" Visible="false" />

    <Rock:NotificationBox ID="nbMain" runat="server" Visible="false"></Rock:NotificationBox>

    <asp:Panel ID="pnlHowMany" runat="server" Visible="false" CssClass="registrationentry-intro">

        <h1>How many <asp:Literal ID="lRegistrantTerm" runat="server" /> will you be registering?</h1>
        <Rock:NumberUpDown ID="numHowMany"  runat="server" CssClass="input-lg" />

        <div class="actions">
            <Rock:BootstrapButton ID="lbHowManyNext" runat="server" AccessKey="n" Text="Next" DataLoadingText="Next" CssClass="btn btn-primary pull-right" CausesValidation="true" OnClick="lbHowManyNext_Click" />
        </div>

    </asp:Panel>

    <asp:Panel ID="pnlRegistrant" runat="server" Visible="false" CssClass="registrationentry-registrant">

        <h1><asp:Literal ID="lRegistrantTitle" runat="server" /></h1>
        
        <asp:Panel ID="pnlRegistrantProgressBar" runat="server">
            <div class="progress">
                <div class="progress-bar" role="progressbar" aria-valuenow="<%=this.PercentComplete%>" aria-valuemin="0" aria-valuemax="100" style="width: <%=this.PercentComplete%>%;">
                    <span class="sr-only"><%=this.PercentComplete%>% Complete</span>
                </div>
            </div>
        </asp:Panel>

        <div class="js-registration-same-family registrationentry-samefamily">
            <asp:Panel ID="pnlFamilyOptions" runat="server" CssClass="well">
                <Rock:RockRadioButtonList ID="rblFamilyOptions" runat="server" Label="Individual is in the same family as" RepeatDirection="Vertical" Required="true" RequiredErrorMessage="Answer to which family is required." DataTextField="Value" DataValueField="Key" />
            </asp:Panel>
        </div>
        
        <asp:PlaceHolder ID="phRegistrantControls" runat="server" />
        
        <div id="divFees" runat="server" class="well registration-additional-options">
            <h4><asp:Literal ID="lRegistrantFeeCaption" runat="server" /></h4>
            <asp:PlaceHolder ID="phFees" runat="server" />
        </div>

        <div class="actions">
            <asp:LinkButton ID="lbRegistrantPrev" runat="server" AccessKey="p" Text="Previous" CssClass="btn btn-default" CausesValidation="false" OnClick="lbRegistrantPrev_Click"  />
            <Rock:BootstrapButton ID="lbRegistrantNext" runat="server" AccessKey="n" Text="Next" DataLoadingText="Next" CssClass="btn btn-primary pull-right" CausesValidation="true" OnClick="lbRegistrantNext_Click" />
        </div>

    </asp:Panel>

    <asp:Panel ID="pnlSummaryAndPayment" runat="server" Visible="false" CssClass="registrationentry-summary">
        
        <h1><asp:Literal ID="lSummaryAndPaymentTitle" runat="server" /></h1>

        <asp:Panel ID="pnlSummaryAndPaymentProgressBar" runat="server">
            <div class="progress">
                <div class="progress-bar" role="progressbar" aria-valuenow="<%=this.PercentComplete%>" aria-valuemin="0" aria-valuemax="100" style="width: <%=this.PercentComplete%>%;">
                    <span class="sr-only"><%=this.PercentComplete%>% Complete</span>
                </div>
            </div>
        </asp:Panel>
        
        <asp:Panel ID="pnlRegistrarInfo" runat="server" CssClass="well">
            
            <h4>This <asp:Literal id="lRegistrationTerm" runat="server" /> Was Completed By</h4>
            <div class="row">
                <div class="col-md-6">
                    <Rock:RockTextBox ID="tbYourFirstName" runat="server" Label="First Name" CssClass="js-your-first-name" Required="true" />
                </div>
                <div class="col-md-6">
                    <Rock:RockTextBox ID="tbYourLastName" runat="server" Label="Last Name" Required="true" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <Rock:EmailBox ID="tbConfirmationEmail" runat="server" Label="Send Confirmation Emails To" Required="true" />
                    <Rock:RockCheckBox ID="cbUpdateEmail" runat="server" Text="Should Your Account Be Updated To Use This Email Address?" Visible="false" Checked="true" />
                </div>
                <div class="col-md-6">
                    <asp:Panel ID="pnlRegistrarFamilyOptions" runat="server" CssClass="js-registration-same-family">
                        <Rock:RockRadioButtonList ID="rblRegistrarFamilyOptions" runat="server" Label="You are in the same family as" RepeatDirection="Horizontal" Required="true" DataTextField="Value" DataValueField="Key" RequiredErrorMessage="Answer to which family is required." />
                    </asp:Panel>
                </div>
            </div>

        </asp:Panel>
        
        <asp:Panel ID="pnlRegistrantsReview" CssClass="margin-b-md" runat="server" Visible="false">
            <asp:Literal ID="lRegistrantsReview" runat="server" />
            <ul>
                <asp:Repeater ID="rptrRegistrantReview" runat="server">
                    <ItemTemplate>
                        <li><strong> <%# Eval("RegistrantName")  %></strong></li>
                    </ItemTemplate>
                </asp:Repeater>
            </ul>
        </asp:Panel>     
        
        <asp:Panel ID="pnlCostAndFees" runat="server">

            <h4>Payment Summary</h4>
                
            <Rock:NotificationBox ID="nbDiscountCode" runat="server" Visible="false" NotificationBoxType="Warning"></Rock:NotificationBox>
                
            <div class="clearfix">
                <div id="divDiscountCode" runat="server" class="form-group pull-right">
                    <label class="control-label"><asp:Literal ID="lDiscountCodeLabel" runat="server" /></label>
                    <div class="input-group">
                        <asp:TextBox ID="tbDiscountCode" runat="server" CssClass="form-control input-width-md input-sm"></asp:TextBox>
                        <asp:LinkButton ID="lbDiscountApply" runat="server" CssClass="btn btn-default btn-sm margin-l-sm" Text="Apply" OnClick="lbDiscountApply_Click" CausesValidation="false"></asp:LinkButton>
                    </div>
                </div>
            </div>

            <div class="fee-table">
                <asp:Repeater ID="rptFeeSummary" runat="server">
                    <HeaderTemplate>
                        <div class="row hidden-xs fee-header">
                            <div class="col-sm-6">
                                <strong>Description</strong>
                            </div>
                                
                            <div runat="server" class="col-sm-3 fee-value" visible='<%# (RegistrationState.DiscountPercentage > 0.0m) %>'>
                                <strong>Discounted Amount</strong>
                            </div>

                            <div class="col-sm-3 fee-value">
                                <strong>Amount</strong>
                            </div>
                                
                        </div>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <div class="row fee-row-<%# Eval("Type").ToString().ToLower() %>">
                            <div class="col-sm-6 fee-caption">
                                <%# Eval("Description") %>
                            </div>
                                
                            <div runat="server" class="col-sm-3 fee-value" visible='<%# (RegistrationState.DiscountPercentage > 0.0m) %>'>
                                <span class="visible-xs-inline">Discounted Amount:</span> <%# Rock.Web.Cache.GlobalAttributesCache.Value( "CurrencySymbol" )%> <%# string.Format("{0:N}", Eval("DiscountedCost")) %> 
                            </div>

                            <div class="col-sm-3 fee-value">
                                <span class="visible-xs-inline">Amount:</span> <%# Rock.Web.Cache.GlobalAttributesCache.Value( "CurrencySymbol" )%> <%# string.Format("{0:N}", Eval("Cost")) %> 
                            </div>
                                    
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>

            <div class="row fee-totals">
                <div class="col-sm-offset-8 col-sm-4 fee-totals-options">
                    <asp:HiddenField ID="hfTotalCost" runat="server" />
                    <Rock:RockLiteral ID="lTotalCost" runat="server" Label="Total Cost" />

                    <asp:HiddenField ID="hfPreviouslyPaid" runat="server" />
                    <Rock:RockLiteral ID="lPreviouslyPaid" runat="server" Label="Previously Paid" />
                    
                    <%-- For Partial Payments... --%>

                    <asp:HiddenField ID="hfMinimumDue" runat="server" />
                    <Rock:RockLiteral ID="lMinimumDue" runat="server" Label="Minimum Due Today" />
                    
                    <div class="form-right">
                        <Rock:CurrencyBox ID="nbAmountPaid" runat="server" CssClass="input-width-md amount-to-pay" NumberType="Currency" Label="Amount To Pay Today" Required="true" />
                    </div>
                                 
                    <Rock:RockLiteral ID="lRemainingDue" runat="server" Label="Amount Remaining" />


                    <%-- For Payoff --%>
                    
                    <Rock:RockLiteral ID="lAmountDue" runat="server" Label="Amount Due" />
                </div>
            </div>
                
        </asp:Panel>

        <asp:Panel ID="pnlPaymentInfo" runat="server" CssClass="well">

            <asp:Literal ID="lPaymentInfoTitle" runat="server" />

            <Rock:RockRadioButtonList ID="rblSavedCC" runat="server" CssClass="radio-list margin-b-lg" RepeatDirection="Vertical" DataValueField="Id" DataTextField="Name" />
            
            <div id="divNewCard" runat="server" class="radio-content">
                <Rock:RockTextBox ID="txtCardFirstName" runat="server" Label="First Name on Card" Visible="false" ></Rock:RockTextBox>
                <Rock:RockTextBox ID="txtCardLastName" runat="server" Label="Last Name on Card" Visible="false" ></Rock:RockTextBox>
                <Rock:RockTextBox ID="txtCardName" runat="server" Label="Name on Card" Visible="false" ></Rock:RockTextBox>
                <Rock:RockTextBox ID="txtCreditCard" runat="server" Label="Credit Card #" MaxLength="19" CssClass="credit-card" />
                <ul class="card-logos list-unstyled">
                    <li class="card-visa"></li>
                    <li class="card-mastercard"></li>
                    <li class="card-amex"></li>
                    <li class="card-discover"></li>
                </ul>
                <div class="row">
                    <div class="col-sm-6">
                        <Rock:MonthYearPicker ID="mypExpiration" runat="server" Label="Expiration Date" />
                    </div>
                    <div class="col-sm-6">
                        <Rock:RockTextBox ID="txtCVV" Label="Card Security Code" CssClass="input-width-xs" runat="server" MaxLength="4" />
                    </div>
                </div>
                <Rock:AddressControl ID="acBillingAddress" runat="server" UseStateAbbreviation="true" UseCountryAbbreviation="false" ShowAddressLine2="false" />
            </div>

        </asp:Panel>

        <div class="actions">
            <asp:LinkButton ID="lbSummaryPrev" runat="server" AccessKey="p" Text="Previous" CssClass="btn btn-default" CausesValidation="false" OnClick="lbSummaryPrev_Click" />
            <Rock:BootstrapButton ID="lbSummaryNext" runat="server" AccessKey="n" Text="Finish" DataLoadingText="Next" CssClass="btn btn-primary pull-right" CausesValidation="true" OnClick="lbSummaryNext_Click" />
            <asp:LinkButton ID="lbPaymentPrev" runat="server" AccessKey="p" Text="Previous" CssClass="btn btn-default" CausesValidation="false" OnClick="lbPaymentPrev_Click" />
            <asp:Label ID="aStep2Submit" runat="server" ClientIDMode="Static" CssClass="btn btn-primary pull-right" Text="Finish" />
        </div>

        <iframe id="iframeStep2" src="<%=this.Step2IFrameUrl%>" style="display:none"></iframe>

        <asp:HiddenField ID="hfStep2AutoSubmit" runat="server" Value="false" />
        <asp:HiddenField ID="hfStep2Url" runat="server" />
        <asp:HiddenField ID="hfStep2ReturnQueryString" runat="server" />
        <span style="display:none" >
            <asp:LinkButton ID="lbStep2Return" runat="server" Text="Step 2 Return" OnClick="lbStep2Return_Click" CausesValidation="false" ></asp:LinkButton>
        </span>

    </asp:Panel>

    <asp:Panel ID="pnlSuccess" runat="server" Visible="false" >
        
        <h1><asp:Literal ID="lSuccessTitle" runat="server" /></h1>

        <asp:Panel ID="pnlSuccessProgressBar" runat="server">
            <div class="progress">
                <div class="progress-bar" role="progressbar" aria-valuenow="<%=this.PercentComplete%>" aria-valuemin="0" aria-valuemax="100" style="width: <%=this.PercentComplete%>%;">
                    <span class="sr-only"><%=this.PercentComplete%>% Complete</span>
                </div>
            </div>
        </asp:Panel>

        <asp:Literal ID="lSuccess" runat="server" />
        <asp:Literal ID="lSuccessDebug" runat="server" Visible="false" />

        <asp:Panel ID="pnlSaveAccount" runat="server" Visible="false">
            <div class="well">
                <legend>Make Payments Even Easier</legend>
                <fieldset>
                    <Rock:RockCheckBox ID="cbSaveAccount" runat="server" Text="Save account information for future transactions" CssClass="toggle-input" />
                    <div id="divSaveAccount" runat="server" class="toggle-content">
                        <Rock:RockTextBox ID="txtSaveAccount" runat="server" Label="Name for this account" CssClass="input-large"></Rock:RockTextBox>

                        <asp:PlaceHolder ID="phCreateLogin" runat="server" Visible="false">

                            <div class="control-group">
                                <div class="controls">
                                    <div class="alert alert-info">
                                        <b>Note:</b> For security purposes you will need to login to use your saved account information.  To create
	    			                a login account please provide a user name and password below. You will be sent an email with the account 
	    			                information above as a reminder.
                                    </div>
                                </div>
                            </div>

                            <Rock:RockTextBox ID="txtUserName" runat="server" Label="Username" CssClass="input-medium" />
                            <Rock:RockTextBox ID="txtPassword" runat="server" Label="Password" CssClass="input-medium" TextMode="Password" />
                            <Rock:RockTextBox ID="txtPasswordConfirm" runat="server" Label="Confirm Password" CssClass="input-medium" TextMode="Password" />

                        </asp:PlaceHolder>

                        <Rock:NotificationBox ID="nbSaveAccount" runat="server" Visible="false" NotificationBoxType="Danger"></Rock:NotificationBox>

                        <div id="divSaveActions" runat="server" class="actions">
                            <asp:LinkButton ID="lbSaveAccount" runat="server" Text="Save Account" CssClass="btn btn-primary" OnClick="lbSaveAccount_Click" />
                        </div>
                    </div>
                </fieldset>                    
            </div>
        </asp:Panel>

    </asp:Panel>

</ContentTemplate>
</asp:UpdatePanel>
