<%@ Page language="c#" Codebehind="rec_cc_payment.aspx.cs" AutoEventWireup="false" Inherits="Dpi.Central.Web.Account.Payment.CreditCardRecurringPaymentPage" %>
<%@ Register TagPrefix="duc" TagName="AccountInfo" Src="~/account/payment/account_info.ascx" %>
<%@ Register TagPrefix="duc" TagName="CreditCardInfo" Src="~/account/payment/cc_info.ascx" %>
<%@ Register TagPrefix="tb" TagName="Tabs" Src="~/account/tabs.ascx" %>
<%@ Register Namespace="Dpi.Central.Web.Controls" TagPrefix="dwc" Assembly="Dpi.Central.Web.Common" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>dPi Teleconnect LLC</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../../DPI.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="recurringCreditCardPaymentForm" method="post" runat="server">
			<tb:Tabs id="m_tabs" runat="server"></tb:Tabs>
			<div class="wide_form">				
				<div class="row">
					<span class="statement">By setting up a Recurring Payment, you are agreeing to 
						allow dPi Teleconnect to process a payment on a monthly basis by using the 
						Credit Card information provided/ We will automatically process the payment 
						every month on the Due Date indicated on your monthly statement. A confirmation 
						will be sent to the email address provided verifying if the payment is accepted 
						or denied.<br>
						<br>
						If you decide to stop enrollment in the Recurring Payment process, you may 
						disable this online by logging into your account and selecting to deactivate 
						the Credit Card entry which reflects the status of Active. Or you may contact 
						our Customer Service team to process this request.</span>
				</div>
			</div>
			<div class="form">
				<duc:accountinfo id="ctrlAccountInfo" runat="server"></duc:accountinfo>
				<duc:creditcardinfo id="ctrlCreditCardInfo" runat="server"></duc:creditcardinfo>
				<div class="button_row">
					<span class="button">
						<asp:imagebutton id="btnSubmit" runat="server" EnableViewState="False" ImageUrl="../../images/btn_submit.gif"></asp:imagebutton>
						<asp:imagebutton id="btnCancel" runat="server" ImageUrl="../../images/btn_cancel.gif" EnableViewState="False"
							CausesValidation="False"></asp:imagebutton>
					</span>
				</div>
				<div runat="server" id="detailsDiv" style="DISPLAY:none">
					<div class="row">
						<span class="label_note">* CVV2 Security Code 
							Example:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span><br>
						<IMG alt="CVV2 Security Code Example" src="../../images/cvv2a.gif">
					</div>
				</div>
			</div>
		</form>
	</body>
</HTML>
