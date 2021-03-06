<%@ Page language="c#" Codebehind="Certification_quiz_Gen.aspx.cs" AutoEventWireup="false" Inherits="DPI.Ordering.Training.Certification_quiz_Gen" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Certification Quiz</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body text="#000000" bgColor="#ffffff" leftMargin="0" topMargin="0" ms_positioning="GridLayout">
		<form id="Form1" method="post" runat="server">
			<table cellSpacing="0" cellPadding="0" width="511" align="left" border="0">
				<tr>
					<td style="WIDTH: 511px">
						<asp:Image id="Image1" runat="server" ImageUrl="../Main/images/printheader.jpg"></asp:Image></td>
				</tr>
				<tr>
					<td align="center">
						<table cellSpacing="0" cellPadding="0" width="640" align="middle" border="0">
							<tr>
								<td align="center">
									<asp:Label id="Label1" runat="server" Font-Names="Tahoma" Font-Bold="True" Font-Size="Large"
										Width="229px">Agent Certification</asp:Label></td>
							</tr>
							<tr>
								<td colspan="2" align="left" style="WIDTH: 529px">
									<asp:Label id="Label2" runat="server" Font-Names="Tahoma" Font-Bold="True" Font-Size="X-Small">Please enter your name:</asp:Label></td>
							</tr>
							<tr>
								<td style="WIDTH: 529px">
									<asp:Label id="Label3" runat="server" Font-Names="Tahoma" Font-Bold="True" Font-Size="X-Small">Co-Worker ID:</asp:Label>
									<asp:TextBox id="txtCoWorkerID" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;
									<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ErrorMessage="Please provide a coworker ID."
										ControlToValidate="txtCoWorkerID">*</asp:RequiredFieldValidator>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
									<asp:Label id="Label4" runat="server" Font-Names="Tahoma" Font-Bold="True" Font-Size="X-Small">Name: </asp:Label>
									<asp:TextBox id="txtName" runat="server"></asp:TextBox>
									<asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" ErrorMessage="Please provide a name."
										ControlToValidate="txtName">*</asp:RequiredFieldValidator></td>
							</tr>
							<tr>
								<td style=" HEIGHT: 89px" align="center">
									<asp:Label id="Label5" runat="server" Font-Names="Tahoma" Font-Bold="True" Font-Size="X-Small">Below are ten questions designed to confirm you knowledge of dPi's new WebCentral program. Please choose one answer for each question. To select an answer, simply click on the circle next to the answer you believe is correct. When complete, please click the submit button at the bottom of this page.</asp:Label></td>
							</tr>
							<tr>
								<td style=" HEIGHT: 38px" align="center">
									<asp:Label id="Label6" runat="server" Font-Names="Tahoma" Font-Bold="True" Font-Size="Medium">Questions:</asp:Label></td>
							</tr>
							<tr>
								<td style="WIDTH: 529px">
									<asp:Label id="Label16" runat="server" Width="544px" Font-Size="X-Small" Font-Bold="True" Font-Names="Tahoma">1.	What icon do you click to sign up a new customer for dPi Home Phone Service?</asp:Label>
									<asp:RequiredFieldValidator id="RequiredFieldValidator3" runat="server" ErrorMessage="Please provide an answer for question number 1."
										ControlToValidate="RadioButtonList1">*</asp:RequiredFieldValidator>
									<asp:RadioButtonList id="Radiobuttonlist1" runat="server" Width="264px" Font-Names="Tahoma" Font-Size="X-Small">
										<asp:ListItem Value="Product/Price Lookup">a. Product/Price Lookup</asp:ListItem>
										<asp:ListItem Value="New Order">b. New Order</asp:ListItem>
										<asp:ListItem Value="Monthly Payment">c. Monthly Payment</asp:ListItem>
									</asp:RadioButtonList>
								</td>
							</tr>
							<tr>
								<td style=" HEIGHT: 25px"><IMG height="1" src="../main/images/pixel_gray.jpg" width="100%" border="0"></td>
							</tr>
							<tr>
								<td style="WIDTH: 529px">
									<asp:Label id="Label7" runat="server" Width="384px" Font-Names="Tahoma" Font-Bold="True" Font-Size="X-Small"> 2. How are the prices and packages available determined?</asp:Label>
									<asp:RequiredFieldValidator id="RequiredFieldValidator4" runat="server" ErrorMessage="Please provide an answer for question number 2."
										ControlToValidate="Radiobuttonlist2">*</asp:RequiredFieldValidator>
									<asp:RadioButtonList id="Radiobuttonlist2" runat="server" Width="264px" Font-Names="Tahoma" Font-Size="X-Small">
										<asp:ListItem Value="State">a. State</asp:ListItem>
										<asp:ListItem Value="City">b. City</asp:ListItem>
										<asp:ListItem Value="Zip Code">c. Zip Code</asp:ListItem>
									</asp:RadioButtonList>
								</td>
							</tr>
							<tr>
								<td style=" HEIGHT: 25px"><IMG height="1" src="../main/images/pixel_gray.jpg" width="100%" border="0"></td>
							</tr>
							<tr>
								<td style="WIDTH: 529px">
									<asp:Label id="Label8" runat="server" Width="512px" Font-Names="Tahoma" Font-Bold="True" Font-Size="X-Small">3.	Which package contains 100 minutes of Long Distance each month for the life of the customer?</asp:Label>
									<asp:RequiredFieldValidator id="RequiredFieldValidator5" runat="server" ErrorMessage="Please provide an answer for question number 3."
										ControlToValidate="Radiobuttonlist3">*</asp:RequiredFieldValidator>
									<asp:RadioButtonList id="Radiobuttonlist3" runat="server" Width="264px" Font-Names="Tahoma" Font-Size="X-Small">
										<asp:ListItem Value="Basic">a. Basic</asp:ListItem>
										<asp:ListItem Value="Advantage">b. Advantage</asp:ListItem>
										<asp:ListItem Value="Complete">c. Complete</asp:ListItem>
									</asp:RadioButtonList>
								</td>
							</tr>
							<tr>
								<td style=" HEIGHT: 25px"><IMG height="1" src="../main/images/pixel_gray.jpg" width="100%" border="0"></td>
							</tr>
							<tr>
								<td style="WIDTH: 529px">
									<asp:Label id="Label9" runat="server" Width="512px" Font-Names="Tahoma" Font-Bold="True" Font-Size="X-Small">4.	What icon provides you with the information on what promotions are available in customerís service area?</asp:Label>
									<asp:RequiredFieldValidator id="RequiredFieldValidator6" runat="server" ErrorMessage="Please provide an answer for question number 4."
										ControlToValidate="Radiobuttonlist4">*</asp:RequiredFieldValidator>
									<asp:RadioButtonList id="Radiobuttonlist4" runat="server" Width="264px" Font-Names="Tahoma" Font-Size="X-Small">
										<asp:ListItem Value="New Order">a. New Order</asp:ListItem>
										<asp:ListItem Value="Product/Price Lookup">b. Product/Price Lookup</asp:ListItem>
										<asp:ListItem Value="Both A &amp; B">c. Both A &amp; B</asp:ListItem>
									</asp:RadioButtonList>
								</td>
							</tr>
							<tr>
								<td style=" HEIGHT: 25px"><IMG height="1" src="../main/images/pixel_gray.jpg" width="100%" border="0"></td>
							</tr>
							<tr>
								<td style="WIDTH: 529px">
									<asp:Label id="Label10" runat="server" Width="512px" Font-Names="Tahoma" Font-Bold="True" Font-Size="X-Small"> 5. What information do you need from the customer to process a monthly payment?</asp:Label>
									<asp:RequiredFieldValidator id="RequiredFieldValidator7" runat="server" ErrorMessage="Please provide an answer for question number 5."
										ControlToValidate="Radiobuttonlist5">*</asp:RequiredFieldValidator>
									<asp:RadioButtonList id="Radiobuttonlist5" runat="server" Width="264px" Font-Names="Tahoma" Font-Size="X-Small">
										<asp:ListItem Value="Name">a. Name</asp:ListItem>
										<asp:ListItem Value="Phone Number">b. Phone Number</asp:ListItem>
										<asp:ListItem Value="Address">c. Address</asp:ListItem>
									</asp:RadioButtonList>
								</td>
							</tr>
							<tr>
								<td style=" HEIGHT: 25px"><IMG height="1" src="../main/images/pixel_gray.jpg" width="100%" border="0"></td>
							</tr>
							<tr>
								<td style="WIDTH: 529px">
									<asp:Label id="Label11" runat="server" Width="512px" Font-Names="Tahoma" Font-Bold="True" Font-Size="X-Small">6.	Are you required to type the customers mailing address and service address if you check the box that indicates they are the same?</asp:Label>
									<asp:RequiredFieldValidator id="RequiredFieldValidator8" runat="server" ErrorMessage="Please provide an answer for question number 6."
										ControlToValidate="Radiobuttonlist6">*</asp:RequiredFieldValidator>
									<asp:RadioButtonList id="Radiobuttonlist6" runat="server" Width="264px" Font-Names="Tahoma" Font-Size="X-Small">
										<asp:ListItem Value="Yes">a. Yes</asp:ListItem>
										<asp:ListItem Value="No">b. No</asp:ListItem>
									</asp:RadioButtonList>
								</td>
							</tr>
							<tr>
								<td style=" HEIGHT: 25px"><IMG height="1" src="../main/images/pixel_gray.jpg" width="100%" border="0"></td>
							</tr>
							<tr>
								<td style="WIDTH: 529px">
									<asp:Label id="Label12" runat="server" Width="456px" Font-Names="Tahoma" Font-Bold="True" Font-Size="X-Small"> 7.	Can you recharge a customer Pre-Paid Cellular Phone for Verizon?</asp:Label>
									<asp:RequiredFieldValidator id="RequiredFieldValidator9" runat="server" ErrorMessage="Please provide an answer for question number 7."
										ControlToValidate="Radiobuttonlist7">*</asp:RequiredFieldValidator>
									<asp:RadioButtonList id="Radiobuttonlist7" runat="server" Width="264px" Font-Names="Tahoma" Font-Size="X-Small">
										<asp:ListItem Value="No">a. No</asp:ListItem>
										<asp:ListItem Value="Yes">b. Yes</asp:ListItem>
									</asp:RadioButtonList>
								</td>
							</tr>
							<tr>
								<td style=" HEIGHT: 25px"><IMG height="1" src="../main/images/pixel_gray.jpg" width="100%" border="0"></td>
							</tr>
							<tr>
								<td style="WIDTH: 529px">
									<asp:Label id="Label13" runat="server" Width="432px" Font-Names="Tahoma" Font-Bold="True" Font-Size="X-Small"> 8.	What report will you use to balance dPi with Your POS System?</asp:Label>
									<asp:RequiredFieldValidator id="RequiredFieldValidator10" runat="server" ErrorMessage="Please provide an answer for question number 8."
										ControlToValidate="Radiobuttonlist8">*</asp:RequiredFieldValidator>
									<asp:RadioButtonList id="Radiobuttonlist8" runat="server" Width="264px" Font-Names="Tahoma" Font-Size="X-Small">
										<asp:ListItem Value="Pending Customers by Order Date?">a. Pending Customers by Order Date?</asp:ListItem>
										<asp:ListItem Value="Daily Detail">b. Daily Detail</asp:ListItem>
										<asp:ListItem Value="Customers by Account Status">c. Customers by Account Status</asp:ListItem>
									</asp:RadioButtonList>
								</td>
							</tr>
							<tr>
								<td style=" HEIGHT: 25px"><IMG height="1" src="../main/images/pixel_gray.jpg" width="100%" border="0"></td>
							</tr>
							<tr>
								<td style="WIDTH: 529px">
									<asp:Label id="Label14" runat="server" Width="512px" Font-Names="Tahoma" Font-Bold="True" Font-Size="X-Small">9.	What report will provide you with a list of previous dPi customerís with address information?</asp:Label>
									<asp:RequiredFieldValidator id="RequiredFieldValidator11" runat="server" ErrorMessage="Please provide an answer for question number 9."
										ControlToValidate="Radiobuttonlist9">*</asp:RequiredFieldValidator>
									<asp:RadioButtonList id="Radiobuttonlist9" runat="server" Width="264px" Font-Names="Tahoma" Font-Size="X-Small">
										<asp:ListItem Value="Disconnected Customer List">a. Disconnected Customer List</asp:ListItem>
										<asp:ListItem Value="Active Customer List">b. Active Customer List</asp:ListItem>
										<asp:ListItem Value="Customer by Account Status">c. Customer by Account Status</asp:ListItem>
									</asp:RadioButtonList>
								</td>
							</tr>
							<tr>
								<td style=" HEIGHT: 25px"><IMG height="1" src="../main/images/pixel_gray.jpg" width="100%" border="0"></td>
							</tr>
							<tr>
								<td style="WIDTH: 529px">
									<asp:Label id="Label15" runat="server" Width="512px" Font-Names="Tahoma" Font-Bold="True" Font-Size="X-Small">10.	What functions can you use to get customers balance and pricing information instead of Customer Inquiry and Product/Price Lookup?</asp:Label>
									<asp:RequiredFieldValidator id="RequiredFieldValidator12" runat="server" ErrorMessage="Please provide an answer for question number 10."
										ControlToValidate="Radiobuttonlist10">*</asp:RequiredFieldValidator>
									<asp:RadioButtonList id="Radiobuttonlist10" runat="server" Width="264px" Font-Names="Tahoma" Font-Size="X-Small">
										<asp:ListItem Value="Reporting">a. Reporting</asp:ListItem>
										<asp:ListItem Value="New Order">b. New Order</asp:ListItem>
										<asp:ListItem Value="Monthly Payment and New Order">c. Monthly Payment and New Order</asp:ListItem>
									</asp:RadioButtonList>
								</td>
							</tr>
							<tr>
								<td style=" HEIGHT: 25px"><IMG height="1" src="../main/images/pixel_gray.jpg" width="100%" border="0"></td>
							</tr>
							<tr>
								<td align="center">
									<asp:ValidationSummary id="ValidationSummary1" runat="server" Width="528px"></asp:ValidationSummary>
									<asp:Label id="lblError" runat="server" Width="608px" Font-Names="Arial" ForeColor="Red" Visible="False"></asp:Label></td>
							</tr>
							<tr>
								<td align="center">
									<asp:ImageButton id="btnSubmit" runat="server" ImageUrl="../Main/images/btn_Submit.jpg"></asp:ImageButton></td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td style="WIDTH: 511px"></td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
